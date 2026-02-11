using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace sohbet_uygulama
{
    public partial class Form1 : Form
    {
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        Thread receiveThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBağlan_Click(object sender, EventArgs e)
        {
            try 
            { 
                client = new TcpClient(txtServerIp.Text, int.Parse(txtPort.Text));
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream) { AutoFlush = true };

                writer.WriteLine(txtUsername.Text);

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                rtbChat.AppendText("Sistem: Sunucuya başarıyla bağlandınız." + Environment.NewLine);
                btnBağlan.Enabled = false;
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void receiveMessagess()
        {
            try
            {
                while (client != null && client.Connected)
                {
                    string msg = reader.ReadLine();
                    if (msg == null) break;

                    this.Invoke(new MethodInvoker(delegate
                    {
                        rtbChat.AppendText(msg + Environment.NewLine);
                        rtbChat.ScrollToCaret();
                    }));
                }
            }
            catch
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    rtbChat.AppendText("Sistem: Sunucu ile bağlantı kesildi." + Environment.NewLine);
                    btnBağlan.Enabled = true;
                }));
            }   
    }


        private void txtIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
        }
        private void ReceiveMessages()
        {
            try
            {
                while (client != null && client.Connected)
                {
                    string msg = reader.ReadLine();
                    if (msg == null) break;
                    Invoke(new Action(() =>
                    {
                        rtbChat.AppendText(msg + Environment.NewLine);
                        rtbChat.ScrollToCaret();
                    }));
                }
            }
            catch (IOException)
            {
                Invoke(new Action(() =>
               {
                   rtbChat.AppendText("Bağlantı sonlandı.\n");
               }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    rtbChat.AppendText("Hata: " + ex.Message + Environment.NewLine);
                }));
            }
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected && !string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                try
                {
                    string tamMesaj = txtUsername.Text + ": " + txtMessage.Text;
                    writer.WriteLine(tamMesaj);
                    txtMessage.Clear();
                    txtMessage.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mesaj gönderilemedi: " + ex.Message);
                }
            }
            else if (client == null || !client.Connected)
            {
                MessageBox.Show("Önce sunucuya bağlanmalısınız!");
            }
        }
            protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                if (client != null) client.Close();
                if (reader != null) reader.Close();
                if (writer != null) writer.Close();
            }
                catch { }
                base.OnFormClosing(e);
        }

            private void txtMessage_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    if (!string.IsNullOrWhiteSpace(txtMessage.Text))
                    {
                        btnGönder_Click(this, new EventArgs());
                    }
                }
            }
    }
}

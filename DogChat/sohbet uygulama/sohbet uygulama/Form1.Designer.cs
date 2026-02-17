namespace sohbet_uygulama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBağlan = new System.Windows.Forms.Button();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGönder = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBağlan
            // 
            this.btnBağlan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBağlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBağlan.FlatAppearance.BorderSize = 0;
            this.btnBağlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBağlan.Location = new System.Drawing.Point(88, 148);
            this.btnBağlan.Name = "btnBağlan";
            this.btnBağlan.Size = new System.Drawing.Size(100, 26);
            this.btnBağlan.TabIndex = 8;
            this.btnBağlan.Text = "Bağlan";
            this.btnBağlan.UseVisualStyleBackColor = false;
            this.btnBağlan.Click += new System.EventHandler(this.btnBağlan_Click);
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(84, 14);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(100, 20);
            this.txtServerIp.TabIndex = 9;
            this.txtServerIp.Text = "127.0.0.1";
            this.txtServerIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(85, 62);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "5000";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 107);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "No Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sunucu IP;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sunucu Port;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kullanıcı Adı;";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(465, 274);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 38);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGönder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGönder.FlatAppearance.BorderSize = 0;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGönder.Location = new System.Drawing.Point(268, 274);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(160, 38);
            this.btnGönder.TabIndex = 17;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(268, 62);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(326, 187);
            this.rtbChat.TabIndex = 16;
            this.rtbChat.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(403, 11);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(191, 20);
            this.txtMessage.TabIndex = 15;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(619, 324);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.btnBağlan);
            this.Name = "Form1";
            this.Text = "Sohbet Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBağlan;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtMessage;
    }
}


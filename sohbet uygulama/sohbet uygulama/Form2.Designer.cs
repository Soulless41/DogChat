namespace sohbet_uygulama
{
    partial class Form2
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGönder = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(177, 172);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 26);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGönder
            // 
            this.btnGönder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGönder.FlatAppearance.BorderSize = 0;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGönder.Location = new System.Drawing.Point(177, 224);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(88, 26);
            this.btnGönder.TabIndex = 6;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(19, 63);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(141, 187);
            this.rtbChat.TabIndex = 5;
            this.rtbChat.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(19, 12);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(141, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtMessage;
    }
}
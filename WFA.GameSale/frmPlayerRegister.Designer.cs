namespace WFA.GameSale
{
    partial class frmPlayerRegister
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.lblPlayerMail = new System.Windows.Forms.Label();
            this.lblCoin = new System.Windows.Forms.Label();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterMail = new System.Windows.Forms.TextBox();
            this.txtRegisterCoin = new System.Windows.Forms.TextBox();
            this.btnRegisterPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 34);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Kullanıcı Adı :";
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.Location = new System.Drawing.Point(13, 65);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPlayerPassword.TabIndex = 1;
            this.lblPlayerPassword.Text = "Şifre";
            // 
            // lblPlayerMail
            // 
            this.lblPlayerMail.AutoSize = true;
            this.lblPlayerMail.Location = new System.Drawing.Point(13, 98);
            this.lblPlayerMail.Name = "lblPlayerMail";
            this.lblPlayerMail.Size = new System.Drawing.Size(32, 13);
            this.lblPlayerMail.TabIndex = 2;
            this.lblPlayerMail.Text = "Mail :";
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Location = new System.Drawing.Point(13, 128);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(39, 13);
            this.lblCoin.TabIndex = 3;
            this.lblCoin.Text = "Bakiye";
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(122, 31);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterName.TabIndex = 4;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(122, 65);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterPassword.TabIndex = 5;
            // 
            // txtRegisterMail
            // 
            this.txtRegisterMail.Location = new System.Drawing.Point(122, 98);
            this.txtRegisterMail.Name = "txtRegisterMail";
            this.txtRegisterMail.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterMail.TabIndex = 6;
            // 
            // txtRegisterCoin
            // 
            this.txtRegisterCoin.Location = new System.Drawing.Point(122, 128);
            this.txtRegisterCoin.Name = "txtRegisterCoin";
            this.txtRegisterCoin.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterCoin.TabIndex = 7;
            // 
            // btnRegisterPlayer
            // 
            this.btnRegisterPlayer.Location = new System.Drawing.Point(190, 173);
            this.btnRegisterPlayer.Name = "btnRegisterPlayer";
            this.btnRegisterPlayer.Size = new System.Drawing.Size(91, 36);
            this.btnRegisterPlayer.TabIndex = 8;
            this.btnRegisterPlayer.Text = "Kaydol";
            this.btnRegisterPlayer.UseVisualStyleBackColor = true;
            this.btnRegisterPlayer.Click += new System.EventHandler(this.btnRegisterPlayer_Click);
            // 
            // frmPlayerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 221);
            this.Controls.Add(this.btnRegisterPlayer);
            this.Controls.Add(this.txtRegisterCoin);
            this.Controls.Add(this.txtRegisterMail);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterName);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.lblPlayerMail);
            this.Controls.Add(this.lblPlayerPassword);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "frmPlayerRegister";
            this.Text = "Kayıt Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.Label lblPlayerMail;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterMail;
        private System.Windows.Forms.TextBox txtRegisterCoin;
        private System.Windows.Forms.Button btnRegisterPlayer;
    }
}
namespace WFA.GamePlatform
{
    partial class frmPlayer
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
            this.txtRegPlayerName = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegPlayerBirth = new System.Windows.Forms.TextBox();
            this.txtRegPlayerMoney = new System.Windows.Forms.TextBox();
            this.lblRegPlayerName = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegPlayerName
            // 
            this.txtRegPlayerName.Location = new System.Drawing.Point(155, 12);
            this.txtRegPlayerName.Name = "txtRegPlayerName";
            this.txtRegPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtRegPlayerName.TabIndex = 0;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(155, 38);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRegPassword.TabIndex = 1;
            // 
            // txtRegPlayerBirth
            // 
            this.txtRegPlayerBirth.Location = new System.Drawing.Point(155, 64);
            this.txtRegPlayerBirth.Name = "txtRegPlayerBirth";
            this.txtRegPlayerBirth.Size = new System.Drawing.Size(100, 20);
            this.txtRegPlayerBirth.TabIndex = 2;
            // 
            // txtRegPlayerMoney
            // 
            this.txtRegPlayerMoney.Location = new System.Drawing.Point(155, 90);
            this.txtRegPlayerMoney.Name = "txtRegPlayerMoney";
            this.txtRegPlayerMoney.Size = new System.Drawing.Size(100, 20);
            this.txtRegPlayerMoney.TabIndex = 3;
            // 
            // lblRegPlayerName
            // 
            this.lblRegPlayerName.AutoSize = true;
            this.lblRegPlayerName.Location = new System.Drawing.Point(12, 15);
            this.lblRegPlayerName.Name = "lblRegPlayerName";
            this.lblRegPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblRegPlayerName.TabIndex = 4;
            this.lblRegPlayerName.Text = "Kullanıcı Adı ";
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(12, 41);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(28, 13);
            this.lblRegPassword.TabIndex = 5;
            this.lblRegPassword.Text = "Şifre";
            // 
            // lblRegBirth
            // 
            this.lblRegBirth.AutoSize = true;
            this.lblRegBirth.Location = new System.Drawing.Point(12, 67);
            this.lblRegBirth.Name = "lblRegBirth";
            this.lblRegBirth.Size = new System.Drawing.Size(138, 13);
            this.lblRegBirth.TabIndex = 6;
            this.lblRegBirth.Text = "Doğum Tarihi(gg/aa/YYYY)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bakiye(TL)";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(155, 116);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(100, 20);
            this.txtRegEmail.TabIndex = 8;
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Location = new System.Drawing.Point(11, 119);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(32, 13);
            this.lblRegEmail.TabIndex = 9;
            this.lblRegEmail.Text = "Email";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(177, 155);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(78, 33);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 200);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegBirth);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.lblRegPlayerName);
            this.Controls.Add(this.txtRegPlayerMoney);
            this.Controls.Add(this.txtRegPlayerBirth);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegPlayerName);
            this.Name = "frmPlayer";
            this.Text = "Oyuncu Kayıt Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegPlayerName;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegPlayerBirth;
        private System.Windows.Forms.TextBox txtRegPlayerMoney;
        private System.Windows.Forms.Label lblRegPlayerName;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.Button btnRegister;
    }
}
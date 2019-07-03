namespace WFA.GameSale
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblLoginPlayerPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Oturum Aç";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(100, 46);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(123, 20);
            this.txtLoginName.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(100, 86);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(123, 20);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(12, 49);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(70, 13);
            this.lblLoginName.TabIndex = 3;
            this.lblLoginName.Text = "Kullanıcı Adı :";
            // 
            // lblLoginPlayerPassword
            // 
            this.lblLoginPlayerPassword.AutoSize = true;
            this.lblLoginPlayerPassword.Location = new System.Drawing.Point(12, 89);
            this.lblLoginPlayerPassword.Name = "lblLoginPlayerPassword";
            this.lblLoginPlayerPassword.Size = new System.Drawing.Size(28, 13);
            this.lblLoginPlayerPassword.TabIndex = 4;
            this.lblLoginPlayerPassword.Text = "Şifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLoginPlayerPassword);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Giriş ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblLoginPlayerPassword;
        private System.Windows.Forms.Button button1;
    }
}
namespace WFA.GamePlatform
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
            this.txtLoginPlayerPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPlayerPassword = new System.Windows.Forms.Label();
            this.txtLoginPlayerName = new System.Windows.Forms.TextBox();
            this.lblLoginPlayerName = new System.Windows.Forms.Label();
            this.btnLoginRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(127, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtLoginPlayerPassword
            // 
            this.txtLoginPlayerPassword.CausesValidation = false;
            this.txtLoginPlayerPassword.Location = new System.Drawing.Point(95, 80);
            this.txtLoginPlayerPassword.Name = "txtLoginPlayerPassword";
            this.txtLoginPlayerPassword.Size = new System.Drawing.Size(108, 20);
            this.txtLoginPlayerPassword.TabIndex = 1;
            // 
            // lblLoginPlayerPassword
            // 
            this.lblLoginPlayerPassword.AutoSize = true;
            this.lblLoginPlayerPassword.CausesValidation = false;
            this.lblLoginPlayerPassword.Location = new System.Drawing.Point(12, 87);
            this.lblLoginPlayerPassword.Name = "lblLoginPlayerPassword";
            this.lblLoginPlayerPassword.Size = new System.Drawing.Size(28, 13);
            this.lblLoginPlayerPassword.TabIndex = 2;
            this.lblLoginPlayerPassword.Text = "Şifre";
            // 
            // txtLoginPlayerName
            // 
            this.txtLoginPlayerName.CausesValidation = false;
            this.txtLoginPlayerName.Location = new System.Drawing.Point(95, 54);
            this.txtLoginPlayerName.Name = "txtLoginPlayerName";
            this.txtLoginPlayerName.Size = new System.Drawing.Size(108, 20);
            this.txtLoginPlayerName.TabIndex = 3;
            // 
            // lblLoginPlayerName
            // 
            this.lblLoginPlayerName.AutoSize = true;
            this.lblLoginPlayerName.CausesValidation = false;
            this.lblLoginPlayerName.Location = new System.Drawing.Point(12, 57);
            this.lblLoginPlayerName.Name = "lblLoginPlayerName";
            this.lblLoginPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblLoginPlayerName.TabIndex = 4;
            this.lblLoginPlayerName.Text = "Kullanıcı Adı ";
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.Location = new System.Drawing.Point(12, 127);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(83, 33);
            this.btnLoginRegister.TabIndex = 5;
            this.btnLoginRegister.Text = "Kayıt Ol";
            this.btnLoginRegister.UseVisualStyleBackColor = true;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 197);
            this.Controls.Add(this.btnLoginRegister);
            this.Controls.Add(this.lblLoginPlayerName);
            this.Controls.Add(this.txtLoginPlayerName);
            this.Controls.Add(this.lblLoginPlayerPassword);
            this.Controls.Add(this.txtLoginPlayerPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Login Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPlayerPassword;
        private System.Windows.Forms.Label lblLoginPlayerPassword;
        private System.Windows.Forms.TextBox txtLoginPlayerName;
        private System.Windows.Forms.Label lblLoginPlayerName;
        private System.Windows.Forms.Button btnLoginRegister;
    }
}
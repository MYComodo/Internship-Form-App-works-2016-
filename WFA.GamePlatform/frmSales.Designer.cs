namespace WFA.GamePlatform
{
    partial class frmSales
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
            this.cmbxPlayerSelect = new System.Windows.Forms.ComboBox();
            this.lblBuyingPlayer = new System.Windows.Forms.Label();
            this.cmbxGameSelect = new System.Windows.Forms.ComboBox();
            this.lblBuyGame = new System.Windows.Forms.Label();
            this.btnBuyGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxPlayerSelect
            // 
            this.cmbxPlayerSelect.FormattingEnabled = true;
            this.cmbxPlayerSelect.Location = new System.Drawing.Point(133, 33);
            this.cmbxPlayerSelect.Name = "cmbxPlayerSelect";
            this.cmbxPlayerSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbxPlayerSelect.TabIndex = 0;
            this.cmbxPlayerSelect.SelectedIndexChanged += new System.EventHandler(this.cmbxPlayerSelect_SelectedIndexChanged);
            this.cmbxPlayerSelect.TextChanged += new System.EventHandler(this.cmbxPlayerSelect_TextChanged);
            // 
            // lblBuyingPlayer
            // 
            this.lblBuyingPlayer.AutoSize = true;
            this.lblBuyingPlayer.Location = new System.Drawing.Point(12, 36);
            this.lblBuyingPlayer.Name = "lblBuyingPlayer";
            this.lblBuyingPlayer.Size = new System.Drawing.Size(66, 13);
            this.lblBuyingPlayer.TabIndex = 1;
            this.lblBuyingPlayer.Text = "Oyuncu Seç";
            // 
            // cmbxGameSelect
            // 
            this.cmbxGameSelect.FormattingEnabled = true;
            this.cmbxGameSelect.Location = new System.Drawing.Point(133, 85);
            this.cmbxGameSelect.Name = "cmbxGameSelect";
            this.cmbxGameSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbxGameSelect.TabIndex = 2;
            // 
            // lblBuyGame
            // 
            this.lblBuyGame.AutoSize = true;
            this.lblBuyGame.Location = new System.Drawing.Point(12, 88);
            this.lblBuyGame.Name = "lblBuyGame";
            this.lblBuyGame.Size = new System.Drawing.Size(54, 13);
            this.lblBuyGame.TabIndex = 3;
            this.lblBuyGame.Text = "Oyun Seç";
            // 
            // btnBuyGame
            // 
            this.btnBuyGame.Location = new System.Drawing.Point(157, 135);
            this.btnBuyGame.Name = "btnBuyGame";
            this.btnBuyGame.Size = new System.Drawing.Size(97, 37);
            this.btnBuyGame.TabIndex = 4;
            this.btnBuyGame.Text = "Onayla";
            this.btnBuyGame.UseVisualStyleBackColor = true;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 191);
            this.Controls.Add(this.btnBuyGame);
            this.Controls.Add(this.lblBuyGame);
            this.Controls.Add(this.cmbxGameSelect);
            this.Controls.Add(this.lblBuyingPlayer);
            this.Controls.Add(this.cmbxPlayerSelect);
            this.Name = "frmSales";
            this.Text = "Satış Formu ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPlayerSelect;
        private System.Windows.Forms.Label lblBuyingPlayer;
        private System.Windows.Forms.ComboBox cmbxGameSelect;
        private System.Windows.Forms.Label lblBuyGame;
        private System.Windows.Forms.Button btnBuyGame;
    }
}
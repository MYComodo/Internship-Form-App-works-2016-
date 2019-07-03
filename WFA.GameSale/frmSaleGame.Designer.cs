namespace WFA.GameSale
{
    partial class frmSaleGame
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
            this.btnBuyGame = new System.Windows.Forms.Button();
            this.cboGame = new System.Windows.Forms.ComboBox();
            this.lblBuyReport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuyGame
            // 
            this.btnBuyGame.Location = new System.Drawing.Point(213, 78);
            this.btnBuyGame.Name = "btnBuyGame";
            this.btnBuyGame.Size = new System.Drawing.Size(75, 23);
            this.btnBuyGame.TabIndex = 0;
            this.btnBuyGame.Text = "Satın Al";
            this.btnBuyGame.UseVisualStyleBackColor = true;
            this.btnBuyGame.Click += new System.EventHandler(this.btnBuyGame_Click);
            // 
            // cboGame
            // 
            this.cboGame.FormattingEnabled = true;
            this.cboGame.Location = new System.Drawing.Point(167, 37);
            this.cboGame.Name = "cboGame";
            this.cboGame.Size = new System.Drawing.Size(121, 21);
            this.cboGame.TabIndex = 1;
            // 
            // lblBuyReport
            // 
            this.lblBuyReport.AutoSize = true;
            this.lblBuyReport.Location = new System.Drawing.Point(246, 115);
            this.lblBuyReport.Name = "lblBuyReport";
            this.lblBuyReport.Size = new System.Drawing.Size(13, 13);
            this.lblBuyReport.TabIndex = 2;
            this.lblBuyReport.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satın Alınacak Oyunu Seçiniz.";
            // 
            // frmSaleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBuyReport);
            this.Controls.Add(this.cboGame);
            this.Controls.Add(this.btnBuyGame);
            this.Name = "frmSaleGame";
            this.Text = "Oyun Satışı";
            this.Load += new System.EventHandler(this.frmSaleGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuyGame;
        private System.Windows.Forms.ComboBox cboGame;
        private System.Windows.Forms.Label lblBuyReport;
        private System.Windows.Forms.Label label1;
    }
}
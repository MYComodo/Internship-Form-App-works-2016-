namespace WFA.GameSale
{
    partial class frmAddGame
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGamePrice = new System.Windows.Forms.Label();
            this.txtAddGameName = new System.Windows.Forms.TextBox();
            this.txtAddGamePrice = new System.Windows.Forms.TextBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(24, 37);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(59, 13);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Oyun İsmi :";
            // 
            // lblGamePrice
            // 
            this.lblGamePrice.AutoSize = true;
            this.lblGamePrice.Location = new System.Drawing.Point(24, 84);
            this.lblGamePrice.Name = "lblGamePrice";
            this.lblGamePrice.Size = new System.Drawing.Size(37, 13);
            this.lblGamePrice.TabIndex = 1;
            this.lblGamePrice.Text = "Fiyatı :";
            // 
            // txtAddGameName
            // 
            this.txtAddGameName.Location = new System.Drawing.Point(115, 34);
            this.txtAddGameName.Name = "txtAddGameName";
            this.txtAddGameName.Size = new System.Drawing.Size(100, 20);
            this.txtAddGameName.TabIndex = 2;
            // 
            // txtAddGamePrice
            // 
            this.txtAddGamePrice.Location = new System.Drawing.Point(115, 81);
            this.txtAddGamePrice.Name = "txtAddGamePrice";
            this.txtAddGamePrice.Size = new System.Drawing.Size(100, 20);
            this.txtAddGamePrice.TabIndex = 3;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(140, 115);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddGame.TabIndex = 4;
            this.btnAddGame.Text = "Ekle";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // frmAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 150);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.txtAddGamePrice);
            this.Controls.Add(this.txtAddGameName);
            this.Controls.Add(this.lblGamePrice);
            this.Controls.Add(this.lblGameName);
            this.Name = "frmAddGame";
            this.Text = "Oyun Platformu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblGamePrice;
        private System.Windows.Forms.TextBox txtAddGameName;
        private System.Windows.Forms.TextBox txtAddGamePrice;
        private System.Windows.Forms.Button btnAddGame;
    }
}
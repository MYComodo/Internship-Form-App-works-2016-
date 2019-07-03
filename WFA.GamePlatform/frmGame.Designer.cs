namespace WFA.GamePlatform
{
    partial class frmGame
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
            this.btnGameAdd = new System.Windows.Forms.Button();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.txtGameDifficulty = new System.Windows.Forms.TextBox();
            this.txtGamePrice = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGameDifficulty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGameAdd
            // 
            this.btnGameAdd.Location = new System.Drawing.Point(130, 97);
            this.btnGameAdd.Name = "btnGameAdd";
            this.btnGameAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGameAdd.TabIndex = 0;
            this.btnGameAdd.Text = "Ekle";
            this.btnGameAdd.UseVisualStyleBackColor = true;
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(105, 19);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(100, 20);
            this.txtGameName.TabIndex = 1;
            // 
            // txtGameDifficulty
            // 
            this.txtGameDifficulty.Location = new System.Drawing.Point(105, 45);
            this.txtGameDifficulty.Name = "txtGameDifficulty";
            this.txtGameDifficulty.Size = new System.Drawing.Size(100, 20);
            this.txtGameDifficulty.TabIndex = 2;
            // 
            // txtGamePrice
            // 
            this.txtGamePrice.Location = new System.Drawing.Point(105, 71);
            this.txtGamePrice.Name = "txtGamePrice";
            this.txtGamePrice.Size = new System.Drawing.Size(100, 20);
            this.txtGamePrice.TabIndex = 3;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(49, 22);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(50, 13);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "Oyun Adı";
            // 
            // lblGameDifficulty
            // 
            this.lblGameDifficulty.AutoSize = true;
            this.lblGameDifficulty.Location = new System.Drawing.Point(49, 48);
            this.lblGameDifficulty.Name = "lblGameDifficulty";
            this.lblGameDifficulty.Size = new System.Drawing.Size(43, 13);
            this.lblGameDifficulty.TabIndex = 5;
            this.lblGameDifficulty.Text = "Zorluğu";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(49, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Fiyatı";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 137);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGameDifficulty);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtGamePrice);
            this.Controls.Add(this.txtGameDifficulty);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.btnGameAdd);
            this.Name = "frmGame";
            this.Text = "Oyun Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameAdd;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.TextBox txtGameDifficulty;
        private System.Windows.Forms.TextBox txtGamePrice;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblGameDifficulty;
        private System.Windows.Forms.Label lblPrice;
    }
}
namespace WFA.GameSale
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
            this.btnGameBuy = new System.Windows.Forms.Button();
            this.dgvGamePrice = new System.Windows.Forms.DataGridView();
            this.btnPrice = new System.Windows.Forms.Button();
            this.cbSortCondition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGameBuy
            // 
            this.btnGameBuy.Location = new System.Drawing.Point(12, 197);
            this.btnGameBuy.Name = "btnGameBuy";
            this.btnGameBuy.Size = new System.Drawing.Size(107, 36);
            this.btnGameBuy.TabIndex = 0;
            this.btnGameBuy.Text = "Oyun Al";
            this.btnGameBuy.UseVisualStyleBackColor = true;
            this.btnGameBuy.Click += new System.EventHandler(this.btnGameBuy_Click);
            // 
            // dgvGamePrice
            // 
            this.dgvGamePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGamePrice.Location = new System.Drawing.Point(12, 12);
            this.dgvGamePrice.Name = "dgvGamePrice";
            this.dgvGamePrice.Size = new System.Drawing.Size(240, 179);
            this.dgvGamePrice.TabIndex = 1;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(258, 12);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(114, 33);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Sırala";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // cbSortCondition
            // 
            this.cbSortCondition.FormattingEnabled = true;
            this.cbSortCondition.Location = new System.Drawing.Point(378, 19);
            this.cbSortCondition.Name = "cbSortCondition";
            this.cbSortCondition.Size = new System.Drawing.Size(121, 21);
            this.cbSortCondition.TabIndex = 3;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 325);
            this.Controls.Add(this.cbSortCondition);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.dgvGamePrice);
            this.Controls.Add(this.btnGameBuy);
            this.Name = "frmPlayer";
            this.Text = "frmPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlayer_FormClosing);
           
            this.Load += new System.EventHandler(this.frmPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameBuy;
        private System.Windows.Forms.DataGridView dgvGamePrice;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.ComboBox cbSortCondition;
    }
}
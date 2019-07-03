namespace WFA.DestructorGames
{
    partial class frmUpdatePlayer
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
            this.dgvShowPlayer = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegUpdatePlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowPlayer
            // 
            this.dgvShowPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowPlayer.Location = new System.Drawing.Point(10, 65);
            this.dgvShowPlayer.Name = "dgvShowPlayer";
            this.dgvShowPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowPlayer.Size = new System.Drawing.Size(650, 306);
            this.dgvShowPlayer.TabIndex = 0;
            this.dgvShowPlayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowPlayer_CellContentClick);
            this.dgvShowPlayer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowPlayer_CellMouseClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(462, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Para";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(266, 13);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(100, 20);
            this.txtNick.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nick";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(70, 13);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // btnRegUpdatePlayer
            // 
            this.btnRegUpdatePlayer.Location = new System.Drawing.Point(587, 12);
            this.btnRegUpdatePlayer.Name = "btnRegUpdatePlayer";
            this.btnRegUpdatePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnRegUpdatePlayer.TabIndex = 3;
            this.btnRegUpdatePlayer.Text = "Kaydet";
            this.btnRegUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnRegUpdatePlayer.Click += new System.EventHandler(this.btnRegUpdatePlayer_Click);
            // 
            // frmUpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 383);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegUpdatePlayer);
            this.Controls.Add(this.dgvShowPlayer);
            this.Name = "frmUpdatePlayer";
            this.Text = "frmUpdatePlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdatePlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdatePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowPlayer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegUpdatePlayer;
    }
}
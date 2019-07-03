namespace WFA.GameSale
{
    partial class frmAdmin
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
            this.dgvShowPlayer = new System.Windows.Forms.DataGridView();
            this.btnShowPlayer = new System.Windows.Forms.Button();
            this.dvgShowGame = new System.Windows.Forms.DataGridView();
            this.btnShowGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowGame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGameAdd
            // 
            this.btnGameAdd.Location = new System.Drawing.Point(649, 294);
            this.btnGameAdd.Name = "btnGameAdd";
            this.btnGameAdd.Size = new System.Drawing.Size(95, 45);
            this.btnGameAdd.TabIndex = 0;
            this.btnGameAdd.Text = "OyunEkle";
            this.btnGameAdd.UseVisualStyleBackColor = true;
            this.btnGameAdd.Click += new System.EventHandler(this.btnGameAdd_Click);
            // 
            // dgvShowPlayer
            // 
            this.dgvShowPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowPlayer.Location = new System.Drawing.Point(12, 12);
            this.dgvShowPlayer.Name = "dgvShowPlayer";
            this.dgvShowPlayer.Size = new System.Drawing.Size(240, 183);
            this.dgvShowPlayer.TabIndex = 1;
            // 
            // btnShowPlayer
            // 
            this.btnShowPlayer.Location = new System.Drawing.Point(266, 12);
            this.btnShowPlayer.Name = "btnShowPlayer";
            this.btnShowPlayer.Size = new System.Drawing.Size(75, 34);
            this.btnShowPlayer.TabIndex = 2;
            this.btnShowPlayer.Text = "Oyuncu Göster";
            this.btnShowPlayer.UseVisualStyleBackColor = true;
            this.btnShowPlayer.Click += new System.EventHandler(this.btnShowPlayer_Click);
            // 
            // dvgShowGame
            // 
            this.dvgShowGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShowGame.Location = new System.Drawing.Point(347, 12);
            this.dvgShowGame.Name = "dvgShowGame";
            this.dvgShowGame.Size = new System.Drawing.Size(240, 183);
            this.dvgShowGame.TabIndex = 3;
            // 
            // btnShowGame
            // 
            this.btnShowGame.Location = new System.Drawing.Point(593, 12);
            this.btnShowGame.Name = "btnShowGame";
            this.btnShowGame.Size = new System.Drawing.Size(90, 34);
            this.btnShowGame.TabIndex = 4;
            this.btnShowGame.Text = "Oyun Göster";
            this.btnShowGame.UseVisualStyleBackColor = true;
            this.btnShowGame.Click += new System.EventHandler(this.btnShowGame_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 351);
            this.Controls.Add(this.btnShowGame);
            this.Controls.Add(this.dvgShowGame);
            this.Controls.Add(this.btnShowPlayer);
            this.Controls.Add(this.dgvShowPlayer);
            this.Controls.Add(this.btnGameAdd);
            this.Name = "frmAdmin";
            this.Text = "Kontrol Paneli ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameAdd;
        private System.Windows.Forms.DataGridView dgvShowPlayer;
        private System.Windows.Forms.Button btnShowPlayer;
        private System.Windows.Forms.DataGridView dvgShowGame;
        private System.Windows.Forms.Button btnShowGame;
    }
}
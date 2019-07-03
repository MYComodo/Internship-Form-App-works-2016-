namespace WFA.DestructorGames
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyuncuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdatePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateGame = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteGame = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyuncuİşlemleriToolStripMenuItem,
            this.oyunİşlemleriToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(114, 303);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyuncuİşlemleriToolStripMenuItem
            // 
            this.oyuncuİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPlayer,
            this.btnUpdatePlayer,
            this.btnDeletePlayer});
            this.oyuncuİşlemleriToolStripMenuItem.Name = "oyuncuİşlemleriToolStripMenuItem";
            this.oyuncuİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.oyuncuİşlemleriToolStripMenuItem.Text = "Oyuncu İşlemleri";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPlayer.Image")));
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(152, 22);
            this.btnAddPlayer.Text = "Ekle";
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(152, 22);
            this.btnUpdatePlayer.Text = "Güncelle";
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(152, 22);
            this.btnDeletePlayer.Text = "Sil";
            // 
            // oyunİşlemleriToolStripMenuItem
            // 
            this.oyunİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddGame,
            this.btnUpdateGame,
            this.btnDeleteGame});
            this.oyunİşlemleriToolStripMenuItem.Name = "oyunİşlemleriToolStripMenuItem";
            this.oyunİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.oyunİşlemleriToolStripMenuItem.Text = "Oyun İşlemleri";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(152, 22);
            this.btnAddGame.Text = "Ekle";
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnUpdateGame
            // 
            this.btnUpdateGame.Name = "btnUpdateGame";
            this.btnUpdateGame.Size = new System.Drawing.Size(152, 22);
            this.btnUpdateGame.Text = "Güncelle";
            this.btnUpdateGame.Click += new System.EventHandler(this.btnUpdateGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(152, 22);
            this.btnDeleteGame.Text = "Sil";
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSale});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // btnSale
            // 
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(121, 22);
            this.btnSale.Text = "Satış Yap";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyuncuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddPlayer;
        private System.Windows.Forms.ToolStripMenuItem oyunİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddGame;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnUpdatePlayer;
        private System.Windows.Forms.ToolStripMenuItem btnDeletePlayer;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateGame;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteGame;
    }
}
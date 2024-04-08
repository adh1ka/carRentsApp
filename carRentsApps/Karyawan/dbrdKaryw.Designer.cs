namespace carRentsApps.Karyawan
{
    partial class dbrdKaryw
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.riwayatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logooutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karyawanToolStripMenuItem,
            this.riwayatTransaksiToolStripMenuItem,
            this.manajemenPelangganToolStripMenuItem,
            this.pengaturanToolStripMenuItem,
            this.logooutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // riwayatTransaksiToolStripMenuItem
            // 
            this.riwayatTransaksiToolStripMenuItem.Name = "riwayatTransaksiToolStripMenuItem";
            this.riwayatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.riwayatTransaksiToolStripMenuItem.Text = "Riwayat Transaksi";
            // 
            // manajemenPelangganToolStripMenuItem
            // 
            this.manajemenPelangganToolStripMenuItem.Name = "manajemenPelangganToolStripMenuItem";
            this.manajemenPelangganToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.manajemenPelangganToolStripMenuItem.Text = "Manajemen Pelanggan";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // logooutToolStripMenuItem
            // 
            this.logooutToolStripMenuItem.Name = "logooutToolStripMenuItem";
            this.logooutToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.logooutToolStripMenuItem.Text = "Logoout";
            // 
            // dbrdKaryw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 775);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dbrdKaryw";
            this.Text = "dbrdKaryw";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logooutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
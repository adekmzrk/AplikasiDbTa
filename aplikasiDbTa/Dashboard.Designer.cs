namespace aplikasiDbTa
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatJadwalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buatJadwalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formSidangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalToolStripMenuItem,
            this.formSidangToolStripMenuItem,
            this.inputDataToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.manageUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatJadwalToolStripMenuItem1,
            this.buatJadwalToolStripMenuItem1});
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.jadwalToolStripMenuItem.Text = "Jadwal";
            // 
            // lihatJadwalToolStripMenuItem1
            // 
            this.lihatJadwalToolStripMenuItem1.Name = "lihatJadwalToolStripMenuItem1";
            this.lihatJadwalToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lihatJadwalToolStripMenuItem1.Text = "Lihat Jadwal";
            // 
            // buatJadwalToolStripMenuItem1
            // 
            this.buatJadwalToolStripMenuItem1.Name = "buatJadwalToolStripMenuItem1";
            this.buatJadwalToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.buatJadwalToolStripMenuItem1.Text = "Buat Jadwal";
            // 
            // formSidangToolStripMenuItem
            // 
            this.formSidangToolStripMenuItem.Name = "formSidangToolStripMenuItem";
            this.formSidangToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.formSidangToolStripMenuItem.Text = "Form Sidang";
            // 
            // inputDataToolStripMenuItem
            // 
            this.inputDataToolStripMenuItem.Name = "inputDataToolStripMenuItem";
            this.inputDataToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.inputDataToolStripMenuItem.Text = "Input Data";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatJadwalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buatJadwalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formSidangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
    }
}
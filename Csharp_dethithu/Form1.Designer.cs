namespace Csharp_dethithu
{
    partial class FRMMAIN
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiệnÍchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaiPTBac2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(167, 124);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(381, 46);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Thông Tin Sinh Viên";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.tiệnÍchToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tiệnÍchToolStripMenuItem
            // 
            this.tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaiPTBac2ToolStripMenuItem,
            this.dinhDangToolStripMenuItem});
            this.tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            this.tiệnÍchToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tiệnÍchToolStripMenuItem.Text = "Tiện ích";
            // 
            // giaiPTBac2ToolStripMenuItem
            // 
            this.giaiPTBac2ToolStripMenuItem.Name = "giaiPTBac2ToolStripMenuItem";
            this.giaiPTBac2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giaiPTBac2ToolStripMenuItem.Text = "Giai PT bac 2";
            this.giaiPTBac2ToolStripMenuItem.Click += new System.EventHandler(this.giaiPTBac2ToolStripMenuItem_Click);
            // 
            // dinhDangToolStripMenuItem
            // 
            this.dinhDangToolStripMenuItem.Name = "dinhDangToolStripMenuItem";
            this.dinhDangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dinhDangToolStripMenuItem.Text = "Dinh dang";
            this.dinhDangToolStripMenuItem.Click += new System.EventHandler(this.dinhDangToolStripMenuItem_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioiThieuToolStripMenuItem,
            this.capNhatToolStripMenuItem});
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.troGiupToolStripMenuItem.Text = "Tro Giup";
            // 
            // gioiThieuToolStripMenuItem
            // 
            this.gioiThieuToolStripMenuItem.Name = "gioiThieuToolStripMenuItem";
            this.gioiThieuToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gioiThieuToolStripMenuItem.Text = "Gioi Thieu";
            this.gioiThieuToolStripMenuItem.Click += new System.EventHandler(this.gioiThieuToolStripMenuItem_Click);
            // 
            // capNhatToolStripMenuItem
            // 
            this.capNhatToolStripMenuItem.Name = "capNhatToolStripMenuItem";
            this.capNhatToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.capNhatToolStripMenuItem.Text = "Cap Nhat";
            // 
            // FRMMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMMAIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaiPTBac2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioiThieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capNhatToolStripMenuItem;
    }
}


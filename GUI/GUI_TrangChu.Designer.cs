namespace GUI
{
    partial class GUI_TrangChu
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
            this.splitContainerHeader = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripAdmin = new System.Windows.Forms.ToolStrip();
            this.toolStrip_quanlythanhvien = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_quanlyphieumuon = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripThongke = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.iconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Chucnang = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).BeginInit();
            this.splitContainerHeader.Panel1.SuspendLayout();
            this.splitContainerHeader.Panel2.SuspendLayout();
            this.splitContainerHeader.SuspendLayout();
            this.toolStripAdmin.SuspendLayout();
            this.toolStripThongke.SuspendLayout();
            this.menuStripHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerHeader
            // 
            this.splitContainerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHeader.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerHeader.IsSplitterFixed = true;
            this.splitContainerHeader.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHeader.Name = "splitContainerHeader";
            this.splitContainerHeader.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHeader.Panel1
            // 
            this.splitContainerHeader.Panel1.Controls.Add(this.label1);
            this.splitContainerHeader.Panel1.Controls.Add(this.toolStripAdmin);
            this.splitContainerHeader.Panel1.Controls.Add(this.toolStripThongke);
            this.splitContainerHeader.Panel1.Controls.Add(this.menuStripHeader);
            // 
            // splitContainerHeader.Panel2
            // 
            this.splitContainerHeader.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerHeader.Panel2.Controls.Add(this.panel_Chucnang);
            this.splitContainerHeader.Size = new System.Drawing.Size(800, 450);
            this.splitContainerHeader.SplitterDistance = 140;
            this.splitContainerHeader.SplitterWidth = 1;
            this.splitContainerHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to TAY NGUYEN University";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStripAdmin
            // 
            this.toolStripAdmin.AutoSize = false;
            this.toolStripAdmin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_quanlythanhvien,
            this.toolStripSeparator5,
            this.toolStripLabel7,
            this.toolStripSeparator6,
            this.toolStrip_quanlyphieumuon,
            this.toolStripSeparator7,
            this.toolStripLabel9});
            this.toolStripAdmin.Location = new System.Drawing.Point(0, 62);
            this.toolStripAdmin.Name = "toolStripAdmin";
            this.toolStripAdmin.Size = new System.Drawing.Size(800, 42);
            this.toolStripAdmin.TabIndex = 2;
            this.toolStripAdmin.Text = "toolStrip1";
            this.toolStripAdmin.Visible = false;
            // 
            // toolStrip_quanlythanhvien
            // 
            this.toolStrip_quanlythanhvien.Name = "toolStrip_quanlythanhvien";
            this.toolStrip_quanlythanhvien.Size = new System.Drawing.Size(123, 39);
            this.toolStrip_quanlythanhvien.Text = "Quản lý thành viên";
            this.toolStrip_quanlythanhvien.Click += new System.EventHandler(this.toolStrip_quanlythanhvien_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(84, 39);
            this.toolStripLabel7.Text = "Quản lý sách";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStrip_quanlyphieumuon
            // 
            this.toolStrip_quanlyphieumuon.Name = "toolStrip_quanlyphieumuon";
            this.toolStrip_quanlyphieumuon.Size = new System.Drawing.Size(131, 39);
            this.toolStrip_quanlyphieumuon.Text = "Quản lý phiếu mượn";
            this.toolStrip_quanlyphieumuon.Click += new System.EventHandler(this.toolStrip_quanlyphieumuon_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(113, 39);
            this.toolStripLabel9.Text = "Quản lý phiếu trả";
            // 
            // toolStripThongke
            // 
            this.toolStripThongke.AutoSize = false;
            this.toolStripThongke.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripThongke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel10,
            this.toolStripSeparator8,
            this.toolStripLabel11});
            this.toolStripThongke.Location = new System.Drawing.Point(0, 62);
            this.toolStripThongke.Name = "toolStripThongke";
            this.toolStripThongke.Size = new System.Drawing.Size(800, 42);
            this.toolStripThongke.TabIndex = 3;
            this.toolStripThongke.Text = "toolStrip1";
            this.toolStripThongke.Visible = false;
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(79, 39);
            this.toolStripLabel10.Text = "Đang mượn";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(45, 39);
            this.toolStripLabel11.Text = "Đã trả";
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.AllowMerge = false;
            this.menuStripHeader.AutoSize = false;
            this.menuStripHeader.BackColor = System.Drawing.Color.Black;
            this.menuStripHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconToolStripMenuItem,
            this.HeaderAdmin,
            this.HeaderThongke});
            this.menuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.Size = new System.Drawing.Size(800, 62);
            this.menuStripHeader.TabIndex = 0;
            this.menuStripHeader.Text = "menuStrip1";
            this.menuStripHeader.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripHeader_ItemClicked);
            // 
            // iconToolStripMenuItem
            // 
            this.iconToolStripMenuItem.AutoSize = false;
            this.iconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăToolStripMenuItem});
            this.iconToolStripMenuItem.Image = global::GUI.Properties.Resources.menubar;
            this.iconToolStripMenuItem.Name = "iconToolStripMenuItem";
            this.iconToolStripMenuItem.Size = new System.Drawing.Size(122, 58);
            // 
            // đăToolStripMenuItem
            // 
            this.đăToolStripMenuItem.Name = "đăToolStripMenuItem";
            this.đăToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăToolStripMenuItem.Text = "Đăng xuất";
            this.đăToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // HeaderAdmin
            // 
            this.HeaderAdmin.ForeColor = System.Drawing.Color.White;
            this.HeaderAdmin.Name = "HeaderAdmin";
            this.HeaderAdmin.Size = new System.Drawing.Size(66, 58);
            this.HeaderAdmin.Text = "Admin";
            this.HeaderAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // HeaderThongke
            // 
            this.HeaderThongke.ForeColor = System.Drawing.Color.White;
            this.HeaderThongke.Name = "HeaderThongke";
            this.HeaderThongke.Size = new System.Drawing.Size(87, 58);
            this.HeaderThongke.Text = "Thống kê";
            this.HeaderThongke.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // panel_Chucnang
            // 
            this.panel_Chucnang.AutoScroll = true;
            this.panel_Chucnang.AutoSize = true;
            this.panel_Chucnang.BackgroundImage = global::GUI.Properties.Resources.background;
            this.panel_Chucnang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Chucnang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Chucnang.Location = new System.Drawing.Point(0, 0);
            this.panel_Chucnang.Name = "panel_Chucnang";
            this.panel_Chucnang.Size = new System.Drawing.Size(800, 309);
            this.panel_Chucnang.TabIndex = 0;
            this.panel_Chucnang.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Chucnang_Paint);
            // 
            // GUI_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerHeader);
            this.MainMenuStrip = this.menuStripHeader;
            this.MaximizeBox = false;
            this.Name = "GUI_TrangChu";
            this.Text = "Quản Lý Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_TrangChu_Load);
            this.splitContainerHeader.Panel1.ResumeLayout(false);
            this.splitContainerHeader.Panel2.ResumeLayout(false);
            this.splitContainerHeader.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).EndInit();
            this.splitContainerHeader.ResumeLayout(false);
            this.toolStripAdmin.ResumeLayout(false);
            this.toolStripAdmin.PerformLayout();
            this.toolStripThongke.ResumeLayout(false);
            this.toolStripThongke.PerformLayout();
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerHeader;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem iconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HeaderAdmin;
        private System.Windows.Forms.ToolStripMenuItem HeaderThongke;
        private System.Windows.Forms.ToolStrip toolStripThongke;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStrip toolStripAdmin;
        private System.Windows.Forms.ToolStripLabel toolStrip_quanlythanhvien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStrip_quanlyphieumuon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Chucnang;
        private System.Windows.Forms.ToolStripMenuItem đăToolStripMenuItem;
    }
}


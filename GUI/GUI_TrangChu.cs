﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_TrangChu : Form
    {
        int quyenId;
        public GUI_TrangChu(int quyen)
        {
            InitializeComponent();
            quyenId = quyen;
        
        }
        BLL_Account bll_account = new BLL_Account();
        // Xử lý Form load
        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {
            if (quyenId == 3)
            {
                HeaderAdmin.Visible = false;
                HeaderThongke.Visible = false;
            }
            
        }
        // Đổi màu header khi click
        private void menuStripHeader_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStripHeader.Items)
            {
                item.ForeColor = Color.White;
            }

            if (e.ClickedItem is ToolStripMenuItem clickedItem)
            {
                clickedItem.ForeColor = Color.Gold;
                panel_Chucnang.Controls.Clear();
            }
        }
        // Ẩn toolstrip Admin và thống kê
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripAdmin.Visible = false;
            toolStripThongke.Visible = false;
            toolStripDashboard.Visible = true;
        }
        // Ẩn toolstrip Dashboard và thống kê
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripThongke.Visible = false;
            toolStripDashboard.Visible = false;
            toolStripAdmin.Visible = true;
        }
        // Ẩn toolstrip Admin và Dashboard
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDashboard.Visible = false;
            toolStripAdmin.Visible = false;
            toolStripThongke.Visible = true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new GUI_Sach();
            panel_Chucnang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Chucnang.Controls.Add(frm);

        }
        // Xử lý toolStrip Phiếu mượn khi được click
        private void toolStrip_quanlyphieumuon_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new GUI_PhieuMuon();
            panel_Chucnang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Chucnang.Controls.Add(frm);
        }

        private void đăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn đăng xuất !","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Hide();
                GUI_Login f = new GUI_Login();
                f.Show();
            }
        }
    }
}


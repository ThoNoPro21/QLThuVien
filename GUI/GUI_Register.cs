using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace GUI
{
    public partial class GUI_Register : Form
    {
        public GUI_Register()
        {
            InitializeComponent();
           
        }
        BLL_DocGia bll_docgia =new BLL_DocGia();
        
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string hoten = txt_Username.Text.Trim();
            string pass = txt_Password.Text.Trim();
            string pass_confirm=txt_NhapLaiMatKhau.Text.Trim();
            if (hoten == "" || pass == ""|| pass_confirm=="")
            {
                MessageBox.Show("Không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pass != pass_confirm)
            {
                MessageBox.Show("Mật khẩu không khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string passHash=bll_docgia.CalculateMD5Hash(pass);
            var IsCheck = bll_docgia.Register(hoten, passHash);
            if (IsCheck)
            {
                MessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GUI_Login f=new GUI_Login();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Login f = new GUI_Login();
            f.ShowDialog();
        }
    }
}

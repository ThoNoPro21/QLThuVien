using BLL;
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
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
            this.KeyPreview = false;

            // Đăng ký sự kiện KeyPress của Form
            this.KeyDown += GUI_Login_KeyDown;
        }

        BLL_Account bll_account = new BLL_Account();
       

        

        private void GUI_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click_1(sender, e);
            }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            string hoten = txt_Username.Text.Trim();
            string pass = txt_Password.Text.Trim();
            if(hoten==""||pass=="")
            {
                MessageBox.Show("Không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var passHash = bll_account.CalculateMD5Hash(pass);
            var IsCheck = bll_account.Loggin(hoten, passHash);
            if (IsCheck != null)
            {
                try
                {
                    DTO_DocGia.MaDocGia = IsCheck.MaDocGia;
                    this.Hide();
                    GUI_TrangChu frm_trangchu = new GUI_TrangChu(IsCheck.Quyen);
                    frm_trangchu.ShowDialog();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Register f=new GUI_Register();
            f.ShowDialog();
        }
    }
}

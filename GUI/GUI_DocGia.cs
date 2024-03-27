using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GUI_DocGia : UserControl
    {
        public GUI_DocGia()
        {
            InitializeComponent();
        }

        //kế thừa lại class BLL_DocGia bên tầng BLL
        BLL_DocGia bll_docgia = new BLL_DocGia();
        //biến để xác định đang thêm hay sửa
        // lưu == true là bấm Thêm xong bấm Lưu, 
        // lưu == false là bấm sửa xong bấm lưu
        private bool luu;
        private void GUI_DocGia_Load(object sender, EventArgs e)
        {
            //Hiển thị giới tính nam hoặc nữ lên combobox
            DanhSachGioiTinh();
            //Hiển thị danh sách độc giả
            HienThiDocGia();
            //Làm mờ các textbox, button
            boolcontrols(true);
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { "Nhân viên", "2" },
                { "Độc giả", "3" },
            // Thêm các cặp khác nếu cần
            };

            txtQuyen.DataSource = new BindingSource(keyValuePairs, null);
            txtQuyen.DisplayMember = "Key";
            txtQuyen.ValueMember = "Value";
            int quyen = bll_docgia.getDocGiaByMaDocGia(DTO_DocGia.MaDocGia);
            if (quyen != 1)
            {
                txtQuyen.Enabled=false;
                txtQuyen.SelectedValue = "3";
            }
            else
            {
                txtQuyen.Enabled = true;
            }
        }
        //Lấy danh sách độc giả
        private void HienThiDocGia()
        {
            gridview.DataSource = bll_docgia.LayTatCa(txtMaDocGiaSearch.Text, txtHoTenSearch.Text);
            //Định nghĩa tên các cột của datagridvie
            gridview.Columns[0].HeaderText = "Mã độc giả";
            gridview.Columns[1].HeaderText = "Họ tên";
            gridview.Columns[2].HeaderText = "Ngày sinh";
            gridview.Columns[3].HeaderText = "Giới tính";
            gridview.Columns[4].HeaderText = "Địa chỉ";
            //Nếu datagridview không có dòng dữ liệu nào thì các textbox sẽ trắng
            if (gridview.Rows.Count == 0)
            {
                txtMaDocGia.Text = "";
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
            }
            //nếu datagridview có dữ liệu thì sẽ hiển thị dữ liệu của dòng đầu tiên lên các ô textbox
            else
            {
                var row = this.gridview.Rows[0];
                txtMaDocGia.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.Text = row.Cells[2].Value?.ToString();
                cboGioiTinh.Text = row.Cells[3].Value?.ToString();
                txtDiaChi.Text = row.Cells[4].Value?.ToString();

            }
        }
        //Lấy danh sách giới tính nam hoặc nữ lên combobox
        private void DanhSachGioiTinh()
        {
            DataTable dataTable = new DataTable();
            cboGioiTinh.Items.Clear();
            dataTable.Columns.Add("GioiTinh", typeof(string));
            dataTable.Columns.Add("TenGioiTinh", typeof(string));
            dataTable.Rows.Add("Nam", "Nam");
            dataTable.Rows.Add("Nữ", "Nữ");
            cboGioiTinh.DataSource = dataTable;
            cboGioiTinh.DisplayMember = "TenGioiTinh";
            cboGioiTinh.ValueMember = "GioiTinh";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //bấm thêm sẽ làm trắng các textbox
            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            boolcontrols(false);
            //lưu == true là bấm Thêm xong bấm Lưu
            luu = true;
            //trỏ chuột vào ô họ tên
            txtHoTen.Focus();
        }
        //làm mờ các button và textbox
        private void boolcontrols(bool iss)
        {
            btnThem.Enabled = iss;
            btnSua.Enabled = iss;
            btnXoa.Enabled = iss;
            btnLuu.Enabled = !iss;
            btnHuy.Enabled = !iss;
            btnLamMoi.Enabled = iss;
            btnThoat.Enabled = iss;
            btnTim.Enabled = iss;
            txtHoTen.Enabled = !iss;
            txtDiaChi.Enabled = !iss;
            dtNgaySinh.Enabled = !iss;
            cboGioiTinh.Enabled = !iss;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //nếu datagriview ko có dòng dữ liệu nào thì không cho sửa
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            // lưu == false là bấm Sửa xong bấm Lưu
            luu = false;
            boolcontrols(false);
            txtMaDocGia.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //nếu datagriview ko có dòng dữ liệu nào thì không cho xóa
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            //hỏi có xóa hay không
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa độc giả này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) //yes là có
            {
                //lấy mã độc giả của dòng đang chọn vào
                string Madg = gridview.Rows[gridview.CurrentCell.RowIndex].Cells[0].Value.ToString();
                //tiến hành xóa
                var result = bll_docgia.DeleteDocGia(int.Parse(Madg));
                if (result) //xóa thành công
                {
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDocGia();
                    boolcontrols(true);
                }
                else //xóa thất bại
                {
                    MessageBox.Show("Không thể xóa do mã độc giả này đã phát sinh dữ liệu ở table khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên độc giả không được trống hoặc khoảng trắng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống hoặc khoảng trắng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }
            //lưu == true tức là Thêm
            if (luu == true)
            {
                //tiến hành thêm
                bool result = bll_docgia.InsertDocGia(txtHoTen.Text.Trim(), dtNgaySinh.Value, cboGioiTinh.Text.Trim(), txtDiaChi.Text.Trim(),bll_docgia.CalculateMD5Hash(txtMatKhau.Text),Convert.ToInt32(txtQuyen.SelectedValue.ToString()));
                if (result) //thêm thành công
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDocGia();
                    boolcontrols(true);
                }
                else //thất bại
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else //else lúc này tức là Sửa
            {
                //tiến hành sửa
                bool result = bll_docgia.UpdateDocGia(int.Parse(txtMaDocGia.Text), txtHoTen.Text.Trim(), dtNgaySinh.Value, cboGioiTinh.Text, txtDiaChi.Text.Trim(), bll_docgia.CalculateMD5Hash(txtMatKhau.Text), Convert.ToInt32( txtQuyen.SelectedValue.ToString()));
                if (result) //sửa thành công
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDocGia();
                    boolcontrols(true);
                }
                else //sửa thất bại
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //trở về ban đầu
            HienThiDocGia();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //trở về ban đầu
            txtMaDocGiaSearch.Text = "";
            txtHoTenSearch.Text = "";
            HienThiDocGia();
            boolcontrols(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //đóng chương trình
            this.Hide();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //tìm kiếm
            HienThiDocGia();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi bấm vào các dòng của datagridview sẽ hiện dữ liệu của dòng đó lên textbox
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaDocGia.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.Text = row.Cells[2].Value?.ToString();
                cboGioiTinh.Text = row.Cells[3].Value?.ToString();
                txtDiaChi.Text = row.Cells[4].Value?.ToString();
                txtMatKhau.Text = bll_docgia.CalculateMD5Hash(row.Cells[6].Value?.ToString());   
            }
        }

        private void txtQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
             txtQuyen.SelectedValue.ToString();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
   

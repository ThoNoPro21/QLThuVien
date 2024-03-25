using BLL;
using DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class GUI_PhieuMuon : UserControl
    {
        public GUI_PhieuMuon()
        {
            InitializeComponent();
        }
        BLL_PhieuMuon bll_phieumuon = new BLL_PhieuMuon();
        BLL_DocGia bll_docgia = new BLL_DocGia();
        BLL_QLSach bll_sach = new BLL_QLSach();
        private void GUI_PhieuMuon_Load(object sender, EventArgs e)
        {
            dgv_PhieuMuon.DataSource = bll_phieumuon.LayTatCa();
        }

        private void datePicker_ngaymuon_ValueChanged(object sender, EventArgs e)
        {
            datePicker_ngaymuon.Format = DateTimePickerFormat.Custom;
            datePicker_ngaymuon.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        public void ResetTextBox()
        {
            txt_madocgia.Clear();
            txt_masach.Clear();
            txt_maphieumuon.Clear();
            datePicker_ngaymuon.ResetText();
            datePicker_ngaytra.ResetText();
            txt_TimKiem.Clear();    
        }
        // Thêm phiếu mượn
        int maphieumuon=-1;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_madocgia.Text.Trim() == "" || txt_masach.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txt_maphieumuon.Text == "")
            {
                Random rand = new Random();
                string randomNumberString =
                rand.Next(1, 10).ToString() +
                rand.Next(1, 10).ToString() +
                rand.Next(1, 10).ToString() +
                rand.Next(1, 10).ToString();
                maphieumuon = Convert.ToInt32(randomNumberString);
            }
                       
            bool ischeckMaPhieu = bll_phieumuon.IsCheckMaPhieuMuon(maphieumuon);
            if (ischeckMaPhieu)
            {
                MessageBox.Show("Mã phiếu đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int madocgia;
            if (int.TryParse(txt_madocgia.Text.Trim(), out int madocgiaNew))
            {
                madocgia = madocgiaNew;
                var ischeckMaDocGia = bll_docgia.IsCheckMaDocGia(madocgia);
                if (!ischeckMaDocGia)
                {
                    MessageBox.Show("Không tồn tại độc giả !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                txt_madocgia.Focus();
                MessageBox.Show("Mã độc giả phải là 1 số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int masach;
            if (int.TryParse(txt_masach.Text.Trim(), out int masachNew))
            {
                masach = masachNew;
                var ischeckMaSach = bll_sach.IsCheckMaSach(masach);
                if (!ischeckMaSach)
                {
                    MessageBox.Show("Không tồn tại sách đó!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                txt_masach.Focus();
                MessageBox.Show("Mã sách phải là 1 số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime now = DateTime.Now;
            DateTime ngaymuon = datePicker_ngaymuon.Value;
            if (ngaymuon > now)
            {
                MessageBox.Show("Lỗi thời gian mượn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker_ngaymuon.Focus();
                return;
            }

            DateTime ngayphaitra = datePicker_ngaytra.Value;
            if (ngayphaitra < ngaymuon)
            {
                MessageBox.Show("Lỗi thời gian phải trả !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker_ngaymuon.Focus();
                return;
            }
            int nguoitao = DTO_DocGia.MaDocGia;
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm phiếu mượn " , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool result=bll_phieumuon.InsertPhieuMuon(maphieumuon, madocgia, masach, ngaymuon, ngayphaitra, nguoitao);
                    if (result)
                    {
                        bll_phieumuon.GiamSoLuong(masach);
                        MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Sách đã hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            dgv_PhieuMuon.DataSource = bll_phieumuon.LayTatCa();
        }
        // Click vào dataGridView
        private DataGridViewRow previousSelectedRow;
        int MaPhieu;
        private void dgv_PhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem dòng trước đó có tồn tại và khác với dòng được chọn hiện tại không
                if (previousSelectedRow != null && previousSelectedRow.Index != e.RowIndex)
                {
                    // Khôi phục màu sắc mặc định của dòng trước đó
                    previousSelectedRow.DefaultCellStyle.BackColor = dgv_PhieuMuon.DefaultCellStyle.BackColor;
                    previousSelectedRow.DefaultCellStyle.ForeColor = dgv_PhieuMuon.DefaultCellStyle.ForeColor;
                }

                // Lấy dòng được chọn hiện tại
                DataGridViewRow selectedRow = dgv_PhieuMuon.Rows[e.RowIndex];

                // Lưu trữ dòng trước đó
                previousSelectedRow = selectedRow;
                // Tô đậm dòng được chọn hiện tại
                selectedRow.DefaultCellStyle.BackColor = Color.Yellow;
                selectedRow.DefaultCellStyle.ForeColor = Color.Black;

                MaPhieu = (int)selectedRow.Cells["MaPhieuMuon"].Value;
                PHIEUMUON phieumuon = bll_phieumuon.TimPhieuMuon(MaPhieu);
                txt_maphieumuon.Text = phieumuon.MaPhieuMuon.ToString();
                maphieumuon = phieumuon.MaPhieuMuon;
                txt_madocgia.Text=phieumuon.MaDocGia.ToString();
                txt_masach.Text=phieumuon.MaSach.ToString();
                datePicker_ngaymuon.Value = phieumuon.NgayMuon;
                datePicker_ngaytra.Value = phieumuon.NgayPhaiTra.Value;
            }
            catch { }   
        }
        // Xóa Phiếu mượn
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MaPhieu >0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa mã phiếu " + MaPhieu, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var result = bll_phieumuon.DeletePhieuMuon(MaPhieu);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                        dgv_PhieuMuon.DataSource = bll_phieumuon.LayTatCa();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Format Trạng Thái
        private void dgv_PhieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_PhieuMuon.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null && e.Value.ToString() == "1")
                {
                    e.Value = "Đã trả";
                    e.FormattingApplied = true;
                    e.CellStyle.ForeColor = Color.Blue;
                }
                else
                {
                    e.Value = "Chưa trả";
                    e.FormattingApplied = true;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_maphieumuon.Text == "")
            {
                MessageBox.Show("Phiếu chưa được tạo !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_madocgia.Text.Trim() == "" || txt_masach.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int madocgia;
            if (int.TryParse(txt_madocgia.Text.Trim(), out int madocgiaNew))
            {
                madocgia = madocgiaNew;
                var ischeckMaDocGia = bll_docgia.IsCheckMaDocGia(madocgia);
                if (!ischeckMaDocGia)
                {
                    MessageBox.Show("Không tồn tại độc giả !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                txt_madocgia.Focus();
                MessageBox.Show("Mã độc giả phải là 1 số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int masach;
            if (int.TryParse(txt_masach.Text.Trim(), out int masachNew))
            {
                masach = masachNew;
                var ischeckMaSach = bll_sach.IsCheckMaSach(masach);
                if (!ischeckMaSach)
                {
                    MessageBox.Show("Không tồn tại sách đó!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                txt_masach.Focus();
                MessageBox.Show("Mã sách phải là 1 số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime now = DateTime.Now;
            DateTime ngaymuon = datePicker_ngaymuon.Value;
            if (ngaymuon > now)
            {
                MessageBox.Show("Lỗi thời gian mượn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker_ngaymuon.Focus();
                return;
            }

            DateTime ngayphaitra = datePicker_ngaytra.Value;
            if (ngayphaitra < ngaymuon)
            {
                MessageBox.Show("Lỗi thời gian phải trả !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker_ngaymuon.Focus();
                return;
            }
            int nguoitao = DTO_DocGia.MaDocGia;
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa phiếu mượn ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var result = bll_phieumuon.CheckMaSachCoThayDoiKhong(masach,maphieumuon);
                    if (result)
                    {
                        bll_phieumuon.UpdatePhieuMuon(maphieumuon, madocgia, masach, ngaymuon, ngayphaitra, nguoitao);
                        MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                    }
                    else
                    {
                        bool count = bll_phieumuon.CheckSoLuong(masach);
                        if (count)
                        {
                            MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bll_phieumuon.UpdatePhieuMuon(maphieumuon, madocgia, masach, ngaymuon, ngayphaitra, nguoitao);
                            bll_phieumuon.GiamSoLuong(masach);
                            ResetTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Hết sách đó rồi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            dgv_PhieuMuon.DataSource = bll_phieumuon.LayTatCa();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            dgv_PhieuMuon.DataSource=bll_phieumuon.LayTatCa();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int timkiemMaPhieu;
            if(int.TryParse(txt_TimKiem.Text.Trim(), out int timkiemMaPhieuNew))
            {
                timkiemMaPhieu = timkiemMaPhieuNew;
            }
            else
            {
                MessageBox.Show("Mã độc giả phải là 1 số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                dgv_PhieuMuon.DataSource = bll_phieumuon.TimKiemPhieuMuon(timkiemMaPhieu);
            }
            catch { }

        }

        private void txt_madocgia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

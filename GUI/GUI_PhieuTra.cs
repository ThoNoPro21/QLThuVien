using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_PhieuTra : UserControl
    {
        public GUI_PhieuTra()
        {
            InitializeComponent();
        }

        private bool save = true;
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        BLL_PhieuTra bll_pt = new BLL_PhieuTra();
        BLL_PhieuMuon bll_pm = new BLL_PhieuMuon();

        private void GUI_PhieuTra_Load(object sender, EventArgs e)
        {
            HienThiPhieuTra();
            EnabledControls(true);
        }
        private void HienThiPhieuTra()
        {
            ComboboxDanhSachPhieuMuon();
            gridview.DataSource = bll_pt.LayTatCa(txtMaPhieuTraSearch.Text);
            //Định nghĩa tên các cột của datagridvie
            gridview.Columns[0].HeaderText = "Mã phiếu mượn";
            gridview.Columns[1].HeaderText = "Mã phiếu trả";
            gridview.Columns[2].HeaderText = "Ngày mượn";
            gridview.Columns[3].HeaderText = "Ngày phải trả";
            gridview.Columns[4].HeaderText = "Ngày trả";
            gridview.Columns[5].HeaderText = "Sách mượn";
            gridview.Columns[6].HeaderText = "Người tạo";

            if (gridview.Rows.Count == 0)
            {
                txtNguoiTao.Text = GUI_Login.nameLogin;
                txtMaPhieuTra.Text = "";
            }

            else
            {
                var row = this.gridview.Rows[0];
                txtMaPhieuTra.Text = row.Cells[1].Value.ToString();
                cboMaPhieuMuon.Text = row.Cells[0].Value.ToString();
                dtNgayTra.Text = row.Cells[4].Value.ToString();
                txtNguoiTao.Text = row.Cells[6].Value.ToString();
            }
        }
        private void EnabledControls(bool iss)
        {
            btnThem.Enabled = iss;
            btnSua.Enabled = iss;
            btnXoa.Enabled = iss;
            btnLuu.Enabled = !iss;
            btnHuy.Enabled = !iss;
            btnTim.Enabled = iss;
            cboMaPhieuMuon.Enabled = !iss;
            dtNgayTra.Enabled = !iss;
        }
        private void ComboboxDanhSachPhieuMuon()
        {
            DataTable dataTable = new DataTable();
            dataTable = ToDataTable(bll_pt.LayThongTinPhieuMuon());
            cboMaPhieuMuon.DataSource = dataTable;
            cboMaPhieuMuon.DisplayMember = "MaPhieuMuon";
            cboMaPhieuMuon.ValueMember = "MaPhieuMuon";
        }
        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaPhieuTra.Text = row.Cells[1].Value.ToString();
                cboMaPhieuMuon.Text = row.Cells[0].Value.ToString();
                dtNgayTra.Text = row.Cells[4].Value.ToString();
                txtNguoiTao.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtNguoiTao.Text = "";
            EnabledControls(false);
            save = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            save = false;
            EnabledControls(false);
            txtMaPhieuTra.Enabled = false;
            cboMaPhieuMuon.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa phiếu trả này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) //yes là có
            {
                string Mapt = gridview.Rows[gridview.CurrentCell.RowIndex].Cells[1].Value.ToString();
                var result = bll_pt.DeletePHIEUTRA(int.Parse(Mapt));
                if (result)
                {
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhieuTra();
                    EnabledControls(true);
                }
                else //xóa thất bại
                {
                    MessageBox.Show("Không thể xóa do đã phát sinh dữ liệu khóa ngoại ở table khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhieuTraSearch.Text = "";
            HienThiPhieuTra();
            EnabledControls(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiPhieuTra();
            EnabledControls(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaPhieuMuon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có phiếu mượn để lập phiếu trả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaPhieuMuon.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = ToDataTable(bll_pt.GetNgayMuon(int.Parse(cboMaPhieuMuon.Text)));

            if (dtNgayTra.Value < DateTime.Parse(dt.Rows[0][3].ToString()))
            {
                MessageBox.Show("Ngày trả phải lớn hơn hoặc bằng ngày mượn, ngày mượn là "+ dt.Rows[0][3].ToString() + "", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtNgayTra.Focus();
                return;
            }
                

            if (save == true)
            {
                bool result = bll_pt.InsertPHIEUTRA(int.Parse(cboMaPhieuMuon.Text), dtNgayTra.Value, GUI_Login.useLogin);
                if (result) //thêm thành công
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhieuTra();
                    EnabledControls(true);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                bool result = bll_pt.UpdatePHIEUTRA(int.Parse(txtMaPhieuTra.Text), dtNgayTra.Value, GUI_Login.useLogin);
                if (result) //sửa thành công
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhieuTra();
                    EnabledControls(true);
                }
                else //sửa thất bại
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}

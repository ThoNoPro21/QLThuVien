using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BLL;

namespace GUI
{
    public partial class GUI_QLSach : UserControl
    {
        BLL_QLSach bllSach = new BLL_QLSach();

        public GUI_QLSach()
        {
           
            InitializeComponent();
            LoadDataSach();
            LoadTheLoaiComboBox();
            LoadTenTheLoai();
            LoadTenTacGia();
            LoadTenNhaXuatBan();
            Load_List_Sach.SelectionChanged += new EventHandler(this.Load_List_Sach_SelectionChanged);
            RefreshBooksGridView();
            
        }

        private void LoadDataSach()
        {
            Load_List_Sach.DataSource = bllSach.GetAllSach();
            Load_List_Sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load_List_Sach.ScrollBars = ScrollBars.Vertical;
            Load_List_Sach.Refresh();
        }
        private void LoadTenTheLoai()
        {
            try
            {
                comboBoxTheLoaiSach.DataSource = bllSach.GetTenTheLoai();
                updatecomboBoxTheLoaiSach.DataSource = bllSach.GetTenTheLoai();
                comboBoxTheLoaiSach.DisplayMember = "TenTheLoai";
                updatecomboBoxTheLoaiSach.DisplayMember = "TenTheLoai";
                ClearLoadTenTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void ClearLoadTenTheLoai()
        {
            comboBoxTheLoaiSach.SelectedIndex = -1;
            updatecomboBoxTheLoaiSach.SelectedIndex = -1;
        }

        private void LoadTenTacGia()
        {
            try
            {
                comboBoxTacGia.DataSource = bllSach.GetTenTacGia();
                comboBoxTacGia.DisplayMember = "TenTacGia";
                updatecomboBoxTacGia.DataSource = bllSach.GetTenTacGia();
                updatecomboBoxTacGia.DisplayMember = "TenTacGia";
                ClearLoadTenTacGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearLoadTenTacGia()
        {
            comboBoxTacGia.SelectedIndex = -1;
            updatecomboBoxTacGia.SelectedIndex = -1;
        }

        private void LoadTenNhaXuatBan()
        {
            try
            {

                comboBoxNhaXuatBan.DataSource = bllSach.GetTenNXB();
                comboBoxNhaXuatBan.DisplayMember = "TenNXB";
                updatecomboBoxNhaXuatBan.DataSource = bllSach.GetTenNXB();
                updatecomboBoxNhaXuatBan.DisplayMember = "TenNXB";
                ClearLoadTenNhaXuatBan();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ClearLoadTenNhaXuatBan()
        {
            comboBoxNhaXuatBan.SelectedIndex = -1;
            updatecomboBoxNhaXuatBan.SelectedIndex = -1;
        }
        private void PerformSearch(string searchString)
        {
            Load_List_Sach.DataSource = bllSach.SearchSach(searchString);
        }

        private void btn_Search_Sach_Click(object sender, EventArgs e)
        {
            string searchString = searchBookText.Text;
            PerformSearch(searchString);
        }

        private void List_Books_Click(object sender, EventArgs e)
        {
            Load_List_Sach.DataSource = bllSach.GetAllSach();
        }

        private void LoadTheLoaiComboBox()
        {
            var theLoaiList = bllSach.GetTheLoai();
            ComboBoxTheLoai.DisplayMember = "TenTheLoai";
            ComboBoxTheLoai.ValueMember = "ID";
            ComboBoxTheLoai.DataSource = theLoaiList;
            ClearLoadTheLoaiComboBox();
            ClearSearchBox();
        }

        private void ClearLoadTheLoaiComboBox()
        {
            ComboBoxTheLoai.SelectedIndex = - 1;
        }
        private void ClearSearchBox()
        {
            searchBookText.Text = string.Empty;
        }
        private void ComboBoxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTheLoai.SelectedIndex >= 0)
            {
                string selectedTheLoaiName = ComboBoxTheLoai.Text;
                LoadSachData(selectedTheLoaiName);
            }
        }
        private void LoadSachData(string theLoaiName)
        {
            Load_List_Sach.DataSource = bllSach.GetSachByTheLoaiName(theLoaiName);
        }



        private void btn_addBook_Click(object sender, EventArgs e)
        {
            string tenSach = textTenSach.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenSach))
            {
                MessageBox.Show("Tên sách không được để trống vui lòng nhập lại");
                return;
            }
            string giaSachStr = textGiaSach.Text.Trim();
            decimal giaSach;
            if (!decimal.TryParse(giaSachStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out giaSach))
            {
                MessageBox.Show("Giá sách phải là một số hợp lệ. Vui lòng nhập lại.");
                return;
            }
            int soLuong;
            if (!int.TryParse(textSoLuong.Text.Trim(), out soLuong))
            {
                MessageBox.Show("Số lượng phải là số nguyên. Vui lòng nhập lại");
                return;
            }
            string theLoaiName = comboBoxTheLoaiSach.Text.Trim();
            if (string.IsNullOrWhiteSpace(theLoaiName))
            {
                MessageBox.Show("Thể loại sách không được để tróng");
                return;
            }
            int theLoaiID = bllSach.AddTheLoai(theLoaiName);
            string tacGiaName = comboBoxTacGia.Text.Trim();
            if (string.IsNullOrWhiteSpace(tacGiaName))
            {
                MessageBox.Show("Tác giả không được để trống");
                return;
            }
            int tacGiaID = bllSach.AddTacGia(tacGiaName);
            string nhaXuatBanName = comboBoxNhaXuatBan.Text.Trim();
            if (string.IsNullOrWhiteSpace(nhaXuatBanName))
            {
                MessageBox.Show("Nhà xuất bản không được để trống");
                return;
            }
            int nhaXuatBanID = bllSach.AddNhaXuatBan(nhaXuatBanName);

            bool addedSuccessfully = bllSach.AddNewSach(tenSach, giaSachStr, soLuong, theLoaiID, tacGiaID, nhaXuatBanID);

            if (addedSuccessfully)
            {
                MessageBox.Show("Sách đã được thêm thành công!");
                RefreshBooksGridView();
                LoadTheLoaiComboBox();
                LoadTenTheLoai();
                LoadTenTacGia();
                LoadTenNhaXuatBan();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Sách với tên đã nhập đã tồn tại.");
            }

        }
        private int selectedMaSach = -1;

        private void Load_List_Sach_SelectionChanged(object sender, EventArgs e)
        {
            if (Load_List_Sach.SelectedRows.Count > 0)
            {
                var row = Load_List_Sach.SelectedRows[0];
                selectedMaSach = Convert.ToInt32(row.Cells["MaSach"].Value);

                updatetextTenSach.Text = row.Cells["TenSach"].Value.ToString();
                updadetextGiaSach.Text = row.Cells["GiaSach"].Value.ToString();
                updatetextSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                updatecomboBoxTheLoaiSach.Text = row.Cells["TheLoai"].Value.ToString();
                updatecomboBoxTacGia.Text = row.Cells["TacGia"].Value.ToString();
                updatecomboBoxNhaXuatBan.Text = row.Cells["NhaXuatBan"].Value.ToString();
            }
        }

        private void btn_SuaSach_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSach = updatetextTenSach.Text.Trim();
                if (string.IsNullOrWhiteSpace(tenSach))
                {
                    MessageBox.Show("Tên sách không được để trống vui lòng nhập lại");
                    return;
                }
                string giaSachStr = updadetextGiaSach.Text.Trim();
                decimal giaSach;
                if (!decimal.TryParse(giaSachStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out giaSach))
                {
                    MessageBox.Show("Giá sách phải là một số hợp lệ. Vui lòng nhập lại.");
                    return;
                }
                int soLuong;
                if (!int.TryParse(updatetextSoLuong.Text.Trim(), out soLuong))
                {
                    MessageBox.Show("Số lượng phải là số nguyên.");
                    return;
                }


                int theLoaiID = bllSach.AddTheLoai(updatecomboBoxTheLoaiSach.Text.Trim());
                int tacGiaID = bllSach.AddTacGia(updatecomboBoxTacGia.Text.Trim());
                int nhaXuatBanID = bllSach.AddNhaXuatBan(updatecomboBoxNhaXuatBan.Text.Trim());

                bool updateSuccessful = bllSach.UpdateSach(selectedMaSach, tenSach, giaSachStr, soLuong, theLoaiID, tacGiaID, nhaXuatBanID);
                if (updateSuccessful)
                {
                    MessageBox.Show("Sách đã được cập nhật thành công!");
                    RefreshBooksGridView();
                    LoadTheLoaiComboBox();
                    LoadTenTheLoai();
                    LoadTenTacGia();
                    LoadTenNhaXuatBan();
                    updateClearFormFields();
                }
                else
                {
                    MessageBox.Show("Tên sách đã tồn tại. Vui lòng chọn tên khác.");
                }
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá sách này không?", "Xác nhận xoá", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (selectedMaSach > 0)
                    {
                        bllSach.DeleteSach(selectedMaSach);
                        MessageBox.Show("Sách đã được xoá thành công!");
                        RefreshBooksGridView();
                        updateClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn sách để xoá.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá sách: " + ex.Message);
                }
            }
        }
        private void ClearFormFields()
        {
            textTenSach.Text = string.Empty;
            textGiaSach.Text = string.Empty;
            textSoLuong.Text = string.Empty;

            comboBoxTheLoaiSach.SelectedIndex = -1;
            comboBoxTacGia.SelectedIndex = -1;
            comboBoxNhaXuatBan.SelectedIndex = -1;
        }

        private void updateClearFormFields()
        {
            updatetextTenSach.Text = string.Empty;
            updadetextGiaSach.Text = string.Empty;
            updatetextSoLuong.Text = string.Empty;

            updatecomboBoxTheLoaiSach.SelectedIndex = -1;
            updatecomboBoxTacGia.SelectedIndex = -1;
            updatecomboBoxNhaXuatBan.SelectedIndex = -1;
        }
        private void RefreshBooksGridView()
        {
            Load_List_Sach.DataSource = bllSach.GetAllSach();
            Load_List_Sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load_List_Sach.ScrollBars = ScrollBars.Vertical;
            Load_List_Sach.Refresh();
        }

    }
}

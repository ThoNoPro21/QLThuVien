
namespace GUI
{
    partial class GUI_QLSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Load_List_Sach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search_Sach = new System.Windows.Forms.Button();
            this.searchBookText = new System.Windows.Forms.TextBox();
            this.List_Books = new System.Windows.Forms.Button();
            this.ComboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.comboBoxTacGia = new System.Windows.Forms.ComboBox();
            this.comboBoxTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.textGiaSach = new System.Windows.Forms.TextBox();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.textTenSach = new System.Windows.Forms.TextBox();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_XoaSach = new System.Windows.Forms.Button();
            this.btn_SuaSach = new System.Windows.Forms.Button();
            this.updatecomboBoxNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.updatecomboBoxTacGia = new System.Windows.Forms.ComboBox();
            this.updatecomboBoxTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.updatetextSoLuong = new System.Windows.Forms.TextBox();
            this.updadetextGiaSach = new System.Windows.Forms.TextBox();
            this.updatetextTenSach = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Load_List_Sach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_List_Sach
            // 
            this.Load_List_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Load_List_Sach.Location = new System.Drawing.Point(300, 278);
            this.Load_List_Sach.Margin = new System.Windows.Forms.Padding(2);
            this.Load_List_Sach.Name = "Load_List_Sach";
            this.Load_List_Sach.RowHeadersWidth = 51;
            this.Load_List_Sach.RowTemplate.Height = 24;
            this.Load_List_Sach.Size = new System.Drawing.Size(835, 226);
            this.Load_List_Sach.TabIndex = 0;
            this.Load_List_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Load_List_Sach_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Search_Sach);
            this.groupBox1.Controls.Add(this.searchBookText);
            this.groupBox1.Location = new System.Drawing.Point(300, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(370, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên sách";
            // 
            // btn_Search_Sach
            // 
            this.btn_Search_Sach.Location = new System.Drawing.Point(285, 29);
            this.btn_Search_Sach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search_Sach.Name = "btn_Search_Sach";
            this.btn_Search_Sach.Size = new System.Drawing.Size(56, 19);
            this.btn_Search_Sach.TabIndex = 1;
            this.btn_Search_Sach.Text = "Tìm kiếm";
            this.btn_Search_Sach.UseVisualStyleBackColor = true;
            this.btn_Search_Sach.Click += new System.EventHandler(this.btn_Search_Sach_Click);
            // 
            // searchBookText
            // 
            this.searchBookText.Location = new System.Drawing.Point(88, 29);
            this.searchBookText.Margin = new System.Windows.Forms.Padding(2);
            this.searchBookText.Name = "searchBookText";
            this.searchBookText.Size = new System.Drawing.Size(174, 20);
            this.searchBookText.TabIndex = 0;
            // 
            // List_Books
            // 
            this.List_Books.Location = new System.Drawing.Point(1038, 250);
            this.List_Books.Margin = new System.Windows.Forms.Padding(2);
            this.List_Books.Name = "List_Books";
            this.List_Books.Size = new System.Drawing.Size(97, 20);
            this.List_Books.TabIndex = 3;
            this.List_Books.Text = "Tất cả sách";
            this.List_Books.UseVisualStyleBackColor = true;
            this.List_Books.Click += new System.EventHandler(this.List_Books_Click);
            // 
            // ComboBoxTheLoai
            // 
            this.ComboBoxTheLoai.FormattingEnabled = true;
            this.ComboBoxTheLoai.Location = new System.Drawing.Point(914, 249);
            this.ComboBoxTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTheLoai.Name = "ComboBoxTheLoai";
            this.ComboBoxTheLoai.Size = new System.Drawing.Size(104, 21);
            this.ComboBoxTheLoai.TabIndex = 4;
            this.ComboBoxTheLoai.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTheLoai_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxNhaXuatBan);
            this.groupBox2.Controls.Add(this.comboBoxTacGia);
            this.groupBox2.Controls.Add(this.comboBoxTheLoaiSach);
            this.groupBox2.Controls.Add(this.textGiaSach);
            this.groupBox2.Controls.Add(this.textSoLuong);
            this.groupBox2.Controls.Add(this.textTenSach);
            this.groupBox2.Controls.Add(this.btn_addBook);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 312);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sách";
            // 
            // comboBoxNhaXuatBan
            // 
            this.comboBoxNhaXuatBan.FormattingEnabled = true;
            this.comboBoxNhaXuatBan.Location = new System.Drawing.Point(112, 204);
            this.comboBoxNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNhaXuatBan.Name = "comboBoxNhaXuatBan";
            this.comboBoxNhaXuatBan.Size = new System.Drawing.Size(103, 21);
            this.comboBoxNhaXuatBan.TabIndex = 14;
            // 
            // comboBoxTacGia
            // 
            this.comboBoxTacGia.FormattingEnabled = true;
            this.comboBoxTacGia.Location = new System.Drawing.Point(112, 163);
            this.comboBoxTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTacGia.Name = "comboBoxTacGia";
            this.comboBoxTacGia.Size = new System.Drawing.Size(103, 21);
            this.comboBoxTacGia.TabIndex = 13;
            // 
            // comboBoxTheLoaiSach
            // 
            this.comboBoxTheLoaiSach.FormattingEnabled = true;
            this.comboBoxTheLoaiSach.Location = new System.Drawing.Point(112, 126);
            this.comboBoxTheLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTheLoaiSach.Name = "comboBoxTheLoaiSach";
            this.comboBoxTheLoaiSach.Size = new System.Drawing.Size(103, 21);
            this.comboBoxTheLoaiSach.TabIndex = 12;
            // 
            // textGiaSach
            // 
            this.textGiaSach.Location = new System.Drawing.Point(112, 53);
            this.textGiaSach.Margin = new System.Windows.Forms.Padding(2);
            this.textGiaSach.Name = "textGiaSach";
            this.textGiaSach.Size = new System.Drawing.Size(103, 20);
            this.textGiaSach.TabIndex = 10;
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(112, 89);
            this.textSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(103, 20);
            this.textSoLuong.TabIndex = 9;
            // 
            // textTenSach
            // 
            this.textTenSach.Location = new System.Drawing.Point(112, 25);
            this.textTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.textTenSach.Name = "textTenSach";
            this.textTenSach.Size = new System.Drawing.Size(103, 20);
            this.textTenSach.TabIndex = 8;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(91, 273);
            this.btn_addBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(76, 34);
            this.btn_addBook.TabIndex = 7;
            this.btn_addBook.Text = "Thêm sách";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nhà xuất bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_XoaSach);
            this.groupBox3.Controls.Add(this.btn_SuaSach);
            this.groupBox3.Controls.Add(this.updatecomboBoxNhaXuatBan);
            this.groupBox3.Controls.Add(this.updatecomboBoxTacGia);
            this.groupBox3.Controls.Add(this.updatecomboBoxTheLoaiSach);
            this.groupBox3.Controls.Add(this.updatetextSoLuong);
            this.groupBox3.Controls.Add(this.updadetextGiaSach);
            this.groupBox3.Controls.Add(this.updatetextTenSach);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1172, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(232, 312);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa và xoá sách";
            // 
            // btn_XoaSach
            // 
            this.btn_XoaSach.Location = new System.Drawing.Point(149, 273);
            this.btn_XoaSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaSach.Name = "btn_XoaSach";
            this.btn_XoaSach.Size = new System.Drawing.Size(79, 34);
            this.btn_XoaSach.TabIndex = 23;
            this.btn_XoaSach.Text = "Xoá sách";
            this.btn_XoaSach.UseVisualStyleBackColor = true;
            this.btn_XoaSach.Click += new System.EventHandler(this.btn_XoaSach_Click);
            // 
            // btn_SuaSach
            // 
            this.btn_SuaSach.Location = new System.Drawing.Point(13, 273);
            this.btn_SuaSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaSach.Name = "btn_SuaSach";
            this.btn_SuaSach.Size = new System.Drawing.Size(76, 34);
            this.btn_SuaSach.TabIndex = 22;
            this.btn_SuaSach.Text = "Sửa sách";
            this.btn_SuaSach.UseVisualStyleBackColor = true;
            this.btn_SuaSach.Click += new System.EventHandler(this.btn_SuaSach_Click);
            // 
            // updatecomboBoxNhaXuatBan
            // 
            this.updatecomboBoxNhaXuatBan.FormattingEnabled = true;
            this.updatecomboBoxNhaXuatBan.Location = new System.Drawing.Point(104, 204);
            this.updatecomboBoxNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.updatecomboBoxNhaXuatBan.Name = "updatecomboBoxNhaXuatBan";
            this.updatecomboBoxNhaXuatBan.Size = new System.Drawing.Size(103, 21);
            this.updatecomboBoxNhaXuatBan.TabIndex = 21;
            // 
            // updatecomboBoxTacGia
            // 
            this.updatecomboBoxTacGia.FormattingEnabled = true;
            this.updatecomboBoxTacGia.Location = new System.Drawing.Point(104, 163);
            this.updatecomboBoxTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.updatecomboBoxTacGia.Name = "updatecomboBoxTacGia";
            this.updatecomboBoxTacGia.Size = new System.Drawing.Size(103, 21);
            this.updatecomboBoxTacGia.TabIndex = 20;
            // 
            // updatecomboBoxTheLoaiSach
            // 
            this.updatecomboBoxTheLoaiSach.FormattingEnabled = true;
            this.updatecomboBoxTheLoaiSach.Location = new System.Drawing.Point(104, 126);
            this.updatecomboBoxTheLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.updatecomboBoxTheLoaiSach.Name = "updatecomboBoxTheLoaiSach";
            this.updatecomboBoxTheLoaiSach.Size = new System.Drawing.Size(103, 21);
            this.updatecomboBoxTheLoaiSach.TabIndex = 19;
            // 
            // updatetextSoLuong
            // 
            this.updatetextSoLuong.Location = new System.Drawing.Point(104, 89);
            this.updatetextSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.updatetextSoLuong.Name = "updatetextSoLuong";
            this.updatetextSoLuong.Size = new System.Drawing.Size(103, 20);
            this.updatetextSoLuong.TabIndex = 18;
            // 
            // updadetextGiaSach
            // 
            this.updadetextGiaSach.Location = new System.Drawing.Point(104, 53);
            this.updadetextGiaSach.Margin = new System.Windows.Forms.Padding(2);
            this.updadetextGiaSach.Name = "updadetextGiaSach";
            this.updadetextGiaSach.Size = new System.Drawing.Size(103, 20);
            this.updadetextGiaSach.TabIndex = 17;
            // 
            // updatetextTenSach
            // 
            this.updatetextTenSach.Location = new System.Drawing.Point(104, 25);
            this.updatetextTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.updatetextTenSach.Name = "updatetextTenSach";
            this.updatetextTenSach.Size = new System.Drawing.Size(103, 20);
            this.updatetextTenSach.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nhà xuất bản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 163);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tác giả";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Thể loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên sách";
            // 
            // GUI_QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ComboBoxTheLoai);
            this.Controls.Add(this.List_Books);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Load_List_Sach);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_QLSach";
            this.Size = new System.Drawing.Size(1447, 670);
            ((System.ComponentModel.ISupportInitialize)(this.Load_List_Sach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Load_List_Sach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search_Sach;
        private System.Windows.Forms.TextBox searchBookText;
        private System.Windows.Forms.Button List_Books;
        private System.Windows.Forms.ComboBox ComboBoxTheLoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.ComboBox comboBoxNhaXuatBan;
        private System.Windows.Forms.ComboBox comboBoxTacGia;
        private System.Windows.Forms.ComboBox comboBoxTheLoaiSach;
        private System.Windows.Forms.TextBox textGiaSach;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.TextBox textTenSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_SuaSach;
        private System.Windows.Forms.ComboBox updatecomboBoxNhaXuatBan;
        private System.Windows.Forms.ComboBox updatecomboBoxTacGia;
        private System.Windows.Forms.ComboBox updatecomboBoxTheLoaiSach;
        private System.Windows.Forms.TextBox updatetextSoLuong;
        private System.Windows.Forms.TextBox updadetextGiaSach;
        private System.Windows.Forms.TextBox updatetextTenSach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XoaSach;
    }
}

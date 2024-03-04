namespace GUI
{
    partial class GUI_PhieuMuon
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
            this.groupBoxThongTinMuon = new System.Windows.Forms.GroupBox();
            this.datePicker_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.datePicker_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.txt_madocgia = new System.Windows.Forms.TextBox();
            this.label_maphieumuon = new System.Windows.Forms.Label();
            this.txt_maphieumuon = new System.Windows.Forms.TextBox();
            this.label_madocgia = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.label_masach = new System.Windows.Forms.Label();
            this.label_ngaymuon = new System.Windows.Forms.Label();
            this.label_ngaytra = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_PhieuMuon = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxThongTinMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinMuon
            // 
            this.groupBoxThongTinMuon.Controls.Add(this.datePicker_ngaytra);
            this.groupBoxThongTinMuon.Controls.Add(this.datePicker_ngaymuon);
            this.groupBoxThongTinMuon.Controls.Add(this.txt_madocgia);
            this.groupBoxThongTinMuon.Controls.Add(this.label_maphieumuon);
            this.groupBoxThongTinMuon.Controls.Add(this.txt_maphieumuon);
            this.groupBoxThongTinMuon.Controls.Add(this.label_madocgia);
            this.groupBoxThongTinMuon.Controls.Add(this.txt_masach);
            this.groupBoxThongTinMuon.Controls.Add(this.label_masach);
            this.groupBoxThongTinMuon.Controls.Add(this.label_ngaymuon);
            this.groupBoxThongTinMuon.Controls.Add(this.label_ngaytra);
            this.groupBoxThongTinMuon.Location = new System.Drawing.Point(26, 45);
            this.groupBoxThongTinMuon.Name = "groupBoxThongTinMuon";
            this.groupBoxThongTinMuon.Size = new System.Drawing.Size(398, 199);
            this.groupBoxThongTinMuon.TabIndex = 0;
            this.groupBoxThongTinMuon.TabStop = false;
            this.groupBoxThongTinMuon.Text = "Thông tin phiếu mượn";
            // 
            // datePicker_ngaytra
            // 
            this.datePicker_ngaytra.Checked = false;
            this.datePicker_ngaytra.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.datePicker_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_ngaytra.Location = new System.Drawing.Point(157, 151);
            this.datePicker_ngaytra.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.datePicker_ngaytra.Name = "datePicker_ngaytra";
            this.datePicker_ngaytra.Size = new System.Drawing.Size(169, 20);
            this.datePicker_ngaytra.TabIndex = 12;
            this.datePicker_ngaytra.Value = new System.DateTime(2024, 1, 26, 9, 40, 48, 0);
            // 
            // datePicker_ngaymuon
            // 
            this.datePicker_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_ngaymuon.Location = new System.Drawing.Point(157, 119);
            this.datePicker_ngaymuon.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.datePicker_ngaymuon.Name = "datePicker_ngaymuon";
            this.datePicker_ngaymuon.Size = new System.Drawing.Size(169, 20);
            this.datePicker_ngaymuon.TabIndex = 11;
            this.datePicker_ngaymuon.ValueChanged += new System.EventHandler(this.datePicker_ngaymuon_ValueChanged);
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Location = new System.Drawing.Point(157, 55);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Size = new System.Drawing.Size(169, 20);
            this.txt_madocgia.TabIndex = 9;
            // 
            // label_maphieumuon
            // 
            this.label_maphieumuon.AutoSize = true;
            this.label_maphieumuon.Location = new System.Drawing.Point(24, 33);
            this.label_maphieumuon.Name = "label_maphieumuon";
            this.label_maphieumuon.Size = new System.Drawing.Size(86, 13);
            this.label_maphieumuon.TabIndex = 8;
            this.label_maphieumuon.Text = "Mã phiếu mượn :";
            // 
            // txt_maphieumuon
            // 
            this.txt_maphieumuon.Enabled = false;
            this.txt_maphieumuon.Location = new System.Drawing.Point(157, 26);
            this.txt_maphieumuon.Name = "txt_maphieumuon";
            this.txt_maphieumuon.ReadOnly = true;
            this.txt_maphieumuon.Size = new System.Drawing.Size(169, 20);
            this.txt_maphieumuon.TabIndex = 7;
            // 
            // label_madocgia
            // 
            this.label_madocgia.AutoSize = true;
            this.label_madocgia.Location = new System.Drawing.Point(24, 62);
            this.label_madocgia.Name = "label_madocgia";
            this.label_madocgia.Size = new System.Drawing.Size(67, 13);
            this.label_madocgia.TabIndex = 6;
            this.label_madocgia.Text = "Mã độc giả :";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(157, 90);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(169, 20);
            this.txt_masach.TabIndex = 5;
            // 
            // label_masach
            // 
            this.label_masach.AutoSize = true;
            this.label_masach.Location = new System.Drawing.Point(24, 97);
            this.label_masach.Name = "label_masach";
            this.label_masach.Size = new System.Drawing.Size(54, 13);
            this.label_masach.TabIndex = 4;
            this.label_masach.Text = "Mã sách :";
            // 
            // label_ngaymuon
            // 
            this.label_ngaymuon.AutoSize = true;
            this.label_ngaymuon.Location = new System.Drawing.Point(24, 125);
            this.label_ngaymuon.Name = "label_ngaymuon";
            this.label_ngaymuon.Size = new System.Drawing.Size(67, 13);
            this.label_ngaymuon.TabIndex = 2;
            this.label_ngaymuon.Text = "Ngày mượn :";
            // 
            // label_ngaytra
            // 
            this.label_ngaytra.AutoSize = true;
            this.label_ngaytra.Location = new System.Drawing.Point(24, 158);
            this.label_ngaytra.Name = "label_ngaytra";
            this.label_ngaytra.Size = new System.Drawing.Size(53, 13);
            this.label_ngaytra.TabIndex = 0;
            this.label_ngaytra.Text = "Ngày trả :";
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Location = new System.Drawing.Point(475, 55);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Location = new System.Drawing.Point(475, 97);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Location = new System.Drawing.Point(475, 137);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgv_PhieuMuon
            // 
            this.dgv_PhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.HoTenDocGia,
            this.TenSach,
            this.NgayMuon,
            this.NgayPhaiTra,
            this.NguoiTao,
            this.Status});
            this.dgv_PhieuMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_PhieuMuon.Location = new System.Drawing.Point(26, 252);
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.Size = new System.Drawing.Size(762, 150);
            this.dgv_PhieuMuon.TabIndex = 4;
            this.dgv_PhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuMuon_CellClick);
            this.dgv_PhieuMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_PhieuMuon_CellFormatting);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu";
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // HoTenDocGia
            // 
            this.HoTenDocGia.DataPropertyName = "HoTenDocGia";
            this.HoTenDocGia.HeaderText = "Tên Độc Giả";
            this.HoTenDocGia.Name = "HoTenDocGia";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách ";
            this.TenSach.Name = "TenSach";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayPhaiTra
            // 
            this.NgayPhaiTra.DataPropertyName = "NgayPhaiTra";
            this.NgayPhaiTra.HeaderText = "Ngày Phải Trả";
            this.NgayPhaiTra.Name = "NgayPhaiTra";
            // 
            // NguoiTao
            // 
            this.NguoiTao.DataPropertyName = "NguoiTao";
            this.NguoiTao.HeaderText = "Người Tạo";
            this.NguoiTao.Name = "NguoiTao";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình Trạng";
            this.Status.Name = "Status";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Location = new System.Drawing.Point(475, 180);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(475, 221);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(583, 221);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(169, 20);
            this.txt_TimKiem.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(682, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã độc giả";
            // 
            // GUI_PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.dgv_PhieuMuon);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBoxThongTinMuon);
            this.Name = "GUI_PhieuMuon";
            this.Size = new System.Drawing.Size(791, 405);
            this.Load += new System.EventHandler(this.GUI_PhieuMuon_Load);
            this.groupBoxThongTinMuon.ResumeLayout(false);
            this.groupBoxThongTinMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinMuon;
        private System.Windows.Forms.Label label_ngaytra;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Label label_masach;
        private System.Windows.Forms.Label label_ngaymuon;
        private System.Windows.Forms.TextBox txt_maphieumuon;
        private System.Windows.Forms.Label label_madocgia;
        private System.Windows.Forms.TextBox txt_madocgia;
        private System.Windows.Forms.Label label_maphieumuon;
        private System.Windows.Forms.DateTimePicker datePicker_ngaymuon;
        private System.Windows.Forms.DateTimePicker datePicker_ngaytra;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_PhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_TimKiem;
        internal System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label1;
    }
}

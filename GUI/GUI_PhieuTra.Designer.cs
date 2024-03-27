namespace GUI
{
    partial class GUI_PhieuTra
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
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaPhieuTraSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiTao = new System.Windows.Forms.TextBox();
            this.txtMaPhieuTra = new System.Windows.Forms.TextBox();
            this.lb_nguoitao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_maphieumuon = new System.Windows.Forms.Label();
            this.lp_maphieutra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(47, 338);
            this.gridview.Margin = new System.Windows.Forms.Padding(4);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.RowHeadersWidth = 57;
            this.gridview.Size = new System.Drawing.Size(778, 314);
            this.gridview.TabIndex = 403;
            this.gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellClick);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(710, 298);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(115, 39);
            this.btnTim.TabIndex = 402;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaPhieuTraSearch
            // 
            this.txtMaPhieuTraSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuTraSearch.Location = new System.Drawing.Point(476, 305);
            this.txtMaPhieuTraSearch.Name = "txtMaPhieuTraSearch";
            this.txtMaPhieuTraSearch.Size = new System.Drawing.Size(228, 26);
            this.txtMaPhieuTraSearch.TabIndex = 401;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 400;
            this.label3.Text = "Mã Phiếu Trả";
            // 
            // cboMaPhieuMuon
            // 
            this.cboMaPhieuMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPhieuMuon.FormattingEnabled = true;
            this.cboMaPhieuMuon.Location = new System.Drawing.Point(222, 162);
            this.cboMaPhieuMuon.Name = "cboMaPhieuMuon";
            this.cboMaPhieuMuon.Size = new System.Drawing.Size(228, 28);
            this.cboMaPhieuMuon.TabIndex = 399;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(616, 168);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 398;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(663, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 397;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(582, 123);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 396;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(535, 168);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 395;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(501, 123);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 394;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(222, 195);
            this.dtNgayTra.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(228, 26);
            this.dtNgayTra.TabIndex = 393;
            // 
            // txtNguoiTao
            // 
            this.txtNguoiTao.Enabled = false;
            this.txtNguoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiTao.Location = new System.Drawing.Point(222, 225);
            this.txtNguoiTao.Name = "txtNguoiTao";
            this.txtNguoiTao.Size = new System.Drawing.Size(228, 26);
            this.txtNguoiTao.TabIndex = 392;
            // 
            // txtMaPhieuTra
            // 
            this.txtMaPhieuTra.Enabled = false;
            this.txtMaPhieuTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuTra.Location = new System.Drawing.Point(222, 131);
            this.txtMaPhieuTra.Name = "txtMaPhieuTra";
            this.txtMaPhieuTra.Size = new System.Drawing.Size(228, 26);
            this.txtMaPhieuTra.TabIndex = 391;
            // 
            // lb_nguoitao
            // 
            this.lb_nguoitao.AutoSize = true;
            this.lb_nguoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nguoitao.Location = new System.Drawing.Point(71, 228);
            this.lb_nguoitao.Name = "lb_nguoitao";
            this.lb_nguoitao.Size = new System.Drawing.Size(81, 20);
            this.lb_nguoitao.TabIndex = 389;
            this.lb_nguoitao.Text = "Người Tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 388;
            this.label4.Text = "Ngày trả";
            // 
            // lb_maphieumuon
            // 
            this.lb_maphieumuon.AutoSize = true;
            this.lb_maphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maphieumuon.Location = new System.Drawing.Point(71, 167);
            this.lb_maphieumuon.Name = "lb_maphieumuon";
            this.lb_maphieumuon.Size = new System.Drawing.Size(119, 20);
            this.lb_maphieumuon.TabIndex = 387;
            this.lb_maphieumuon.Text = "Mã Phiếu Mượn";
            // 
            // lp_maphieutra
            // 
            this.lp_maphieutra.AutoSize = true;
            this.lp_maphieutra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_maphieutra.Location = new System.Drawing.Point(71, 131);
            this.lp_maphieutra.Name = "lp_maphieutra";
            this.lp_maphieutra.Size = new System.Drawing.Size(102, 20);
            this.lp_maphieutra.TabIndex = 390;
            this.lp_maphieutra.Text = "Mã Phiếu Trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 386;
            this.label2.Text = "Phiếu Trả Sách";
            // 
            // GUI_PhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaPhieuTraSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaPhieuMuon);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.txtNguoiTao);
            this.Controls.Add(this.txtMaPhieuTra);
            this.Controls.Add(this.lb_nguoitao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_maphieumuon);
            this.Controls.Add(this.lp_maphieutra);
            this.Controls.Add(this.label2);
            this.Name = "GUI_PhieuTra";
            this.Size = new System.Drawing.Size(873, 718);
            this.Load += new System.EventHandler(this.GUI_PhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaPhieuTraSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaPhieuMuon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.TextBox txtNguoiTao;
        private System.Windows.Forms.TextBox txtMaPhieuTra;
        private System.Windows.Forms.Label lb_nguoitao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_maphieumuon;
        private System.Windows.Forms.Label lp_maphieutra;
        private System.Windows.Forms.Label label2;
    }
}

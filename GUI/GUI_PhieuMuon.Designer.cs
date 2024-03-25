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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_PhieuMuon));
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
            resources.ApplyResources(this.groupBoxThongTinMuon, "groupBoxThongTinMuon");
            this.groupBoxThongTinMuon.Name = "groupBoxThongTinMuon";
            this.groupBoxThongTinMuon.TabStop = false;
            // 
            // datePicker_ngaytra
            // 
            this.datePicker_ngaytra.Checked = false;
            resources.ApplyResources(this.datePicker_ngaytra, "datePicker_ngaytra");
            this.datePicker_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_ngaytra.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.datePicker_ngaytra.Name = "datePicker_ngaytra";
            this.datePicker_ngaytra.Value = new System.DateTime(2024, 1, 26, 9, 40, 48, 0);
            // 
            // datePicker_ngaymuon
            // 
            this.datePicker_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.datePicker_ngaymuon, "datePicker_ngaymuon");
            this.datePicker_ngaymuon.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.datePicker_ngaymuon.Name = "datePicker_ngaymuon";
            this.datePicker_ngaymuon.ValueChanged += new System.EventHandler(this.datePicker_ngaymuon_ValueChanged);
            // 
            // txt_madocgia
            // 
            resources.ApplyResources(this.txt_madocgia, "txt_madocgia");
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.TextChanged += new System.EventHandler(this.txt_madocgia_TextChanged);
            // 
            // label_maphieumuon
            // 
            resources.ApplyResources(this.label_maphieumuon, "label_maphieumuon");
            this.label_maphieumuon.Name = "label_maphieumuon";
            // 
            // txt_maphieumuon
            // 
            resources.ApplyResources(this.txt_maphieumuon, "txt_maphieumuon");
            this.txt_maphieumuon.Name = "txt_maphieumuon";
            this.txt_maphieumuon.ReadOnly = true;
            // 
            // label_madocgia
            // 
            resources.ApplyResources(this.label_madocgia, "label_madocgia");
            this.label_madocgia.Name = "label_madocgia";
            // 
            // txt_masach
            // 
            resources.ApplyResources(this.txt_masach, "txt_masach");
            this.txt_masach.Name = "txt_masach";
            // 
            // label_masach
            // 
            resources.ApplyResources(this.label_masach, "label_masach");
            this.label_masach.Name = "label_masach";
            // 
            // label_ngaymuon
            // 
            resources.ApplyResources(this.label_ngaymuon, "label_ngaymuon");
            this.label_ngaymuon.Name = "label_ngaymuon";
            // 
            // label_ngaytra
            // 
            resources.ApplyResources(this.label_ngaytra, "label_ngaytra");
            this.label_ngaytra.Name = "label_ngaytra";
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Them, "btn_Them");
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Sua, "btn_Sua");
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Xoa, "btn_Xoa");
            this.btn_Xoa.Name = "btn_Xoa";
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
            resources.ApplyResources(this.dgv_PhieuMuon, "dgv_PhieuMuon");
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuMuon_CellClick);
            this.dgv_PhieuMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_PhieuMuon_CellFormatting);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            resources.ApplyResources(this.MaPhieuMuon, "MaPhieuMuon");
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // HoTenDocGia
            // 
            this.HoTenDocGia.DataPropertyName = "HoTenDocGia";
            resources.ApplyResources(this.HoTenDocGia, "HoTenDocGia");
            this.HoTenDocGia.Name = "HoTenDocGia";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            resources.ApplyResources(this.TenSach, "TenSach");
            this.TenSach.Name = "TenSach";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            resources.ApplyResources(this.NgayMuon, "NgayMuon");
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayPhaiTra
            // 
            this.NgayPhaiTra.DataPropertyName = "NgayPhaiTra";
            resources.ApplyResources(this.NgayPhaiTra, "NgayPhaiTra");
            this.NgayPhaiTra.Name = "NgayPhaiTra";
            // 
            // NguoiTao
            // 
            this.NguoiTao.DataPropertyName = "NguoiTao";
            resources.ApplyResources(this.NguoiTao, "NguoiTao");
            this.NguoiTao.Name = "NguoiTao";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Reset, "btn_Reset");
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_TimKiem, "btn_TimKiem");
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            resources.ApplyResources(this.txt_TimKiem, "txt_TimKiem");
            this.txt_TimKiem.Name = "txt_TimKiem";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // GUI_PhieuMuon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

namespace SWarehouse
{
    partial class F06_QLXuatKho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grb_ThongTinChung = new System.Windows.Forms.GroupBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.rdb_ChuaKiem = new System.Windows.Forms.RadioButton();
            this.lbl_MaKho = new System.Windows.Forms.Label();
            this.rdb_DaKiem = new System.Windows.Forms.RadioButton();
            this.lbl_NgayXuat = new System.Windows.Forms.Label();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.grb_ChiTietPhieuXuat = new System.Windows.Forms.GroupBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lbl_MaSanPham = new System.Windows.Forms.Label();
            this.dgvDetailGDN = new System.Windows.Forms.DataGridView();
            this.sanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongXuatThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f06QLXuatKhoChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_QuanLiXuatkho = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgvGDN = new System.Windows.Forms.DataGridView();
            this.phieuXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f06QLXuatKhoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_ThongTinChung.SuspendLayout();
            this.grb_ChiTietPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailGDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f06QLXuatKhoChiTietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f06QLXuatKhoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_ThongTinChung
            // 
            this.grb_ThongTinChung.Controls.Add(this.cboNhanVien);
            this.grb_ThongTinChung.Controls.Add(this.cboKho);
            this.grb_ThongTinChung.Controls.Add(this.dtpNgayXuat);
            this.grb_ThongTinChung.Controls.Add(this.lbl_MaNhanVien);
            this.grb_ThongTinChung.Controls.Add(this.rdb_ChuaKiem);
            this.grb_ThongTinChung.Controls.Add(this.lbl_MaKho);
            this.grb_ThongTinChung.Controls.Add(this.rdb_DaKiem);
            this.grb_ThongTinChung.Controls.Add(this.lbl_NgayXuat);
            this.grb_ThongTinChung.Controls.Add(this.lbl_TrangThai);
            this.grb_ThongTinChung.Location = new System.Drawing.Point(50, 91);
            this.grb_ThongTinChung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_ThongTinChung.Name = "grb_ThongTinChung";
            this.grb_ThongTinChung.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_ThongTinChung.Size = new System.Drawing.Size(402, 199);
            this.grb_ThongTinChung.TabIndex = 0;
            this.grb_ThongTinChung.TabStop = false;
            this.grb_ThongTinChung.Text = "Thông Tin Chung";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(110, 69);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(264, 21);
            this.cboNhanVien.TabIndex = 15;
            this.cboNhanVien.SelectionChangeCommitted += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            this.cboNhanVien.SelectedValueChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // cboKho
            // 
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(110, 32);
            this.cboKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(264, 21);
            this.cboKho.TabIndex = 14;
            this.cboKho.SelectionChangeCommitted += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            this.cboKho.SelectedValueChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Location = new System.Drawing.Point(110, 95);
            this.dtpNgayXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(264, 20);
            this.dtpNgayXuat.TabIndex = 11;
            this.dtpNgayXuat.CloseUp += new System.EventHandler(this.dtpNgayXuat_CloseUp);
            this.dtpNgayXuat.ValueChanged += new System.EventHandler(this.dtpNgayXuat_CloseUp);
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.AutoSize = true;
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(20, 72);
            this.lbl_MaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(56, 13);
            this.lbl_MaNhanVien.TabIndex = 2;
            this.lbl_MaNhanVien.Text = "Nhân viên";
            this.lbl_MaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdb_ChuaKiem
            // 
            this.rdb_ChuaKiem.AutoSize = true;
            this.rdb_ChuaKiem.Location = new System.Drawing.Point(223, 134);
            this.rdb_ChuaKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_ChuaKiem.Name = "rdb_ChuaKiem";
            this.rdb_ChuaKiem.Size = new System.Drawing.Size(74, 17);
            this.rdb_ChuaKiem.TabIndex = 10;
            this.rdb_ChuaKiem.TabStop = true;
            this.rdb_ChuaKiem.Text = "Chờ Xử Lý";
            this.rdb_ChuaKiem.UseVisualStyleBackColor = true;
            // 
            // lbl_MaKho
            // 
            this.lbl_MaKho.AutoSize = true;
            this.lbl_MaKho.Location = new System.Drawing.Point(20, 38);
            this.lbl_MaKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaKho.Name = "lbl_MaKho";
            this.lbl_MaKho.Size = new System.Drawing.Size(26, 13);
            this.lbl_MaKho.TabIndex = 1;
            this.lbl_MaKho.Text = "Kho";
            // 
            // rdb_DaKiem
            // 
            this.rdb_DaKiem.AutoSize = true;
            this.rdb_DaKiem.Location = new System.Drawing.Point(110, 134);
            this.rdb_DaKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_DaKiem.Name = "rdb_DaKiem";
            this.rdb_DaKiem.Size = new System.Drawing.Size(102, 17);
            this.rdb_DaKiem.TabIndex = 9;
            this.rdb_DaKiem.TabStop = true;
            this.rdb_DaKiem.Text = "Đã Hoàn Thành";
            this.rdb_DaKiem.UseVisualStyleBackColor = true;
            // 
            // lbl_NgayXuat
            // 
            this.lbl_NgayXuat.AutoSize = true;
            this.lbl_NgayXuat.Location = new System.Drawing.Point(20, 98);
            this.lbl_NgayXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NgayXuat.Name = "lbl_NgayXuat";
            this.lbl_NgayXuat.Size = new System.Drawing.Size(57, 13);
            this.lbl_NgayXuat.TabIndex = 7;
            this.lbl_NgayXuat.Text = "Ngày Xuất";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Location = new System.Drawing.Point(20, 132);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(59, 13);
            this.lbl_TrangThai.TabIndex = 8;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // grb_ChiTietPhieuXuat
            // 
            this.grb_ChiTietPhieuXuat.Controls.Add(this.cboSanPham);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.lbl_MaSanPham);
            this.grb_ChiTietPhieuXuat.Location = new System.Drawing.Point(50, 301);
            this.grb_ChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_ChiTietPhieuXuat.Name = "grb_ChiTietPhieuXuat";
            this.grb_ChiTietPhieuXuat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_ChiTietPhieuXuat.Size = new System.Drawing.Size(402, 211);
            this.grb_ChiTietPhieuXuat.TabIndex = 1;
            this.grb_ChiTietPhieuXuat.TabStop = false;
            this.grb_ChiTietPhieuXuat.Text = "Chi Tiết Phiếu Xuất";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(110, 24);
            this.cboSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(264, 21);
            this.cboSanPham.TabIndex = 14;
            // 
            // lbl_MaSanPham
            // 
            this.lbl_MaSanPham.AutoSize = true;
            this.lbl_MaSanPham.Location = new System.Drawing.Point(20, 26);
            this.lbl_MaSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaSanPham.Name = "lbl_MaSanPham";
            this.lbl_MaSanPham.Size = new System.Drawing.Size(55, 13);
            this.lbl_MaSanPham.TabIndex = 0;
            this.lbl_MaSanPham.Text = "Sản phẩm";
            // 
            // dgvDetailGDN
            // 
            this.dgvDetailGDN.AllowUserToAddRows = false;
            this.dgvDetailGDN.AllowUserToDeleteRows = false;
            this.dgvDetailGDN.AutoGenerateColumns = false;
            this.dgvDetailGDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailGDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanPhamDataGridViewTextBoxColumn,
            this.soLuongXuatDataGridViewTextBoxColumn,
            this.soLuongXuatThucDataGridViewTextBoxColumn});
            this.dgvDetailGDN.DataSource = this.f06QLXuatKhoChiTietBindingSource;
            this.dgvDetailGDN.Location = new System.Drawing.Point(481, 313);
            this.dgvDetailGDN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetailGDN.Name = "dgvDetailGDN";
            this.dgvDetailGDN.ReadOnly = true;
            this.dgvDetailGDN.RowHeadersWidth = 51;
            this.dgvDetailGDN.RowTemplate.Height = 24;
            this.dgvDetailGDN.Size = new System.Drawing.Size(602, 199);
            this.dgvDetailGDN.TabIndex = 19;
            // 
            // sanPhamDataGridViewTextBoxColumn
            // 
            this.sanPhamDataGridViewTextBoxColumn.DataPropertyName = "SanPham";
            this.sanPhamDataGridViewTextBoxColumn.HeaderText = "SanPham";
            this.sanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanPhamDataGridViewTextBoxColumn.Name = "sanPhamDataGridViewTextBoxColumn";
            this.sanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.sanPhamDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongXuatDataGridViewTextBoxColumn
            // 
            this.soLuongXuatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuat";
            this.soLuongXuatDataGridViewTextBoxColumn.HeaderText = "SoLuongXuat";
            this.soLuongXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongXuatDataGridViewTextBoxColumn.Name = "soLuongXuatDataGridViewTextBoxColumn";
            this.soLuongXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongXuatThucDataGridViewTextBoxColumn
            // 
            this.soLuongXuatThucDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuatThuc";
            this.soLuongXuatThucDataGridViewTextBoxColumn.HeaderText = "SoLuongXuatThuc";
            this.soLuongXuatThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongXuatThucDataGridViewTextBoxColumn.Name = "soLuongXuatThucDataGridViewTextBoxColumn";
            this.soLuongXuatThucDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongXuatThucDataGridViewTextBoxColumn.Width = 125;
            // 
            // f06QLXuatKhoChiTietBindingSource
            // 
            this.f06QLXuatKhoChiTietBindingSource.DataSource = typeof(SWarehouse.Models.GDNModels.F06_QLXuatKhoChiTiet);
            // 
            // lbl_QuanLiXuatkho
            // 
            this.lbl_QuanLiXuatkho.AutoSize = true;
            this.lbl_QuanLiXuatkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLiXuatkho.Location = new System.Drawing.Point(64, 20);
            this.lbl_QuanLiXuatkho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_QuanLiXuatkho.Name = "lbl_QuanLiXuatkho";
            this.lbl_QuanLiXuatkho.Size = new System.Drawing.Size(318, 44);
            this.lbl_QuanLiXuatkho.TabIndex = 2;
            this.lbl_QuanLiXuatkho.Text = "Quản Lí Xuất Kho";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(962, 544);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(122, 37);
            this.btn_Thoat.TabIndex = 18;
            this.btn_Thoat.Text = "Đóng";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::SWarehouse.Properties.Resources.edit;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(795, 544);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(122, 37);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them.Image = global::SWarehouse.Properties.Resources.plus;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(622, 544);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(122, 37);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(653, 42);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 20);
            this.txtSearch.TabIndex = 12;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::SWarehouse.Properties.Resources.search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(962, 33);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(122, 37);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgvGDN
            // 
            this.dgvGDN.AllowUserToAddRows = false;
            this.dgvGDN.AllowUserToDeleteRows = false;
            this.dgvGDN.AutoGenerateColumns = false;
            this.dgvGDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuXuatDataGridViewTextBoxColumn,
            this.khoDataGridViewTextBoxColumn,
            this.nhanVienDataGridViewTextBoxColumn,
            this.requestNoteDataGridViewTextBoxColumn,
            this.ngayXuatDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgvGDN.DataSource = this.f06QLXuatKhoModelBindingSource;
            this.dgvGDN.Location = new System.Drawing.Point(481, 91);
            this.dgvGDN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGDN.Name = "dgvGDN";
            this.dgvGDN.ReadOnly = true;
            this.dgvGDN.RowHeadersWidth = 51;
            this.dgvGDN.RowTemplate.Height = 24;
            this.dgvGDN.Size = new System.Drawing.Size(602, 199);
            this.dgvGDN.TabIndex = 20;
            this.dgvGDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // phieuXuatDataGridViewTextBoxColumn
            // 
            this.phieuXuatDataGridViewTextBoxColumn.DataPropertyName = "PhieuXuat";
            this.phieuXuatDataGridViewTextBoxColumn.HeaderText = "Phiếu Xuất";
            this.phieuXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phieuXuatDataGridViewTextBoxColumn.Name = "phieuXuatDataGridViewTextBoxColumn";
            this.phieuXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.phieuXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // khoDataGridViewTextBoxColumn
            // 
            this.khoDataGridViewTextBoxColumn.DataPropertyName = "Kho";
            this.khoDataGridViewTextBoxColumn.HeaderText = "Kho";
            this.khoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoDataGridViewTextBoxColumn.Name = "khoDataGridViewTextBoxColumn";
            this.khoDataGridViewTextBoxColumn.ReadOnly = true;
            this.khoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienDataGridViewTextBoxColumn
            // 
            this.nhanVienDataGridViewTextBoxColumn.DataPropertyName = "NhanVien";
            this.nhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân Viên";
            this.nhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhanVienDataGridViewTextBoxColumn.Name = "nhanVienDataGridViewTextBoxColumn";
            this.nhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.nhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestNoteDataGridViewTextBoxColumn
            // 
            this.requestNoteDataGridViewTextBoxColumn.DataPropertyName = "RequestNote";
            this.requestNoteDataGridViewTextBoxColumn.HeaderText = "Phiếu Yêu Cầu Nhập";
            this.requestNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestNoteDataGridViewTextBoxColumn.Name = "requestNoteDataGridViewTextBoxColumn";
            this.requestNoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestNoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayXuatDataGridViewTextBoxColumn
            // 
            this.ngayXuatDataGridViewTextBoxColumn.DataPropertyName = "NgayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.HeaderText = "Ngày Xuất";
            this.ngayXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayXuatDataGridViewTextBoxColumn.Name = "ngayXuatDataGridViewTextBoxColumn";
            this.ngayXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // f06QLXuatKhoModelBindingSource
            // 
            this.f06QLXuatKhoModelBindingSource.DataSource = typeof(SWarehouse.Models.GDNModels.F06_QLXuatKhoModel);
            // 
            // F06_QLXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.Controls.Add(this.dgvGDN);
            this.Controls.Add(this.dgvDetailGDN);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_QuanLiXuatkho);
            this.Controls.Add(this.grb_ChiTietPhieuXuat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.grb_ThongTinChung);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F06_QLXuatKho";
            this.Text = "Quản lý xuất kho";
            this.Load += new System.EventHandler(this.F06_QLXuatKho_Load);
            this.grb_ThongTinChung.ResumeLayout(false);
            this.grb_ThongTinChung.PerformLayout();
            this.grb_ChiTietPhieuXuat.ResumeLayout(false);
            this.grb_ChiTietPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailGDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f06QLXuatKhoChiTietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f06QLXuatKhoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ThongTinChung;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.RadioButton rdb_ChuaKiem;
        private System.Windows.Forms.RadioButton rdb_DaKiem;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_NgayXuat;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.Label lbl_MaKho;
        private System.Windows.Forms.GroupBox grb_ChiTietPhieuXuat;
        private System.Windows.Forms.Label lbl_QuanLiXuatkho;
        private System.Windows.Forms.Label lbl_MaSanPham;
        public System.Windows.Forms.Button btn_Thoat;
        public System.Windows.Forms.Button btn_Sua;
        public System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.DataGridView dgvDetailGDN;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.BindingSource f06QLXuatKhoModelBindingSource;
        private System.Windows.Forms.DataGridView dgvGDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongXuatThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource f06QLXuatKhoChiTietBindingSource;
    }
}
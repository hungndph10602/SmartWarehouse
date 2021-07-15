namespace SmartWareHouse
{
    partial class F07_QLHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F07_QLHoaDon));
            this.lbl_title = new System.Windows.Forms.Label();
            this.GRB_infototal = new System.Windows.Forms.GroupBox();
            this.cbx_staff = new System.Windows.Forms.ComboBox();
            this.cbx_customer = new System.Windows.Forms.ComboBox();
            this.lbl_MNV = new System.Windows.Forms.Label();
            this.rdo_unactive = new System.Windows.Forms.RadioButton();
            this.lbl_MKH = new System.Windows.Forms.Label();
            this.rdo_active = new System.Windows.Forms.RadioButton();
            this.dtp_dateCreate = new System.Windows.Forms.DateTimePicker();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_datecreate = new System.Windows.Forms.Label();
            this.dgv_orderDetail = new System.Windows.Forms.DataGridView();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f07QuanLyHoaDonChiTietModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_ThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_oders = new System.Windows.Forms.DataGridView();
            this.hoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f07QuanLyHoaDonModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.GRB_infototal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f07QuanLyHoaDonChiTietModelBindingSource)).BeginInit();
            this.grb_ThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f07QuanLyHoaDonModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(60, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(468, 65);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Quản Lí Hóa Đơn";
            // 
            // GRB_infototal
            // 
            this.GRB_infototal.Controls.Add(this.cbx_staff);
            this.GRB_infototal.Controls.Add(this.cbx_customer);
            this.GRB_infototal.Controls.Add(this.lbl_MNV);
            this.GRB_infototal.Controls.Add(this.rdo_unactive);
            this.GRB_infototal.Controls.Add(this.lbl_MKH);
            this.GRB_infototal.Controls.Add(this.rdo_active);
            this.GRB_infototal.Controls.Add(this.dtp_dateCreate);
            this.GRB_infototal.Controls.Add(this.lbl_status);
            this.GRB_infototal.Controls.Add(this.lbl_datecreate);
            this.GRB_infototal.Location = new System.Drawing.Point(47, 88);
            this.GRB_infototal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GRB_infototal.Name = "GRB_infototal";
            this.GRB_infototal.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GRB_infototal.Size = new System.Drawing.Size(352, 401);
            this.GRB_infototal.TabIndex = 1;
            this.GRB_infototal.TabStop = false;
            this.GRB_infototal.Text = "Thông Tin Chung";
            // 
            // cbx_staff
            // 
            this.cbx_staff.FormattingEnabled = true;
            this.cbx_staff.Location = new System.Drawing.Point(18, 114);
            this.cbx_staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_staff.Name = "cbx_staff";
            this.cbx_staff.Size = new System.Drawing.Size(310, 28);
            this.cbx_staff.TabIndex = 21;
            this.cbx_staff.SelectedIndexChanged += new System.EventHandler(this.cbx_staff_SelectedIndexChanged);
            this.cbx_staff.SelectionChangeCommitted += new System.EventHandler(this.cbx_staff_SelectedIndexChanged);
            // 
            // cbx_customer
            // 
            this.cbx_customer.FormattingEnabled = true;
            this.cbx_customer.Location = new System.Drawing.Point(18, 60);
            this.cbx_customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_customer.Name = "cbx_customer";
            this.cbx_customer.Size = new System.Drawing.Size(310, 28);
            this.cbx_customer.TabIndex = 15;
            this.cbx_customer.SelectedIndexChanged += new System.EventHandler(this.cbx_customer_SelectedIndexChanged);
            this.cbx_customer.SelectionChangeCommitted += new System.EventHandler(this.cbx_customer_SelectedIndexChanged);
            // 
            // lbl_MNV
            // 
            this.lbl_MNV.AutoSize = true;
            this.lbl_MNV.Location = new System.Drawing.Point(17, 95);
            this.lbl_MNV.Name = "lbl_MNV";
            this.lbl_MNV.Size = new System.Drawing.Size(83, 20);
            this.lbl_MNV.TabIndex = 2;
            this.lbl_MNV.Text = "Nhân Viên";
            // 
            // rdo_unactive
            // 
            this.rdo_unactive.AutoSize = true;
            this.rdo_unactive.Location = new System.Drawing.Point(176, 237);
            this.rdo_unactive.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rdo_unactive.Name = "rdo_unactive";
            this.rdo_unactive.Size = new System.Drawing.Size(161, 24);
            this.rdo_unactive.TabIndex = 12;
            this.rdo_unactive.TabStop = true;
            this.rdo_unactive.Text = "Chưa Thanh Toán";
            this.rdo_unactive.UseVisualStyleBackColor = true;
            // 
            // lbl_MKH
            // 
            this.lbl_MKH.AutoSize = true;
            this.lbl_MKH.Location = new System.Drawing.Point(14, 34);
            this.lbl_MKH.Name = "lbl_MKH";
            this.lbl_MKH.Size = new System.Drawing.Size(97, 20);
            this.lbl_MKH.TabIndex = 1;
            this.lbl_MKH.Text = "Khách Hàng";
            // 
            // rdo_active
            // 
            this.rdo_active.AutoSize = true;
            this.rdo_active.Location = new System.Drawing.Point(24, 237);
            this.rdo_active.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rdo_active.Name = "rdo_active";
            this.rdo_active.Size = new System.Drawing.Size(144, 24);
            this.rdo_active.TabIndex = 11;
            this.rdo_active.TabStop = true;
            this.rdo_active.Text = "Đã Thanh Toán";
            this.rdo_active.UseVisualStyleBackColor = true;
            // 
            // dtp_dateCreate
            // 
            this.dtp_dateCreate.CustomFormat = "dd/MM/yyyy";
            this.dtp_dateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateCreate.Location = new System.Drawing.Point(19, 174);
            this.dtp_dateCreate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtp_dateCreate.Name = "dtp_dateCreate";
            this.dtp_dateCreate.Size = new System.Drawing.Size(309, 26);
            this.dtp_dateCreate.TabIndex = 10;
            this.dtp_dateCreate.CloseUp += new System.EventHandler(this.dtp_dateCreate_CloseUp);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(17, 214);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(84, 20);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Trạng Thái";
            // 
            // lbl_datecreate
            // 
            this.lbl_datecreate.AutoSize = true;
            this.lbl_datecreate.Location = new System.Drawing.Point(15, 149);
            this.lbl_datecreate.Name = "lbl_datecreate";
            this.lbl_datecreate.Size = new System.Drawing.Size(76, 20);
            this.lbl_datecreate.TabIndex = 3;
            this.lbl_datecreate.Text = "Ngày Tạo";
            // 
            // dgv_orderDetail
            // 
            this.dgv_orderDetail.AllowUserToAddRows = false;
            this.dgv_orderDetail.AllowUserToDeleteRows = false;
            this.dgv_orderDetail.AutoGenerateColumns = false;
            this.dgv_orderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSPDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dgv_orderDetail.DataSource = this.f07QuanLyHoaDonChiTietModelBindingSource;
            this.dgv_orderDetail.Location = new System.Drawing.Point(428, 513);
            this.dgv_orderDetail.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgv_orderDetail.Name = "dgv_orderDetail";
            this.dgv_orderDetail.ReadOnly = true;
            this.dgv_orderDetail.RowHeadersWidth = 51;
            this.dgv_orderDetail.RowTemplate.Height = 24;
            this.dgv_orderDetail.Size = new System.Drawing.Size(1043, 304);
            this.dgv_orderDetail.TabIndex = 19;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSPDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Mã Sản phẩm";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaDataGridViewTextBoxColumn.Width = 150;
            // 
            // f07QuanLyHoaDonChiTietModelBindingSource
            // 
            this.f07QuanLyHoaDonChiTietModelBindingSource.DataSource = typeof(SWarehouse.Models.BillModels.F07_QuanLyHoaDonChiTietModel);
            // 
            // grb_ThongTinHoaDon
            // 
            this.grb_ThongTinHoaDon.Controls.Add(this.cbx_product);
            this.grb_ThongTinHoaDon.Controls.Add(this.label1);
            this.grb_ThongTinHoaDon.Location = new System.Drawing.Point(47, 513);
            this.grb_ThongTinHoaDon.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grb_ThongTinHoaDon.Name = "grb_ThongTinHoaDon";
            this.grb_ThongTinHoaDon.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grb_ThongTinHoaDon.Size = new System.Drawing.Size(349, 304);
            this.grb_ThongTinHoaDon.TabIndex = 2;
            this.grb_ThongTinHoaDon.TabStop = false;
            this.grb_ThongTinHoaDon.Text = "Thông Tin Hóa Đơn";
            // 
            // cbx_product
            // 
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(22, 69);
            this.cbx_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(306, 28);
            this.cbx_product.TabIndex = 17;
            this.cbx_product.SelectedIndexChanged += new System.EventHandler(this.cbx_product_SelectedIndexChanged);
            this.cbx_product.SelectionChangeCommitted += new System.EventHandler(this.cbx_product_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sản Phẩm";
            // 
            // dgv_oders
            // 
            this.dgv_oders.AutoGenerateColumns = false;
            this.dgv_oders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_oders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoaDonDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.nguoiTaoDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn,
            this.tienDuaDataGridViewTextBoxColumn,
            this.tienTraDataGridViewTextBoxColumn});
            this.dgv_oders.DataSource = this.f07QuanLyHoaDonModelBindingSource;
            this.dgv_oders.Location = new System.Drawing.Point(428, 112);
            this.dgv_oders.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgv_oders.Name = "dgv_oders";
            this.dgv_oders.RowHeadersWidth = 51;
            this.dgv_oders.RowTemplate.Height = 24;
            this.dgv_oders.Size = new System.Drawing.Size(1043, 377);
            this.dgv_oders.TabIndex = 18;
            this.dgv_oders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_CellContentClick);
            this.dgv_oders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_CellContentClick);
            // 
            // hoaDonDataGridViewTextBoxColumn
            // 
            this.hoaDonDataGridViewTextBoxColumn.DataPropertyName = "HoaDon";
            this.hoaDonDataGridViewTextBoxColumn.HeaderText = "Hoá Đơn";
            this.hoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoaDonDataGridViewTextBoxColumn.Name = "hoaDonDataGridViewTextBoxColumn";
            this.hoaDonDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // nguoiTaoDataGridViewTextBoxColumn
            // 
            this.nguoiTaoDataGridViewTextBoxColumn.DataPropertyName = "NguoiTao";
            this.nguoiTaoDataGridViewTextBoxColumn.HeaderText = "Người Tạo";
            this.nguoiTaoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nguoiTaoDataGridViewTextBoxColumn.Name = "nguoiTaoDataGridViewTextBoxColumn";
            this.nguoiTaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayTaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Format = "#,###";
            dataGridViewCellStyle2.NullValue = "0";
            this.tongTienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng Tiền";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "Thanh toán";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 150;
            // 
            // tienDuaDataGridViewTextBoxColumn
            // 
            this.tienDuaDataGridViewTextBoxColumn.DataPropertyName = "TienDua";
            dataGridViewCellStyle3.Format = "#,###";
            dataGridViewCellStyle3.NullValue = "0";
            this.tienDuaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tienDuaDataGridViewTextBoxColumn.HeaderText = "Tiền Đưa";
            this.tienDuaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tienDuaDataGridViewTextBoxColumn.Name = "tienDuaDataGridViewTextBoxColumn";
            this.tienDuaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tienTraDataGridViewTextBoxColumn
            // 
            this.tienTraDataGridViewTextBoxColumn.DataPropertyName = "TienTra";
            dataGridViewCellStyle4.Format = "#.###";
            dataGridViewCellStyle4.NullValue = "0";
            this.tienTraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tienTraDataGridViewTextBoxColumn.HeaderText = "Tiền Trả";
            this.tienTraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tienTraDataGridViewTextBoxColumn.Name = "tienTraDataGridViewTextBoxColumn";
            this.tienTraDataGridViewTextBoxColumn.Width = 150;
            // 
            // f07QuanLyHoaDonModelBindingSource
            // 
            this.f07QuanLyHoaDonModelBindingSource.DataSource = typeof(SWarehouse.Models.BillModels.F07_QuanLyHoaDonModel);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(895, 35);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(343, 26);
            this.txt_TimKiem.TabIndex = 20;
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1289, 849);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(183, 59);
            this.btn_close.TabIndex = 26;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(1040, 849);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(183, 59);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(794, 849);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(183, 59);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(1288, 22);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(183, 59);
            this.btn_timkiem.TabIndex = 21;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // F07_QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 1050);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_ThongTinHoaDon);
            this.Controls.Add(this.dgv_orderDetail);
            this.Controls.Add(this.GRB_infototal);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dgv_oders);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "F07_QLHoaDon";
            this.Text = "QLHOADON";
            this.Load += new System.EventHandler(this.F07_QLHoaDon_Load);
            this.GRB_infototal.ResumeLayout(false);
            this.GRB_infototal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f07QuanLyHoaDonChiTietModelBindingSource)).EndInit();
            this.grb_ThongTinHoaDon.ResumeLayout(false);
            this.grb_ThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f07QuanLyHoaDonModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox GRB_infototal;
        private System.Windows.Forms.Label lbl_MKH;
        private System.Windows.Forms.RadioButton rdo_unactive;
        private System.Windows.Forms.RadioButton rdo_active;
        private System.Windows.Forms.DateTimePicker dtp_dateCreate;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_datecreate;
        private System.Windows.Forms.Label lbl_MNV;
        private System.Windows.Forms.GroupBox grb_ThongTinHoaDon;
        private System.Windows.Forms.DataGridView dgv_oders;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.ComboBox cbx_customer;
        private System.Windows.Forms.DataGridView dgv_orderDetail;
        private System.Windows.Forms.ComboBox cbx_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource f07QuanLyHoaDonChiTietModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource f07QuanLyHoaDonModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
    }
}
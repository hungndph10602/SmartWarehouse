namespace SWarehouse.Views
{
    partial class F12_NoteRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F12_NoteRequest));
            this.cbx_matHang = new System.Windows.Forms.ComboBox();
            this.dgvNoteRequestDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_datecreate = new System.Windows.Forms.Label();
            this.grb_ThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.GRB_infototal = new System.Windows.Forms.GroupBox();
            this.cbx_nhanVien = new System.Windows.Forms.ComboBox();
            this.lbl_MNV = new System.Windows.Forms.Label();
            this.Rdo_unactive = new System.Windows.Forms.RadioButton();
            this.Rdo_active = new System.Windows.Forms.RadioButton();
            this.dtp_datecreate = new System.Windows.Forms.DateTimePicker();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_yeuCau = new System.Windows.Forms.DataGridView();
            this.f12NoteRequestModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f12NoteRequestDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteRequestServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuYeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteRequestDetail)).BeginInit();
            this.grb_ThongTinHoaDon.SuspendLayout();
            this.GRB_infototal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f12NoteRequestModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f12NoteRequestDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteRequestServicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_matHang
            // 
            this.cbx_matHang.FormattingEnabled = true;
            this.cbx_matHang.Location = new System.Drawing.Point(20, 55);
            this.cbx_matHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_matHang.Name = "cbx_matHang";
            this.cbx_matHang.Size = new System.Drawing.Size(272, 24);
            this.cbx_matHang.TabIndex = 17;
            this.cbx_matHang.SelectionChangeCommitted += new System.EventHandler(this.cbx_matHang_SelectedValueChanged);
            this.cbx_matHang.SelectedValueChanged += new System.EventHandler(this.cbx_matHang_SelectedValueChanged);
            // 
            // dgvNoteRequestDetail
            // 
            this.dgvNoteRequestDetail.AutoGenerateColumns = false;
            this.dgvNoteRequestDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteRequestDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPhamDataGridViewTextBoxColumn,
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dgvNoteRequestDetail.DataSource = this.f12NoteRequestDetailModelBindingSource;
            this.dgvNoteRequestDetail.Location = new System.Drawing.Point(479, 442);
            this.dgvNoteRequestDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNoteRequestDetail.Name = "dgvNoteRequestDetail";
            this.dgvNoteRequestDetail.RowHeadersWidth = 51;
            this.dgvNoteRequestDetail.RowTemplate.Height = 24;
            this.dgvNoteRequestDetail.Size = new System.Drawing.Size(1068, 207);
            this.dgvNoteRequestDetail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sản Phẩm";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(10, 134);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(78, 17);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Trạng Thái";
            // 
            // lbl_datecreate
            // 
            this.lbl_datecreate.AutoSize = true;
            this.lbl_datecreate.Location = new System.Drawing.Point(10, 75);
            this.lbl_datecreate.Name = "lbl_datecreate";
            this.lbl_datecreate.Size = new System.Drawing.Size(70, 17);
            this.lbl_datecreate.TabIndex = 3;
            this.lbl_datecreate.Text = "Ngày Tạo";
            // 
            // grb_ThongTinHoaDon
            // 
            this.grb_ThongTinHoaDon.Controls.Add(this.cbx_matHang);
            this.grb_ThongTinHoaDon.Controls.Add(this.label1);
            this.grb_ThongTinHoaDon.Location = new System.Drawing.Point(22, 442);
            this.grb_ThongTinHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_ThongTinHoaDon.Name = "grb_ThongTinHoaDon";
            this.grb_ThongTinHoaDon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_ThongTinHoaDon.Size = new System.Drawing.Size(404, 207);
            this.grb_ThongTinHoaDon.TabIndex = 29;
            this.grb_ThongTinHoaDon.TabStop = false;
            this.grb_ThongTinHoaDon.Text = "Thông tin yêu cầu nhập";
            // 
            // GRB_infototal
            // 
            this.GRB_infototal.Controls.Add(this.cbx_nhanVien);
            this.GRB_infototal.Controls.Add(this.lbl_MNV);
            this.GRB_infototal.Controls.Add(this.Rdo_unactive);
            this.GRB_infototal.Controls.Add(this.Rdo_active);
            this.GRB_infototal.Controls.Add(this.dtp_datecreate);
            this.GRB_infototal.Controls.Add(this.lbl_status);
            this.GRB_infototal.Controls.Add(this.lbl_datecreate);
            this.GRB_infototal.Location = new System.Drawing.Point(21, 69);
            this.GRB_infototal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GRB_infototal.Name = "GRB_infototal";
            this.GRB_infototal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GRB_infototal.Size = new System.Drawing.Size(405, 369);
            this.GRB_infototal.TabIndex = 28;
            this.GRB_infototal.TabStop = false;
            this.GRB_infototal.Text = "Thông Tin Chung";
            // 
            // cbx_nhanVien
            // 
            this.cbx_nhanVien.FormattingEnabled = true;
            this.cbx_nhanVien.Location = new System.Drawing.Point(12, 50);
            this.cbx_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_nhanVien.Name = "cbx_nhanVien";
            this.cbx_nhanVien.Size = new System.Drawing.Size(278, 24);
            this.cbx_nhanVien.TabIndex = 29;
            this.cbx_nhanVien.SelectedIndexChanged += new System.EventHandler(this.cbx_nhanVien_SelectionChangeCommitted);
            this.cbx_nhanVien.SelectionChangeCommitted += new System.EventHandler(this.cbx_nhanVien_SelectionChangeCommitted);
            // 
            // lbl_MNV
            // 
            this.lbl_MNV.AutoSize = true;
            this.lbl_MNV.Location = new System.Drawing.Point(10, 29);
            this.lbl_MNV.Name = "lbl_MNV";
            this.lbl_MNV.Size = new System.Drawing.Size(74, 17);
            this.lbl_MNV.TabIndex = 2;
            this.lbl_MNV.Text = "Nhân Viên";
            // 
            // Rdo_unactive
            // 
            this.Rdo_unactive.AutoSize = true;
            this.Rdo_unactive.Location = new System.Drawing.Point(17, 178);
            this.Rdo_unactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rdo_unactive.Name = "Rdo_unactive";
            this.Rdo_unactive.Size = new System.Drawing.Size(145, 21);
            this.Rdo_unactive.TabIndex = 12;
            this.Rdo_unactive.TabStop = true;
            this.Rdo_unactive.Text = "Chưa Hoàn Thành";
            this.Rdo_unactive.UseVisualStyleBackColor = true;
            // 
            // Rdo_active
            // 
            this.Rdo_active.AutoSize = true;
            this.Rdo_active.Location = new System.Drawing.Point(17, 153);
            this.Rdo_active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rdo_active.Name = "Rdo_active";
            this.Rdo_active.Size = new System.Drawing.Size(130, 21);
            this.Rdo_active.TabIndex = 11;
            this.Rdo_active.TabStop = true;
            this.Rdo_active.Text = "Đã Hoàn Thành";
            this.Rdo_active.UseVisualStyleBackColor = true;
            this.Rdo_active.CheckedChanged += new System.EventHandler(this.Rdo_active_CheckedChanged);
            // 
            // dtp_datecreate
            // 
            this.dtp_datecreate.CustomFormat = "dd/MM/yyy";
            this.dtp_datecreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datecreate.Location = new System.Drawing.Point(13, 94);
            this.dtp_datecreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_datecreate.Name = "dtp_datecreate";
            this.dtp_datecreate.Size = new System.Drawing.Size(275, 22);
            this.dtp_datecreate.TabIndex = 10;
            this.dtp_datecreate.CloseUp += new System.EventHandler(this.dtp_datecreate_CloseUp);
            this.dtp_datecreate.ValueChanged += new System.EventHandler(this.dtp_datecreate_CloseUp);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(477, 55);
            this.lbl_title.TabIndex = 27;
            this.lbl_title.Text = "Phiếu Yêu Cầu Nhập";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(635, 26);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(305, 22);
            this.txt_TimKiem.TabIndex = 30;
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1384, 666);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(163, 46);
            this.btn_close.TabIndex = 36;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(1165, 666);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(163, 46);
            this.btn_edit.TabIndex = 33;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(943, 666);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(163, 46);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(985, 15);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(163, 46);
            this.btn_timkiem.TabIndex = 31;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(476, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "nháy đúp chuột để chuyển trạng thái phiếu yêu cầu";
            // 
            // dgv_yeuCau
            // 
            this.dgv_yeuCau.AutoGenerateColumns = false;
            this.dgv_yeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yeuCau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuYeuCauDataGridViewTextBoxColumn,
            this.nhanVienDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgv_yeuCau.DataSource = this.f12NoteRequestModelBindingSource;
            this.dgv_yeuCau.Location = new System.Drawing.Point(479, 80);
            this.dgv_yeuCau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_yeuCau.Name = "dgv_yeuCau";
            this.dgv_yeuCau.RowHeadersWidth = 51;
            this.dgv_yeuCau.RowTemplate.Height = 24;
            this.dgv_yeuCau.Size = new System.Drawing.Size(1068, 339);
            this.dgv_yeuCau.TabIndex = 38;
            this.dgv_yeuCau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_yeuCau_CellContentClick_1);
            this.dgv_yeuCau.DoubleClick += new System.EventHandler(this.dgv_yeuCau_DoubleClick_1);
            // 
            // f12NoteRequestModelBindingSource
            // 
            this.f12NoteRequestModelBindingSource.DataSource = typeof(SWarehouse.Models.NoteRequestModels.F12_NoteRequestModel);
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            this.maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            this.maSanPhamDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            this.tenSanPhamDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // f12NoteRequestDetailModelBindingSource
            // 
            this.f12NoteRequestDetailModelBindingSource.DataSource = typeof(SWarehouse.Models.NoteRequestModels.F12_NoteRequestDetailModel);
            // 
            // noteRequestServicesBindingSource
            // 
            this.noteRequestServicesBindingSource.DataSource = typeof(SWarehouse.Controllers.NoteRequestServices.NoteRequestServices);
            // 
            // phieuYeuCauDataGridViewTextBoxColumn
            // 
            this.phieuYeuCauDataGridViewTextBoxColumn.DataPropertyName = "PhieuYeuCau";
            this.phieuYeuCauDataGridViewTextBoxColumn.HeaderText = "Phiếu Yêu Cầu";
            this.phieuYeuCauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phieuYeuCauDataGridViewTextBoxColumn.Name = "phieuYeuCauDataGridViewTextBoxColumn";
            this.phieuYeuCauDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienDataGridViewTextBoxColumn
            // 
            this.nhanVienDataGridViewTextBoxColumn.DataPropertyName = "NhanVien";
            this.nhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân Viên";
            this.nhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhanVienDataGridViewTextBoxColumn.Name = "nhanVienDataGridViewTextBoxColumn";
            this.nhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // F12_NoteRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 741);
            this.Controls.Add(this.dgv_yeuCau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgvNoteRequestDetail);
            this.Controls.Add(this.grb_ThongTinHoaDon);
            this.Controls.Add(this.GRB_infototal);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_timkiem);
            this.Name = "F12_NoteRequest";
            this.Text = "F12_NoteRequest";
            this.Load += new System.EventHandler(this.F12_NoteRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteRequestDetail)).EndInit();
            this.grb_ThongTinHoaDon.ResumeLayout(false);
            this.grb_ThongTinHoaDon.PerformLayout();
            this.GRB_infototal.ResumeLayout(false);
            this.GRB_infototal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f12NoteRequestModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f12NoteRequestDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteRequestServicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbx_matHang;
        private System.Windows.Forms.DataGridView dgvNoteRequestDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_datecreate;
        private System.Windows.Forms.GroupBox grb_ThongTinHoaDon;
        private System.Windows.Forms.GroupBox GRB_infototal;
        private System.Windows.Forms.Label lbl_MNV;
        private System.Windows.Forms.RadioButton Rdo_unactive;
        private System.Windows.Forms.RadioButton Rdo_active;
        private System.Windows.Forms.DateTimePicker dtp_datecreate;
        private System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.ComboBox cbx_nhanVien;
        private System.Windows.Forms.BindingSource noteRequestServicesBindingSource;
        private System.Windows.Forms.BindingSource f12NoteRequestDetailModelBindingSource;
        private System.Windows.Forms.BindingSource f12NoteRequestModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_yeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuYeuCauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
    }
}
namespace SmartWareHouse
{
    partial class F09_QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F09_QLNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_QLNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txt_urd = new System.Windows.Forms.TextBox();
            this.PB_imgstaff = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_idstaff = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_active = new System.Windows.Forms.RadioButton();
            this.rdo_unactive = new System.Windows.Forms.RadioButton();
            this.RTB_adress = new System.Windows.Forms.RichTextBox();
            this.txt_numberphone = new System.Windows.Forms.TextBox();
            this.txt_nameStaff = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_numberphone = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_TNV = new System.Windows.Forms.Label();
            this.lbl_emailNV = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_QLNV = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.f09QLNhanVienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imgstaff)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f09QLNhanVienModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QLNV
            // 
            this.lbl_QLNV.AutoSize = true;
            this.lbl_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLNV.Location = new System.Drawing.Point(23, 9);
            this.lbl_QLNV.Name = "lbl_QLNV";
            this.lbl_QLNV.Size = new System.Drawing.Size(430, 55);
            this.lbl_QLNV.TabIndex = 0;
            this.lbl_QLNV.Text = "Quản Lí Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_upload);
            this.groupBox1.Controls.Add(this.txt_urd);
            this.groupBox1.Controls.Add(this.PB_imgstaff);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.lbl_idstaff);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.RTB_adress);
            this.groupBox1.Controls.Add(this.txt_numberphone);
            this.groupBox1.Controls.Add(this.txt_nameStaff);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.lbl_numberphone);
            this.groupBox1.Controls.Add(this.lbl_adress);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.lbl_TNV);
            this.groupBox1.Controls.Add(this.lbl_emailNV);
            this.groupBox1.Location = new System.Drawing.Point(25, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 604);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // btn_upload
            // 
            this.btn_upload.Image = global::SWarehouse.Properties.Resources.up_arrow;
            this.btn_upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_upload.Location = new System.Drawing.Point(374, 453);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(118, 60);
            this.btn_upload.TabIndex = 54;
            this.btn_upload.Text = "Tải Lên";
            this.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txt_urd
            // 
            this.txt_urd.Location = new System.Drawing.Point(46, 453);
            this.txt_urd.Name = "txt_urd";
            this.txt_urd.Size = new System.Drawing.Size(121, 22);
            this.txt_urd.TabIndex = 55;
            // 
            // PB_imgstaff
            // 
            this.PB_imgstaff.ErrorImage = global::SWarehouse.Properties.Resources.user;
            this.PB_imgstaff.Location = new System.Drawing.Point(191, 453);
            this.PB_imgstaff.Name = "PB_imgstaff";
            this.PB_imgstaff.Size = new System.Drawing.Size(177, 145);
            this.PB_imgstaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_imgstaff.TabIndex = 48;
            this.PB_imgstaff.TabStop = false;
            this.PB_imgstaff.Click += new System.EventHandler(this.PB_imgstaff_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(191, 35);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(284, 22);
            this.txt_username.TabIndex = 47;
            // 
            // lbl_idstaff
            // 
            this.lbl_idstaff.AutoSize = true;
            this.lbl_idstaff.Location = new System.Drawing.Point(43, 35);
            this.lbl_idstaff.Name = "lbl_idstaff";
            this.lbl_idstaff.Size = new System.Drawing.Size(109, 17);
            this.lbl_idstaff.TabIndex = 46;
            this.lbl_idstaff.Text = "Tên Đăng Nhập";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(188, 409);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(284, 22);
            this.txt_salary.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Lương";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_active);
            this.panel1.Controls.Add(this.rdo_unactive);
            this.panel1.Location = new System.Drawing.Point(188, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 54);
            this.panel1.TabIndex = 2;
            // 
            // rdo_active
            // 
            this.rdo_active.AutoSize = true;
            this.rdo_active.Location = new System.Drawing.Point(3, 2);
            this.rdo_active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_active.Name = "rdo_active";
            this.rdo_active.Size = new System.Drawing.Size(97, 21);
            this.rdo_active.TabIndex = 14;
            this.rdo_active.TabStop = true;
            this.rdo_active.Text = "Hoạt Động";
            this.rdo_active.UseVisualStyleBackColor = true;
            // 
            // rdo_unactive
            // 
            this.rdo_unactive.AutoSize = true;
            this.rdo_unactive.Location = new System.Drawing.Point(125, 2);
            this.rdo_unactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_unactive.Name = "rdo_unactive";
            this.rdo_unactive.Size = new System.Drawing.Size(143, 21);
            this.rdo_unactive.TabIndex = 15;
            this.rdo_unactive.TabStop = true;
            this.rdo_unactive.Text = "Ngừng Hoạt Động";
            this.rdo_unactive.UseVisualStyleBackColor = true;
            // 
            // RTB_adress
            // 
            this.RTB_adress.Location = new System.Drawing.Point(189, 254);
            this.RTB_adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTB_adress.Name = "RTB_adress";
            this.RTB_adress.Size = new System.Drawing.Size(284, 83);
            this.RTB_adress.TabIndex = 3;
            this.RTB_adress.Text = "";
            // 
            // txt_numberphone
            // 
            this.txt_numberphone.Location = new System.Drawing.Point(188, 358);
            this.txt_numberphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numberphone.Name = "txt_numberphone";
            this.txt_numberphone.Size = new System.Drawing.Size(284, 22);
            this.txt_numberphone.TabIndex = 4;
            // 
            // txt_nameStaff
            // 
            this.txt_nameStaff.Location = new System.Drawing.Point(189, 116);
            this.txt_nameStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nameStaff.Name = "txt_nameStaff";
            this.txt_nameStaff.Size = new System.Drawing.Size(284, 22);
            this.txt_nameStaff.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(191, 69);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 22);
            this.txt_email.TabIndex = 0;
            // 
            // lbl_numberphone
            // 
            this.lbl_numberphone.AutoSize = true;
            this.lbl_numberphone.Location = new System.Drawing.Point(43, 358);
            this.lbl_numberphone.Name = "lbl_numberphone";
            this.lbl_numberphone.Size = new System.Drawing.Size(98, 17);
            this.lbl_numberphone.TabIndex = 37;
            this.lbl_numberphone.Text = "Số Điện Thoại";
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(43, 254);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(53, 17);
            this.lbl_adress.TabIndex = 36;
            this.lbl_adress.Text = "Địa Chỉ";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(43, 175);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(78, 17);
            this.lbl_Status.TabIndex = 35;
            this.lbl_Status.Text = "Trạng Thái";
            // 
            // lbl_TNV
            // 
            this.lbl_TNV.AutoSize = true;
            this.lbl_TNV.Location = new System.Drawing.Point(38, 121);
            this.lbl_TNV.Name = "lbl_TNV";
            this.lbl_TNV.Size = new System.Drawing.Size(103, 17);
            this.lbl_TNV.TabIndex = 34;
            this.lbl_TNV.Text = "Tên Nhân Viên";
            // 
            // lbl_emailNV
            // 
            this.lbl_emailNV.AutoSize = true;
            this.lbl_emailNV.Location = new System.Drawing.Point(43, 74);
            this.lbl_emailNV.Name = "lbl_emailNV";
            this.lbl_emailNV.Size = new System.Drawing.Size(42, 17);
            this.lbl_emailNV.TabIndex = 33;
            this.lbl_emailNV.Text = "Email";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(801, 37);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(305, 22);
            this.txt_Search.TabIndex = 47;
            // 
            // dgv_QLNV
            // 
            this.dgv_QLNV.AllowUserToAddRows = false;
            this.dgv_QLNV.AllowUserToDeleteRows = false;
            this.dgv_QLNV.AutoGenerateColumns = false;
            this.dgv_QLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendangnhap,
            this.email,
            this.tennhanvien,
            this.roleDataGridViewTextBoxColumn,
            this.trangthai,
            this.diachi,
            this.sdt,
            this.luong,
            this.hinhanh});
            this.dgv_QLNV.DataSource = this.f09QLNhanVienModelBindingSource;
            this.dgv_QLNV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_QLNV.Location = new System.Drawing.Point(583, 87);
            this.dgv_QLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_QLNV.Name = "dgv_QLNV";
            this.dgv_QLNV.RowHeadersWidth = 51;
            this.dgv_QLNV.RowTemplate.Height = 24;
            this.dgv_QLNV.Size = new System.Drawing.Size(908, 578);
            this.dgv_QLNV.TabIndex = 45;
            this.dgv_QLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLNV_CellContentClick);
            this.dgv_QLNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLNV_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1328, 684);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(163, 46);
            this.btn_close.TabIndex = 53;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::SWarehouse.Properties.Resources.search;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1112, 25);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(163, 46);
            this.btn_Search.TabIndex = 48;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(1128, 684);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(163, 46);
            this.btn_edit.TabIndex = 50;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(927, 684);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(163, 46);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Image = global::SWarehouse.Properties.Resources.plus;
            this.btn_createAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createAccount.Location = new System.Drawing.Point(1328, 25);
            this.btn_createAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(163, 46);
            this.btn_createAccount.TabIndex = 54;
            this.btn_createAccount.Text = "Tạo Tài Khoản";
            this.btn_createAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // f09QLNhanVienModelBindingSource
            // 
            this.f09QLNhanVienModelBindingSource.DataSource = typeof(SWarehouse.Models.StaffModels.F09__QLNhanVienModel);
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "TenDangNhap";
            this.tendangnhap.HeaderText = "Tên Đăng Nhập";
            this.tendangnhap.MinimumWidth = 6;
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // tennhanvien
            // 
            this.tennhanvien.DataPropertyName = "TenNhanVien";
            this.tennhanvien.HeaderText = "Tên Nhân Viên";
            this.tennhanvien.MinimumWidth = 6;
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "Luong";
            dataGridViewCellStyle1.Format = "#,###";
            dataGridViewCellStyle1.NullValue = "0";
            this.luong.DefaultCellStyle = dataGridViewCellStyle1;
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.Width = 125;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "Img";
            this.hinhanh.HeaderText = "Hình Ảnh";
            this.hinhanh.MinimumWidth = 6;
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Width = 125;
            // 
            // F09_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 741);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_QLNV);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_QLNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F09_QLNhanVien";
            this.Text = "QLNHANVIEN";
            this.Load += new System.EventHandler(this.F09_QLNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imgstaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f09QLNhanVienModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QLNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dgv_QLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo_active;
        private System.Windows.Forms.RadioButton rdo_unactive;
        private System.Windows.Forms.RichTextBox RTB_adress;
        private System.Windows.Forms.TextBox txt_numberphone;
        private System.Windows.Forms.TextBox txt_nameStaff;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_numberphone;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_TNV;
        private System.Windows.Forms.Label lbl_emailNV;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_idstaff;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox PB_imgstaff;
        private System.Windows.Forms.TextBox txt_urd;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource f09QLNhanVienModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
    }
}
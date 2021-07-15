namespace SWarehouse.Views
{
    partial class F04_QLKhachHang
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
            this.lbl_QuanLyKhachHang = new System.Windows.Forms.Label();
            this.grb_ThôngTinChung = new System.Windows.Forms.GroupBox();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.f04QLKhachHangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ThôngTinChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f04QLKhachHangModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QuanLyKhachHang
            // 
            this.lbl_QuanLyKhachHang.AutoSize = true;
            this.lbl_QuanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyKhachHang.Location = new System.Drawing.Point(94, 9);
            this.lbl_QuanLyKhachHang.Name = "lbl_QuanLyKhachHang";
            this.lbl_QuanLyKhachHang.Size = new System.Drawing.Size(485, 55);
            this.lbl_QuanLyKhachHang.TabIndex = 0;
            this.lbl_QuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.lbl_QuanLyKhachHang.Click += new System.EventHandler(this.lbl_QuanLyKhachHang_Click);
            // 
            // grb_ThôngTinChung
            // 
            this.grb_ThôngTinChung.Controls.Add(this.dgv_customer);
            this.grb_ThôngTinChung.Location = new System.Drawing.Point(104, 77);
            this.grb_ThôngTinChung.Name = "grb_ThôngTinChung";
            this.grb_ThôngTinChung.Size = new System.Drawing.Size(1269, 603);
            this.grb_ThôngTinChung.TabIndex = 1;
            this.grb_ThôngTinChung.TabStop = false;
            this.grb_ThôngTinChung.Text = "Thông Tin Chung";
            this.grb_ThôngTinChung.Enter += new System.EventHandler(this.grb_ThôngTinChung_Enter);
            // 
            // dgv_customer
            // 
            this.dgv_customer.AutoGenerateColumns = false;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.TenKhachHang,
            this.DienThoai,
            this.dataGridViewTextBoxColumn3});
            this.dgv_customer.DataSource = this.f04QLKhachHangModelBindingSource;
            this.dgv_customer.Location = new System.Drawing.Point(21, 21);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 24;
            this.dgv_customer.Size = new System.Drawing.Size(1201, 562);
            this.dgv_customer.TabIndex = 4;
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(1164, 684);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(162, 45);
            this.btn_Dong.TabIndex = 12;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::SWarehouse.Properties.Resources.edit;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(954, 684);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(162, 45);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::SWarehouse.Properties.Resources.plus;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(740, 684);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(162, 45);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(828, 37);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(242, 22);
            this.txt_TimKiem.TabIndex = 6;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::SWarehouse.Properties.Resources.search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(1120, 26);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(162, 45);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // f04QLKhachHangModelBindingSource
            // 
            this.f04QLKhachHangModelBindingSource.DataSource = typeof(SWarehouse.Models.CustomerModels.F04_QLKhachHangModel);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Thứ Tự Khách Hàng";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Số Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // F04_QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 741);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.grb_ThôngTinChung);
            this.Controls.Add(this.lbl_QuanLyKhachHang);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Name = "F04_QLKhachHang";
            this.Text = "QLKhachHang";
            this.Load += new System.EventHandler(this.F04_QLKhachHang_Load);
            this.grb_ThôngTinChung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f04QLKhachHangModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QuanLyKhachHang;
        private System.Windows.Forms.GroupBox grb_ThôngTinChung;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource f04QLKhachHangModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
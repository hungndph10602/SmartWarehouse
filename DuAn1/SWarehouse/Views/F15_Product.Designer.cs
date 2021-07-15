namespace SWarehouse.Views
{
    partial class F15_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F15_Product));
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_thongTinChung = new System.Windows.Forms.GroupBox();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_urd = new System.Windows.Forms.TextBox();
            this.btn_listData = new System.Windows.Forms.Button();
            this.productModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userManualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_thongTinChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(444, 55);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "Quản Lý Sản Phẩm";
            // 
            // grb_thongTinChung
            // 
            this.grb_thongTinChung.Controls.Add(this.dgv_product);
            this.grb_thongTinChung.Location = new System.Drawing.Point(21, 85);
            this.grb_thongTinChung.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grb_thongTinChung.Name = "grb_thongTinChung";
            this.grb_thongTinChung.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grb_thongTinChung.Size = new System.Drawing.Size(1637, 548);
            this.grb_thongTinChung.TabIndex = 9;
            this.grb_thongTinChung.TabStop = false;
            this.grb_thongTinChung.Text = "Thông Tin Sản Phẩm";
            // 
            // dgv_product
            // 
            this.dgv_product.AutoGenerateColumns = false;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.shortDescriptionDataGridViewTextBoxColumn,
            this.longDescriptionDataGridViewTextBoxColumn,
            this.userManualDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgv_product.DataSource = this.productModelsBindingSource;
            this.dgv_product.Location = new System.Drawing.Point(-25, 33);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(1373, 475);
            this.dgv_product.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(931, 38);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(241, 22);
            this.txt_search.TabIndex = 45;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::SWarehouse.Properties.Resources.plus;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(795, 671);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(163, 46);
            this.btn_Them.TabIndex = 47;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::SWarehouse.Properties.Resources.edit;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(1008, 671);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(163, 46);
            this.btn_Sua.TabIndex = 48;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(1219, 671);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(163, 46);
            this.btn_Dong.TabIndex = 49;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(1217, 27);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(163, 47);
            this.btn_timkiem.TabIndex = 46;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_urd
            // 
            this.txt_urd.Location = new System.Drawing.Point(467, 685);
            this.txt_urd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urd.Name = "txt_urd";
            this.txt_urd.Size = new System.Drawing.Size(132, 22);
            this.txt_urd.TabIndex = 50;
            // 
            // btn_listData
            // 
            this.btn_listData.Image = global::SWarehouse.Properties.Resources.checklists;
            this.btn_listData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listData.Location = new System.Drawing.Point(628, 671);
            this.btn_listData.Margin = new System.Windows.Forms.Padding(4);
            this.btn_listData.Name = "btn_listData";
            this.btn_listData.Size = new System.Drawing.Size(143, 46);
            this.btn_listData.TabIndex = 51;
            this.btn_listData.Text = "Danh Sách";
            this.btn_listData.UseVisualStyleBackColor = true;
            this.btn_listData.Click += new System.EventHandler(this.btn_listData_Click);
            // 
            // productModelsBindingSource
            // 
            this.productModelsBindingSource.DataSource = typeof(SWarehouse.Models.ProductModels.ProductModels);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "unitName";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "Đơn Vị";
            this.unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            this.unitNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "colorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "Màu";
            this.colorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "brandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Nhãn Hiệu";
            this.brandNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Hình Ảnh";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // shortDescriptionDataGridViewTextBoxColumn
            // 
            this.shortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.HeaderText = "Mô Tả Ngắn";
            this.shortDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortDescriptionDataGridViewTextBoxColumn.Name = "shortDescriptionDataGridViewTextBoxColumn";
            this.shortDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // longDescriptionDataGridViewTextBoxColumn
            // 
            this.longDescriptionDataGridViewTextBoxColumn.DataPropertyName = "LongDescription";
            this.longDescriptionDataGridViewTextBoxColumn.HeaderText = "Mô Tả Dài";
            this.longDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longDescriptionDataGridViewTextBoxColumn.Name = "longDescriptionDataGridViewTextBoxColumn";
            this.longDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // userManualDataGridViewTextBoxColumn
            // 
            this.userManualDataGridViewTextBoxColumn.DataPropertyName = "UserManual";
            this.userManualDataGridViewTextBoxColumn.HeaderText = "Hướng Dẫn Sử Dụng";
            this.userManualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userManualDataGridViewTextBoxColumn.Name = "userManualDataGridViewTextBoxColumn";
            this.userManualDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // F15_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 741);
            this.Controls.Add(this.btn_listData);
            this.Controls.Add(this.txt_urd);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.grb_thongTinChung);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F15_Product";
            this.Text = "F15_Product";
            this.grb_thongTinChung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.GroupBox grb_thongTinChung;
        private System.Windows.Forms.DataGridView dgv_product;
        public System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.TextBox txt_urd;
        private System.Windows.Forms.Button btn_listData;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userManualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productModelsBindingSource;
    }
}
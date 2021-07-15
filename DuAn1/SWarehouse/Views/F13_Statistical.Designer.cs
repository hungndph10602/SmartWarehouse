namespace SWarehouse.Views
{
    partial class F13_Statistical
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
            this.dgv_CustomerStatistical = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.CustomerStatus = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.sPGetCustomerStatisticalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sWarehouseDBDataSet = new SWarehouse.SWarehouseDBDataSet();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tct_thongke = new System.Windows.Forms.TabControl();
            this.tbp_Customer = new System.Windows.Forms.TabPage();
            this.tbp_product = new System.Windows.Forms.TabPage();
            this.dgv_productStatistical = new System.Windows.Forms.DataGridView();
            this.sPGetProductStatisticalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_statistial = new System.Windows.Forms.Label();
            this.sP_GetCustomerStatisticalTableAdapter = new SWarehouse.SWarehouseDBDataSetTableAdapters.SP_GetCustomerStatisticalTableAdapter();
            this.sP_GetProductStatisticalTableAdapter = new SWarehouse.SWarehouseDBDataSetTableAdapters.SP_GetProductStatisticalTableAdapter();
            this.ProductId = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ProductName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.BrandName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Price = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Quantity = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ProductStatus = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerStatistical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetCustomerStatisticalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWarehouseDBDataSet)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tct_thongke.SuspendLayout();
            this.tbp_Customer.SuspendLayout();
            this.tbp_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productStatistical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetProductStatisticalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CustomerStatistical
            // 
            this.dgv_CustomerStatistical.AllowUserToAddRows = false;
            this.dgv_CustomerStatistical.AllowUserToDeleteRows = false;
            this.dgv_CustomerStatistical.AutoGenerateColumns = false;
            this.dgv_CustomerStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerStatistical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.CustomerStatus});
            this.dgv_CustomerStatistical.DataSource = this.sPGetCustomerStatisticalBindingSource;
            this.dgv_CustomerStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CustomerStatistical.Location = new System.Drawing.Point(4, 5);
            this.dgv_CustomerStatistical.Name = "dgv_CustomerStatistical";
            this.dgv_CustomerStatistical.ReadOnly = true;
            this.dgv_CustomerStatistical.RowHeadersWidth = 62;
            this.dgv_CustomerStatistical.RowTemplate.Height = 28;
            this.dgv_CustomerStatistical.Size = new System.Drawing.Size(1468, 615);
            this.dgv_CustomerStatistical.TabIndex = 0;
            this.dgv_CustomerStatistical.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dgv_CustomerStatistical.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã Khách Hàng";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CustomerStatus
            // 
            this.CustomerStatus.DataPropertyName = "Status";
            this.CustomerStatus.HeaderText = "Trạng Thái";
            this.CustomerStatus.Name = "CustomerStatus";
            this.CustomerStatus.ReadOnly = true;
            this.CustomerStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sPGetCustomerStatisticalBindingSource
            // 
            this.sPGetCustomerStatisticalBindingSource.DataMember = "SP_GetCustomerStatistical";
            this.sPGetCustomerStatisticalBindingSource.DataSource = this.sWarehouseDBDataSet;
            // 
            // sWarehouseDBDataSet
            // 
            this.sWarehouseDBDataSet.DataSetName = "SWarehouseDBDataSet";
            this.sWarehouseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAllLabel,
            this.filterStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 769);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1502, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // ShowAllLabel
            // 
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(53, 17);
            this.ShowAllLabel.Text = "Show &All";
            this.ShowAllLabel.Click += new System.EventHandler(this.showAllLabel_Click);
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tct_thongke
            // 
            this.tct_thongke.Controls.Add(this.tbp_Customer);
            this.tct_thongke.Controls.Add(this.tbp_product);
            this.tct_thongke.Location = new System.Drawing.Point(18, 95);
            this.tct_thongke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tct_thongke.Name = "tct_thongke";
            this.tct_thongke.SelectedIndex = 0;
            this.tct_thongke.Size = new System.Drawing.Size(1484, 658);
            this.tct_thongke.TabIndex = 2;
            // 
            // tbp_Customer
            // 
            this.tbp_Customer.Controls.Add(this.dgv_CustomerStatistical);
            this.tbp_Customer.Location = new System.Drawing.Point(4, 29);
            this.tbp_Customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_Customer.Name = "tbp_Customer";
            this.tbp_Customer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_Customer.Size = new System.Drawing.Size(1476, 625);
            this.tbp_Customer.TabIndex = 0;
            this.tbp_Customer.Text = "Thống Kê Khách Hàng";
            this.tbp_Customer.UseVisualStyleBackColor = true;
            // 
            // tbp_product
            // 
            this.tbp_product.Controls.Add(this.dgv_productStatistical);
            this.tbp_product.Location = new System.Drawing.Point(4, 29);
            this.tbp_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_product.Name = "tbp_product";
            this.tbp_product.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbp_product.Size = new System.Drawing.Size(1476, 625);
            this.tbp_product.TabIndex = 1;
            this.tbp_product.Text = "Thống Kê Sản Phẩm";
            this.tbp_product.UseVisualStyleBackColor = true;
            // 
            // dgv_productStatistical
            // 
            this.dgv_productStatistical.AllowUserToAddRows = false;
            this.dgv_productStatistical.AllowUserToDeleteRows = false;
            this.dgv_productStatistical.AutoGenerateColumns = false;
            this.dgv_productStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productStatistical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.BrandName,
            this.Price,
            this.Quantity,
            this.ProductStatus});
            this.dgv_productStatistical.DataSource = this.sPGetProductStatisticalBindingSource;
            this.dgv_productStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productStatistical.Location = new System.Drawing.Point(4, 5);
            this.dgv_productStatistical.Name = "dgv_productStatistical";
            this.dgv_productStatistical.RowHeadersWidth = 62;
            this.dgv_productStatistical.RowTemplate.Height = 28;
            this.dgv_productStatistical.Size = new System.Drawing.Size(1468, 615);
            this.dgv_productStatistical.TabIndex = 1;
            this.dgv_productStatistical.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_productStatistical_CellFormatting);
            // 
            // sPGetProductStatisticalBindingSource
            // 
            this.sPGetProductStatisticalBindingSource.DataMember = "SP_GetProductStatistical";
            this.sPGetProductStatisticalBindingSource.DataSource = this.sWarehouseDBDataSet;
            // 
            // lbl_statistial
            // 
            this.lbl_statistial.AutoSize = true;
            this.lbl_statistial.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_statistial.Location = new System.Drawing.Point(24, 20);
            this.lbl_statistial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_statistial.Name = "lbl_statistial";
            this.lbl_statistial.Size = new System.Drawing.Size(194, 46);
            this.lbl_statistial.TabIndex = 3;
            this.lbl_statistial.Text = "Thống kê";
            // 
            // sP_GetCustomerStatisticalTableAdapter
            // 
            this.sP_GetCustomerStatisticalTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GetProductStatisticalTableAdapter
            // 
            this.sP_GetProductStatisticalTableAdapter.ClearBeforeFill = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Mã Sản Phẩm";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "Thương Hiệu";
            this.BrandName.Name = "BrandName";
            this.BrandName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá Bán";
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ProductStatus
            // 
            this.ProductStatus.DataPropertyName = "Status";
            this.ProductStatus.HeaderText = "Trạng Thái";
            this.ProductStatus.Name = "ProductStatus";
            this.ProductStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // F13_Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 791);
            this.Controls.Add(this.lbl_statistial);
            this.Controls.Add(this.tct_thongke);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F13_Statistical";
            this.Text = "F13_Statistical";
            this.Load += new System.EventHandler(this.F13_Statistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerStatistical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetCustomerStatisticalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWarehouseDBDataSet)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tct_thongke.ResumeLayout(false);
            this.tbp_Customer.ResumeLayout(false);
            this.tbp_product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productStatistical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetProductStatisticalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CustomerStatistical;
        private System.Windows.Forms.StatusStrip statusStrip;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn productIDColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn productColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn brandColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn priceColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn quantityColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn statusColumn;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.ToolStripStatusLabel filterStatusLabel;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn IDColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn NameColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn PhoneColum;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn EmailColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn statusCollumn;
        private System.Windows.Forms.TabControl tct_thongke;
        private System.Windows.Forms.TabPage tbp_Customer;
        private System.Windows.Forms.TabPage tbp_product;
        private System.Windows.Forms.Label lbl_statistial;
        private SWarehouseDBDataSet sWarehouseDBDataSet;
        private System.Windows.Forms.BindingSource sPGetCustomerStatisticalBindingSource;
        private SWarehouseDBDataSetTableAdapters.SP_GetCustomerStatisticalTableAdapter sP_GetCustomerStatisticalTableAdapter;
        private System.Windows.Forms.BindingSource sPGetProductStatisticalBindingSource;
        private SWarehouseDBDataSetTableAdapters.SP_GetProductStatisticalTableAdapter sP_GetProductStatisticalTableAdapter;
        private System.Windows.Forms.DataGridView dgv_productStatistical;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn CustomerStatus;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ProductId;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ProductName;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn BrandName;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Price;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Quantity;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ProductStatus;
    }
}
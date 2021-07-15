namespace SWarehouse.Dialog
{
    partial class D05_AddGDNDetailDialog
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
            this.grb_ChiTietPhieuXuat = new System.Windows.Forms.GroupBox();
            this.nud_least = new System.Windows.Forms.NumericUpDown();
            this.lbl_least = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrActualAmount = new System.Windows.Forms.NumericUpDown();
            this.nmrRequestAmount = new System.Windows.Forms.NumericUpDown();
            this.lbl_SoLuongXuatThuc = new System.Windows.Forms.Label();
            this.lbl_SoLuongXuat = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvDetailGDN = new System.Windows.Forms.DataGridView();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.sanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongXuatThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f06QLXuatKhoChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_ChiTietPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_least)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrActualAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRequestAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailGDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f06QLXuatKhoChiTietBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_ChiTietPhieuXuat
            // 
            this.grb_ChiTietPhieuXuat.Controls.Add(this.nud_least);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.lbl_least);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.cboProduct);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.label1);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.nmrActualAmount);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.nmrRequestAmount);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.lbl_SoLuongXuatThuc);
            this.grb_ChiTietPhieuXuat.Controls.Add(this.lbl_SoLuongXuat);
            this.grb_ChiTietPhieuXuat.Location = new System.Drawing.Point(9, 9);
            this.grb_ChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.grb_ChiTietPhieuXuat.Name = "grb_ChiTietPhieuXuat";
            this.grb_ChiTietPhieuXuat.Padding = new System.Windows.Forms.Padding(2);
            this.grb_ChiTietPhieuXuat.Size = new System.Drawing.Size(370, 170);
            this.grb_ChiTietPhieuXuat.TabIndex = 2;
            this.grb_ChiTietPhieuXuat.TabStop = false;
            this.grb_ChiTietPhieuXuat.Text = "Chi Tiết Phiếu Xuất";
            this.grb_ChiTietPhieuXuat.Enter += new System.EventHandler(this.grb_ChiTietPhieuXuat_Enter);
            // 
            // nud_least
            // 
            this.nud_least.Enabled = false;
            this.nud_least.Location = new System.Drawing.Point(131, 129);
            this.nud_least.Margin = new System.Windows.Forms.Padding(2);
            this.nud_least.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_least.Name = "nud_least";
            this.nud_least.ReadOnly = true;
            this.nud_least.Size = new System.Drawing.Size(162, 20);
            this.nud_least.TabIndex = 19;
            // 
            // lbl_least
            // 
            this.lbl_least.AutoSize = true;
            this.lbl_least.Location = new System.Drawing.Point(17, 136);
            this.lbl_least.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_least.Name = "lbl_least";
            this.lbl_least.Size = new System.Drawing.Size(88, 13);
            this.lbl_least.TabIndex = 18;
            this.lbl_least.Text = "Số lượng tồn kho";
            // 
            // cboProduct
            // 
            this.cboProduct.Enabled = false;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(130, 32);
            this.cboProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(163, 21);
            this.cboProduct.TabIndex = 17;
            this.cboProduct.TextChanged += new System.EventHandler(this.cboProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sản Phẩm";
            // 
            // nmrActualAmount
            // 
            this.nmrActualAmount.Location = new System.Drawing.Point(131, 100);
            this.nmrActualAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nmrActualAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrActualAmount.Name = "nmrActualAmount";
            this.nmrActualAmount.Size = new System.Drawing.Size(162, 20);
            this.nmrActualAmount.TabIndex = 8;
            // 
            // nmrRequestAmount
            // 
            this.nmrRequestAmount.Enabled = false;
            this.nmrRequestAmount.Location = new System.Drawing.Point(130, 67);
            this.nmrRequestAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nmrRequestAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrRequestAmount.Name = "nmrRequestAmount";
            this.nmrRequestAmount.ReadOnly = true;
            this.nmrRequestAmount.Size = new System.Drawing.Size(162, 20);
            this.nmrRequestAmount.TabIndex = 7;
            // 
            // lbl_SoLuongXuatThuc
            // 
            this.lbl_SoLuongXuatThuc.AutoSize = true;
            this.lbl_SoLuongXuatThuc.Location = new System.Drawing.Point(14, 100);
            this.lbl_SoLuongXuatThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuongXuatThuc.Name = "lbl_SoLuongXuatThuc";
            this.lbl_SoLuongXuatThuc.Size = new System.Drawing.Size(106, 13);
            this.lbl_SoLuongXuatThuc.TabIndex = 5;
            this.lbl_SoLuongXuatThuc.Text = "Số Lượng Xuất Thực";
            // 
            // lbl_SoLuongXuat
            // 
            this.lbl_SoLuongXuat.AutoSize = true;
            this.lbl_SoLuongXuat.Location = new System.Drawing.Point(17, 66);
            this.lbl_SoLuongXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuongXuat.Name = "lbl_SoLuongXuat";
            this.lbl_SoLuongXuat.Size = new System.Drawing.Size(78, 13);
            this.lbl_SoLuongXuat.TabIndex = 4;
            this.lbl_SoLuongXuat.Text = "Số Lượng Xuất";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(304, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Lime;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(210, 199);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Complete";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvDetailGDN
            // 
            this.dgvDetailGDN.AutoGenerateColumns = false;
            this.dgvDetailGDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailGDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanPhamDataGridViewTextBoxColumn,
            this.soLuongXuatDataGridViewTextBoxColumn,
            this.soLuongXuatThucDataGridViewTextBoxColumn});
            this.dgvDetailGDN.DataSource = this.f06QLXuatKhoChiTietBindingSource;
            this.dgvDetailGDN.Location = new System.Drawing.Point(9, 226);
            this.dgvDetailGDN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetailGDN.Name = "dgvDetailGDN";
            this.dgvDetailGDN.RowHeadersWidth = 51;
            this.dgvDetailGDN.RowTemplate.Height = 24;
            this.dgvDetailGDN.Size = new System.Drawing.Size(370, 117);
            this.dgvDetailGDN.TabIndex = 6;
            this.dgvDetailGDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailGDN_CellContentClick);
            this.dgvDetailGDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailGDN_CellContentClick);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Xuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xuat.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Xuat.Location = new System.Drawing.Point(121, 198);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(75, 23);
            this.btn_Xuat.TabIndex = 14;
            this.btn_Xuat.Text = "Ok";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // sanPhamDataGridViewTextBoxColumn
            // 
            this.sanPhamDataGridViewTextBoxColumn.DataPropertyName = "SanPham";
            this.sanPhamDataGridViewTextBoxColumn.HeaderText = "Sản Phẩm";
            this.sanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanPhamDataGridViewTextBoxColumn.Name = "sanPhamDataGridViewTextBoxColumn";
            this.sanPhamDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongXuatDataGridViewTextBoxColumn
            // 
            this.soLuongXuatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuat";
            this.soLuongXuatDataGridViewTextBoxColumn.HeaderText = "Số Lượng Xuất";
            this.soLuongXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongXuatDataGridViewTextBoxColumn.Name = "soLuongXuatDataGridViewTextBoxColumn";
            this.soLuongXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongXuatThucDataGridViewTextBoxColumn
            // 
            this.soLuongXuatThucDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuatThuc";
            this.soLuongXuatThucDataGridViewTextBoxColumn.HeaderText = "Số Lượng Xuất Thực";
            this.soLuongXuatThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongXuatThucDataGridViewTextBoxColumn.Name = "soLuongXuatThucDataGridViewTextBoxColumn";
            this.soLuongXuatThucDataGridViewTextBoxColumn.Width = 125;
            // 
            // f06QLXuatKhoChiTietBindingSource
            // 
            this.f06QLXuatKhoChiTietBindingSource.DataSource = typeof(SWarehouse.Models.GDNModels.F06_QLXuatKhoChiTiet);
            // 
            // D05_AddGDNDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 351);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.dgvDetailGDN);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grb_ChiTietPhieuXuat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "D05_AddGDNDetailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D05_AddGDNDetailDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.D05_AddGDNDetailDialog_FormClosed);
            this.Load += new System.EventHandler(this.D05_AddGDNDetailDialog_Load);
            this.grb_ChiTietPhieuXuat.ResumeLayout(false);
            this.grb_ChiTietPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_least)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrActualAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRequestAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailGDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f06QLXuatKhoChiTietBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ChiTietPhieuXuat;
        private System.Windows.Forms.NumericUpDown nmrActualAmount;
        private System.Windows.Forms.NumericUpDown nmrRequestAmount;
        private System.Windows.Forms.Label lbl_SoLuongXuatThuc;
        private System.Windows.Forms.Label lbl_SoLuongXuat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetailGDN;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongXuatThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource f06QLXuatKhoChiTietBindingSource;
        private System.Windows.Forms.NumericUpDown nud_least;
        private System.Windows.Forms.Label lbl_least;
    }
}
namespace SWarehouse.Dialog
{
    partial class D07_AddOrderDetail
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
            this.cbx_sanpham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_order_details = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f07QuanLyHoaDonChiTietModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_break = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_inputMoney = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_outputMoney = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.btn_edit = new System.Windows.Forms.Button();
            this.nud_quantityInWarehouse = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f07QuanLyHoaDonChiTietModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantityInWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_sanpham
            // 
            this.cbx_sanpham.FormattingEnabled = true;
            this.cbx_sanpham.Location = new System.Drawing.Point(185, 16);
            this.cbx_sanpham.Name = "cbx_sanpham";
            this.cbx_sanpham.Size = new System.Drawing.Size(121, 21);
            this.cbx_sanpham.TabIndex = 0;
            this.cbx_sanpham.SelectionChangeCommitted += new System.EventHandler(this.cbx_sanpham_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng";
            // 
            // dgv_order_details
            // 
            this.dgv_order_details.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_order_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_order_details.DataSource = this.f07QuanLyHoaDonChiTietModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order_details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_order_details.Location = new System.Drawing.Point(81, 145);
            this.dgv_order_details.Name = "dgv_order_details";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_details.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_order_details.RowHeadersWidth = 62;
            this.dgv_order_details.Size = new System.Drawing.Size(409, 187);
            this.dgv_order_details.TabIndex = 6;
            this.dgv_order_details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_details_CellContentClick);
            this.dgv_order_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_details_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenSP";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenSP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn2.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // f07QuanLyHoaDonChiTietModelBindingSource
            // 
            this.f07QuanLyHoaDonChiTietModelBindingSource.DataSource = typeof(SWarehouse.Models.BillModels.F07_QuanLyHoaDonChiTietModel);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(509, 208);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_pay.TabIndex = 7;
            this.btn_pay.Text = "Thanh Toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_break
            // 
            this.btn_break.Location = new System.Drawing.Point(626, 208);
            this.btn_break.Name = "btn_break";
            this.btn_break.Size = new System.Drawing.Size(75, 23);
            this.btn_break.TabIndex = 8;
            this.btn_break.Text = "Hủy";
            this.btn_break.UseVisualStyleBackColor = true;
            this.btn_break.Click += new System.EventHandler(this.btn_break_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiền Khách Trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiền Phải Trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tiền Thối";
            // 
            // txt_inputMoney
            // 
            this.txt_inputMoney.Location = new System.Drawing.Point(600, 35);
            this.txt_inputMoney.Name = "txt_inputMoney";
            this.txt_inputMoney.Size = new System.Drawing.Size(100, 20);
            this.txt_inputMoney.TabIndex = 12;
            this.txt_inputMoney.TextChanged += new System.EventHandler(this.txt_inputMoney_TextChanged);
            this.txt_inputMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputMoney_KeyPress);
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(600, 81);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 13;
            // 
            // txt_outputMoney
            // 
            this.txt_outputMoney.Enabled = false;
            this.txt_outputMoney.Location = new System.Drawing.Point(600, 128);
            this.txt_outputMoney.Name = "txt_outputMoney";
            this.txt_outputMoney.Size = new System.Drawing.Size(100, 20);
            this.txt_outputMoney.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(81, 109);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Thêm Vào Hóa Đơn";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nud_soluong
            // 
            this.nud_soluong.Location = new System.Drawing.Point(185, 59);
            this.nud_soluong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(120, 20);
            this.nud_soluong.TabIndex = 16;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(230, 109);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Sửa Lại";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // nud_quantityInWarehouse
            // 
            this.nud_quantityInWarehouse.Enabled = false;
            this.nud_quantityInWarehouse.Location = new System.Drawing.Point(370, 59);
            this.nud_quantityInWarehouse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_quantityInWarehouse.Name = "nud_quantityInWarehouse";
            this.nud_quantityInWarehouse.Size = new System.Drawing.Size(120, 20);
            this.nud_quantityInWarehouse.TabIndex = 18;
            // 
            // D07_AddOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 344);
            this.Controls.Add(this.nud_quantityInWarehouse);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.nud_soluong);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_outputMoney);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_inputMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_break);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.dgv_order_details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_sanpham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "D07_AddOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D07_AddOrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f07QuanLyHoaDonChiTietModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantityInWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_sanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_order_details;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_break;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_inputMoney;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_outputMoney;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.NumericUpDown nud_quantityInWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource f07QuanLyHoaDonChiTietModelBindingSource;
    }
}
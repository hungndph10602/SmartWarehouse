
namespace SWarehouse.Dialog
{
    partial class D03_AddGRNDetailDialog
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
            this.lbl_product = new System.Windows.Forms.Label();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.lbl_request = new System.Windows.Forms.Label();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_GRNDetail = new System.Windows.Forms.DataGridView();
            this.nud_request = new System.Windows.Forms.NumericUpDown();
            this.nud_actual = new System.Windows.Forms.NumericUpDown();
            this.nud_cost = new System.Windows.Forms.NumericUpDown();
            this.cbx_supplier = new System.Windows.Forms.ComboBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GRNDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_actual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cost)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(15, 31);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(82, 20);
            this.lbl_product.TabIndex = 0;
            this.lbl_product.Text = "Sản phẩm";
            // 
            // cbx_product
            // 
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(158, 17);
            this.cbx_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(390, 28);
            this.cbx_product.TabIndex = 2;
            // 
            // lbl_request
            // 
            this.lbl_request.AutoSize = true;
            this.lbl_request.Location = new System.Drawing.Point(15, 109);
            this.lbl_request.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_request.Name = "lbl_request";
            this.lbl_request.Size = new System.Drawing.Size(131, 20);
            this.lbl_request.TabIndex = 4;
            this.lbl_request.Text = "Số lượng yêu cầu";
            // 
            // lbl_actual
            // 
            this.lbl_actual.AutoSize = true;
            this.lbl_actual.Location = new System.Drawing.Point(15, 149);
            this.lbl_actual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(125, 20);
            this.lbl_actual.TabIndex = 5;
            this.lbl_actual.Text = "Số lượng thực tế";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(15, 189);
            this.lbl_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(74, 20);
            this.lbl_cost.TabIndex = 6;
            this.lbl_cost.Text = "Giá nhập";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Lime;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(298, 257);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 35);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(436, 257);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 35);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(158, 257);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 35);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_GRNDetail
            // 
            this.dgv_GRNDetail.AllowUserToAddRows = false;
            this.dgv_GRNDetail.AllowUserToDeleteRows = false;
            this.dgv_GRNDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GRNDetail.Location = new System.Drawing.Point(21, 317);
            this.dgv_GRNDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_GRNDetail.Name = "dgv_GRNDetail";
            this.dgv_GRNDetail.ReadOnly = true;
            this.dgv_GRNDetail.RowHeadersWidth = 62;
            this.dgv_GRNDetail.Size = new System.Drawing.Size(528, 335);
            this.dgv_GRNDetail.TabIndex = 14;
            // 
            // nud_request
            // 
            this.nud_request.Location = new System.Drawing.Point(158, 97);
            this.nud_request.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_request.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_request.Name = "nud_request";
            this.nud_request.Size = new System.Drawing.Size(392, 26);
            this.nud_request.TabIndex = 15;
            // 
            // nud_actual
            // 
            this.nud_actual.Location = new System.Drawing.Point(158, 137);
            this.nud_actual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_actual.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_actual.Name = "nud_actual";
            this.nud_actual.Size = new System.Drawing.Size(392, 26);
            this.nud_actual.TabIndex = 16;
            // 
            // nud_cost
            // 
            this.nud_cost.Location = new System.Drawing.Point(158, 177);
            this.nud_cost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_cost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_cost.Name = "nud_cost";
            this.nud_cost.Size = new System.Drawing.Size(392, 26);
            this.nud_cost.TabIndex = 17;
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(158, 57);
            this.cbx_supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(390, 28);
            this.cbx_supplier.TabIndex = 20;
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(15, 69);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(82, 20);
            this.lbl_supplier.TabIndex = 19;
            this.lbl_supplier.Text = "Sản phẩm";
            // 
            // D03_AddGRNDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 663);
            this.Controls.Add(this.cbx_supplier);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.nud_cost);
            this.Controls.Add(this.nud_actual);
            this.Controls.Add(this.nud_request);
            this.Controls.Add(this.dgv_GRNDetail);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_actual);
            this.Controls.Add(this.lbl_request);
            this.Controls.Add(this.cbx_product);
            this.Controls.Add(this.lbl_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "D03_AddGRNDetailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D03_AddGRNDetailDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GRNDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_actual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.ComboBox cbx_product;
        private System.Windows.Forms.Label lbl_request;
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_GRNDetail;
        private System.Windows.Forms.NumericUpDown nud_request;
        private System.Windows.Forms.NumericUpDown nud_actual;
        private System.Windows.Forms.NumericUpDown nud_cost;
        private System.Windows.Forms.ComboBox cbx_supplier;
        private System.Windows.Forms.Label lbl_supplier;
    }
}
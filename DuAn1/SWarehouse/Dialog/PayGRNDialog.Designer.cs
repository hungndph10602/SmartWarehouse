
namespace SWarehouse.Dialog
{
    partial class PayGRNDialog
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
            this.txt_grn = new System.Windows.Forms.TextBox();
            this.lbl_hoaDon = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_tienThanhToan = new System.Windows.Forms.Label();
            this.nud_least = new System.Windows.Forms.NumericUpDown();
            this.nud_pay = new System.Windows.Forms.NumericUpDown();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_least)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_grn
            // 
            this.txt_grn.Location = new System.Drawing.Point(182, 13);
            this.txt_grn.Name = "txt_grn";
            this.txt_grn.ReadOnly = true;
            this.txt_grn.Size = new System.Drawing.Size(176, 20);
            this.txt_grn.TabIndex = 0;
            // 
            // lbl_hoaDon
            // 
            this.lbl_hoaDon.AutoSize = true;
            this.lbl_hoaDon.Location = new System.Drawing.Point(16, 20);
            this.lbl_hoaDon.Name = "lbl_hoaDon";
            this.lbl_hoaDon.Size = new System.Drawing.Size(49, 13);
            this.lbl_hoaDon.TabIndex = 3;
            this.lbl_hoaDon.Text = "Hoá đơn";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(16, 45);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(133, 13);
            this.lbl_TongTien.TabIndex = 4;
            this.lbl_TongTien.Text = "Tổng tiền chưa thanh toán";
            // 
            // lbl_tienThanhToan
            // 
            this.lbl_tienThanhToan.AutoSize = true;
            this.lbl_tienThanhToan.Location = new System.Drawing.Point(16, 71);
            this.lbl_tienThanhToan.Name = "lbl_tienThanhToan";
            this.lbl_tienThanhToan.Size = new System.Drawing.Size(82, 13);
            this.lbl_tienThanhToan.TabIndex = 5;
            this.lbl_tienThanhToan.Text = "Tiền thanh toán";
            // 
            // nud_least
            // 
            this.nud_least.Enabled = false;
            this.nud_least.Location = new System.Drawing.Point(182, 38);
            this.nud_least.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_least.Name = "nud_least";
            this.nud_least.ReadOnly = true;
            this.nud_least.Size = new System.Drawing.Size(176, 20);
            this.nud_least.TabIndex = 6;
            // 
            // nud_pay
            // 
            this.nud_pay.Location = new System.Drawing.Point(182, 64);
            this.nud_pay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_pay.Name = "nud_pay";
            this.nud_pay.Size = new System.Drawing.Size(176, 20);
            this.nud_pay.TabIndex = 7;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(182, 113);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_pay.TabIndex = 8;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(283, 113);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // PayGRNDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 148);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.nud_pay);
            this.Controls.Add(this.nud_least);
            this.Controls.Add(this.lbl_tienThanhToan);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl_hoaDon);
            this.Controls.Add(this.txt_grn);
            this.Name = "PayGRNDialog";
            this.Text = "PayGRNDialog";
            ((System.ComponentModel.ISupportInitialize)(this.nud_least)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_grn;
        private System.Windows.Forms.Label lbl_hoaDon;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_tienThanhToan;
        private System.Windows.Forms.NumericUpDown nud_least;
        private System.Windows.Forms.NumericUpDown nud_pay;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_huy;
    }
}
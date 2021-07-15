namespace SWarehouse.Dialog
{
    partial class D01_AddCustomerDialog
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
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.lbl_DienThoai = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(12, 43);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(115, 17);
            this.lbl_TenKhachHang.TabIndex = 1;
            this.lbl_TenKhachHang.Text = "Tên Khách Hàng";
            this.lbl_TenKhachHang.Click += new System.EventHandler(this.lbl_TenKhachHang_Click);
            // 
            // lbl_DienThoai
            // 
            this.lbl_DienThoai.AutoSize = true;
            this.lbl_DienThoai.Location = new System.Drawing.Point(12, 103);
            this.lbl_DienThoai.Name = "lbl_DienThoai";
            this.lbl_DienThoai.Size = new System.Drawing.Size(72, 17);
            this.lbl_DienThoai.TabIndex = 2;
            this.lbl_DienThoai.Text = "Điện thoại";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(12, 174);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 17);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(137, 40);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(242, 22);
            this.txt_TenKhachHang.TabIndex = 4;
            this.txt_TenKhachHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(137, 103);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(242, 22);
            this.txt_DienThoai.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(137, 171);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(242, 22);
            this.txt_Email.TabIndex = 6;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(217, 228);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(162, 45);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::SWarehouse.Properties.Resources.plus;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(39, 228);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(162, 45);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // D01_AddCustomerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 303);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_DienThoai);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_DienThoai);
            this.Controls.Add(this.lbl_TenKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "D01_AddCustomerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D01_AddCustomerDialog";
            this.Load += new System.EventHandler(this.D01_AddCustomerDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.Label lbl_DienThoai;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Huy;
    }
}
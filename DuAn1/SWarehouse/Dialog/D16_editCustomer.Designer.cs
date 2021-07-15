namespace SWarehouse.Dialog
{
    partial class D16_editCustomer
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_editEmail = new System.Windows.Forms.TextBox();
            this.txt_editDienThoai = new System.Windows.Forms.TextBox();
            this.txt_editTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_DienThoai = new System.Windows.Forms.Label();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(215, 200);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(162, 45);
            this.btn_Huy.TabIndex = 16;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = global::SWarehouse.Properties.Resources.plus;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(37, 200);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(162, 45);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_editEmail
            // 
            this.txt_editEmail.Location = new System.Drawing.Point(135, 143);
            this.txt_editEmail.Name = "txt_editEmail";
            this.txt_editEmail.Size = new System.Drawing.Size(242, 22);
            this.txt_editEmail.TabIndex = 14;
            // 
            // txt_editDienThoai
            // 
            this.txt_editDienThoai.Location = new System.Drawing.Point(135, 75);
            this.txt_editDienThoai.Name = "txt_editDienThoai";
            this.txt_editDienThoai.Size = new System.Drawing.Size(242, 22);
            this.txt_editDienThoai.TabIndex = 13;
            // 
            // txt_editTenKhachHang
            // 
            this.txt_editTenKhachHang.Location = new System.Drawing.Point(135, 12);
            this.txt_editTenKhachHang.Name = "txt_editTenKhachHang";
            this.txt_editTenKhachHang.Size = new System.Drawing.Size(242, 22);
            this.txt_editTenKhachHang.TabIndex = 12;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(10, 146);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 17);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_DienThoai
            // 
            this.lbl_DienThoai.AutoSize = true;
            this.lbl_DienThoai.Location = new System.Drawing.Point(10, 75);
            this.lbl_DienThoai.Name = "lbl_DienThoai";
            this.lbl_DienThoai.Size = new System.Drawing.Size(72, 17);
            this.lbl_DienThoai.TabIndex = 10;
            this.lbl_DienThoai.Text = "Điện thoại";
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(10, 15);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(115, 17);
            this.lbl_TenKhachHang.TabIndex = 9;
            this.lbl_TenKhachHang.Text = "Tên Khách Hàng";
            // 
            // D16_editCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 256);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_editEmail);
            this.Controls.Add(this.txt_editDienThoai);
            this.Controls.Add(this.txt_editTenKhachHang);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_DienThoai);
            this.Controls.Add(this.lbl_TenKhachHang);
            this.Name = "D16_editCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D16_editCustomer";
            this.Load += new System.EventHandler(this.D16_editCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_editEmail;
        private System.Windows.Forms.TextBox txt_editDienThoai;
        private System.Windows.Forms.TextBox txt_editTenKhachHang;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_DienThoai;
        private System.Windows.Forms.Label lbl_TenKhachHang;
    }
}
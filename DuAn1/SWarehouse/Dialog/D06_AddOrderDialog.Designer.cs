namespace SWarehouse.Dialog
{
    partial class D06_AddOrderDialog
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
            this.cbx_khachhang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_thoigiantao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_closee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_khachhang
            // 
            this.cbx_khachhang.FormattingEnabled = true;
            this.cbx_khachhang.Location = new System.Drawing.Point(195, 58);
            this.cbx_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_khachhang.Name = "cbx_khachhang";
            this.cbx_khachhang.Size = new System.Drawing.Size(244, 24);
            this.cbx_khachhang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khách Hàng";
            // 
            // dtp_thoigiantao
            // 
            this.dtp_thoigiantao.CustomFormat = "dd/MM/yyyy";
            this.dtp_thoigiantao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoigiantao.Location = new System.Drawing.Point(195, 92);
            this.dtp_thoigiantao.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_thoigiantao.Name = "dtp_thoigiantao";
            this.dtp_thoigiantao.Size = new System.Drawing.Size(244, 22);
            this.dtp_thoigiantao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời Gian";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(121, 171);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(140, 28);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Thêm Hóa Đơn";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_closee
            // 
            this.btn_closee.Location = new System.Drawing.Point(313, 171);
            this.btn_closee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closee.Name = "btn_closee";
            this.btn_closee.Size = new System.Drawing.Size(100, 28);
            this.btn_closee.TabIndex = 9;
            this.btn_closee.Text = "Hủy";
            this.btn_closee.UseVisualStyleBackColor = true;
            this.btn_closee.Click += new System.EventHandler(this.btn_closee_Click);
            // 
            // D06_AddOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 214);
            this.Controls.Add(this.btn_closee);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_thoigiantao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_khachhang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "D06_AddOrderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D06_AddOrderDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbx_khachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_thoigiantao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_closee;
    }
}
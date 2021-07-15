
namespace SWarehouse.Dialog
{
    partial class D02_AddGRNDialog
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
            this.lbl_warehouse = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cbx_warehouse = new System.Windows.Forms.ComboBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_ngayNhap = new System.Windows.Forms.Label();
            this.dtp_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_warehouse
            // 
            this.lbl_warehouse.AutoSize = true;
            this.lbl_warehouse.Location = new System.Drawing.Point(16, 28);
            this.lbl_warehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_warehouse.Name = "lbl_warehouse";
            this.lbl_warehouse.Size = new System.Drawing.Size(33, 17);
            this.lbl_warehouse.TabIndex = 0;
            this.lbl_warehouse.Text = "Kho";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Lime;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(174, 159);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 28);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cbx_warehouse
            // 
            this.cbx_warehouse.FormattingEnabled = true;
            this.cbx_warehouse.Location = new System.Drawing.Point(139, 18);
            this.cbx_warehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_warehouse.Name = "cbx_warehouse";
            this.cbx_warehouse.Size = new System.Drawing.Size(243, 24);
            this.cbx_warehouse.TabIndex = 3;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(17, 82);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(43, 17);
            this.lbl_description.TabIndex = 9;
            this.lbl_description.Text = "Mô tả";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(282, 159);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(139, 82);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(243, 70);
            this.txt_description.TabIndex = 13;
            // 
            // lbl_ngayNhap
            // 
            this.lbl_ngayNhap.AutoSize = true;
            this.lbl_ngayNhap.Location = new System.Drawing.Point(17, 55);
            this.lbl_ngayNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngayNhap.Name = "lbl_ngayNhap";
            this.lbl_ngayNhap.Size = new System.Drawing.Size(77, 17);
            this.lbl_ngayNhap.TabIndex = 14;
            this.lbl_ngayNhap.Text = "Ngày nhập";
            // 
            // dtp_ngayNhap
            // 
            this.dtp_ngayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayNhap.Location = new System.Drawing.Point(139, 49);
            this.dtp_ngayNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ngayNhap.Name = "dtp_ngayNhap";
            this.dtp_ngayNhap.Size = new System.Drawing.Size(243, 22);
            this.dtp_ngayNhap.TabIndex = 15;
            // 
            // D02_AddGRNDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 202);
            this.Controls.Add(this.dtp_ngayNhap);
            this.Controls.Add(this.lbl_ngayNhap);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.cbx_warehouse);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_warehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "D02_AddGRNDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D02_AddGRNDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_warehouse;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ComboBox cbx_warehouse;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_ngayNhap;
        private System.Windows.Forms.DateTimePicker dtp_ngayNhap;
    }
}
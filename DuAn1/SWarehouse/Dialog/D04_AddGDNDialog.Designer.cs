namespace SWarehouse.Dialog
{
    partial class D04_AddGDNDialog
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
            this.grb_ThongTinChung = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtMoreInf = new System.Windows.Forms.RichTextBox();
            this.cboWareHouseId = new System.Windows.Forms.ComboBox();
            this.lbl_MaKho = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboNRId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_ThongTinChung.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ThongTinChung
            // 
            this.grb_ThongTinChung.Controls.Add(this.cboNRId);
            this.grb_ThongTinChung.Controls.Add(this.label2);
            this.grb_ThongTinChung.Controls.Add(this.label1);
            this.grb_ThongTinChung.Controls.Add(this.rtxtMoreInf);
            this.grb_ThongTinChung.Controls.Add(this.cboWareHouseId);
            this.grb_ThongTinChung.Controls.Add(this.lbl_MaKho);
            this.grb_ThongTinChung.Location = new System.Drawing.Point(12, 11);
            this.grb_ThongTinChung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_ThongTinChung.Name = "grb_ThongTinChung";
            this.grb_ThongTinChung.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_ThongTinChung.Size = new System.Drawing.Size(381, 259);
            this.grb_ThongTinChung.TabIndex = 1;
            this.grb_ThongTinChung.TabStop = false;
            this.grb_ThongTinChung.Text = "Thông Tin Chung";
            this.grb_ThongTinChung.Enter += new System.EventHandler(this.grb_ThongTinChung_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thông tin khác";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtMoreInf
            // 
            this.rtxtMoreInf.Location = new System.Drawing.Point(144, 121);
            this.rtxtMoreInf.Name = "rtxtMoreInf";
            this.rtxtMoreInf.Size = new System.Drawing.Size(216, 113);
            this.rtxtMoreInf.TabIndex = 15;
            this.rtxtMoreInf.Text = "";
            // 
            // cboWareHouseId
            // 
            this.cboWareHouseId.FormattingEnabled = true;
            this.cboWareHouseId.Location = new System.Drawing.Point(144, 33);
            this.cboWareHouseId.Name = "cboWareHouseId";
            this.cboWareHouseId.Size = new System.Drawing.Size(216, 24);
            this.cboWareHouseId.TabIndex = 14;
            // 
            // lbl_MaKho
            // 
            this.lbl_MaKho.AutoSize = true;
            this.lbl_MaKho.Location = new System.Drawing.Point(25, 40);
            this.lbl_MaKho.Name = "lbl_MaKho";
            this.lbl_MaKho.Size = new System.Drawing.Size(56, 17);
            this.lbl_MaKho.TabIndex = 1;
            this.lbl_MaKho.Text = "Mã Kho";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Lime;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(157, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(294, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboNRId
            // 
            this.cboNRId.FormattingEnabled = true;
            this.cboNRId.Location = new System.Drawing.Point(144, 78);
            this.cboNRId.Name = "cboNRId";
            this.cboNRId.Size = new System.Drawing.Size(216, 24);
            this.cboNRId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Yêu Cầu";
            // 
            // D04_AddGDNDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 334);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grb_ThongTinChung);
            this.Name = "D04_AddGDNDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D04_AddGDNDialog";
            this.Load += new System.EventHandler(this.D04_AddGDNDialog_Load);
            this.grb_ThongTinChung.ResumeLayout(false);
            this.grb_ThongTinChung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ThongTinChung;
        private System.Windows.Forms.ComboBox cboWareHouseId;
        private System.Windows.Forms.Label lbl_MaKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtMoreInf;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboNRId;
        private System.Windows.Forms.Label label2;
    }
}
namespace SWarehouse.Dialog
{
    partial class D15_editproduct
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
            this.RTB_edithowtouse = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_editnameproduct = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_editclose = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.PB_editproduct = new System.Windows.Forms.PictureBox();
            this.RTB_editdescreption = new System.Windows.Forms.RichTextBox();
            this.txt_editdescreption = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_urd = new System.Windows.Forms.TextBox();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_editproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // RTB_edithowtouse
            // 
            this.RTB_edithowtouse.Location = new System.Drawing.Point(50, 294);
            this.RTB_edithowtouse.Margin = new System.Windows.Forms.Padding(2);
            this.RTB_edithowtouse.Name = "RTB_edithowtouse";
            this.RTB_edithowtouse.Size = new System.Drawing.Size(168, 61);
            this.RTB_edithowtouse.TabIndex = 35;
            this.RTB_edithowtouse.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hướng Dẫn Sử Dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hình Ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txt_editnameproduct
            // 
            this.txt_editnameproduct.Location = new System.Drawing.Point(50, 127);
            this.txt_editnameproduct.Margin = new System.Windows.Forms.Padding(2);
            this.txt_editnameproduct.Name = "txt_editnameproduct";
            this.txt_editnameproduct.Size = new System.Drawing.Size(168, 20);
            this.txt_editnameproduct.TabIndex = 28;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(178, 15);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(233, 37);
            this.lbl_title.TabIndex = 27;
            this.lbl_title.Text = "Sửa Sản Phẩm";
            // 
            // btn_editclose
            // 
            this.btn_editclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editclose.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_editclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editclose.Location = new System.Drawing.Point(476, 312);
            this.btn_editclose.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editclose.Name = "btn_editclose";
            this.btn_editclose.Size = new System.Drawing.Size(66, 43);
            this.btn_editclose.TabIndex = 45;
            this.btn_editclose.Text = "Hủy";
            this.btn_editclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editclose.UseVisualStyleBackColor = true;
            this.btn_editclose.Click += new System.EventHandler(this.btn_editclose_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = global::SWarehouse.Properties.Resources.confirmation;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(360, 312);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(68, 43);
            this.btn_edit.TabIndex = 44;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // PB_editproduct
            // 
            this.PB_editproduct.Location = new System.Drawing.Point(56, 174);
            this.PB_editproduct.Margin = new System.Windows.Forms.Padding(2);
            this.PB_editproduct.Name = "PB_editproduct";
            this.PB_editproduct.Size = new System.Drawing.Size(104, 89);
            this.PB_editproduct.TabIndex = 33;
            this.PB_editproduct.TabStop = false;
            // 
            // RTB_editdescreption
            // 
            this.RTB_editdescreption.Location = new System.Drawing.Point(361, 118);
            this.RTB_editdescreption.Margin = new System.Windows.Forms.Padding(2);
            this.RTB_editdescreption.Name = "RTB_editdescreption";
            this.RTB_editdescreption.Size = new System.Drawing.Size(181, 69);
            this.RTB_editdescreption.TabIndex = 43;
            this.RTB_editdescreption.Text = "";
            // 
            // txt_editdescreption
            // 
            this.txt_editdescreption.Location = new System.Drawing.Point(361, 70);
            this.txt_editdescreption.Margin = new System.Windows.Forms.Padding(2);
            this.txt_editdescreption.Name = "txt_editdescreption";
            this.txt_editdescreption.Size = new System.Drawing.Size(181, 20);
            this.txt_editdescreption.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mô Tả Ngắn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Mô Tả Dài";
            // 
            // txt_urd
            // 
            this.txt_urd.Location = new System.Drawing.Point(364, 193);
            this.txt_urd.Name = "txt_urd";
            this.txt_urd.Size = new System.Drawing.Size(100, 20);
            this.txt_urd.TabIndex = 46;
            // 
            // cbx_product
            // 
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(50, 79);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(168, 21);
            this.cbx_product.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Chọn sản phẩm muốn thay đổi";
            // 
            // D15_editproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_product);
            this.Controls.Add(this.txt_urd);
            this.Controls.Add(this.btn_editclose);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.RTB_editdescreption);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_editdescreption);
            this.Controls.Add(this.RTB_edithowtouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PB_editproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_editnameproduct);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "D15_editproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D15_editproduct";
            ((System.ComponentModel.ISupportInitialize)(this.PB_editproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editclose;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.RichTextBox RTB_edithowtouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PB_editproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_editnameproduct;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox RTB_editdescreption;
        private System.Windows.Forms.TextBox txt_editdescreption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_urd;
        private System.Windows.Forms.ComboBox cbx_product;
        private System.Windows.Forms.Label label2;
    }
}
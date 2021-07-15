namespace SWarehouse.Dialog
{
    partial class D13_CreateAccount
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
            this.btn_createaccount = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_displayName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_displayName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbx_role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_createaccount
            // 
            this.btn_createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createaccount.Image = global::SWarehouse.Properties.Resources.confirmation;
            this.btn_createaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createaccount.Location = new System.Drawing.Point(98, 394);
            this.btn_createaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createaccount.Name = "btn_createaccount";
            this.btn_createaccount.Size = new System.Drawing.Size(170, 65);
            this.btn_createaccount.TabIndex = 0;
            this.btn_createaccount.Text = "Tạo tài khoản";
            this.btn_createaccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createaccount.UseVisualStyleBackColor = true;
            this.btn_createaccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Image = global::SWarehouse.Properties.Resources.close;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.Location = new System.Drawing.Point(285, 394);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(91, 65);
            this.btn_huy.TabIndex = 1;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(94, 124);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 20);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Tên đăng nhập";
            // 
            // lbl_displayName
            // 
            this.lbl_displayName.AutoSize = true;
            this.lbl_displayName.Location = new System.Drawing.Point(93, 199);
            this.lbl_displayName.Name = "lbl_displayName";
            this.lbl_displayName.Size = new System.Drawing.Size(91, 20);
            this.lbl_displayName.TabIndex = 3;
            this.lbl_displayName.Text = "Tên hiển thị";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(94, 266);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(75, 20);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Mật khẩu";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(94, 335);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(66, 20);
            this.lbl_role.TabIndex = 5;
            this.lbl_role.Text = "Chức vụ";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(98, 148);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(278, 26);
            this.txt_username.TabIndex = 6;
            // 
            // txt_displayName
            // 
            this.txt_displayName.Location = new System.Drawing.Point(97, 222);
            this.txt_displayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_displayName.Name = "txt_displayName";
            this.txt_displayName.Size = new System.Drawing.Size(278, 26);
            this.txt_displayName.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(97, 290);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(278, 26);
            this.txt_password.TabIndex = 8;
            // 
            // cbx_role
            // 
            this.cbx_role.FormattingEnabled = true;
            this.cbx_role.Location = new System.Drawing.Point(97, 359);
            this.cbx_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_role.Name = "cbx_role";
            this.cbx_role.Size = new System.Drawing.Size(278, 28);
            this.cbx_role.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đăng Kí Tài Khoản";
            // 
            // D13_CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(488, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_displayName);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_displayName);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_createaccount);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "D13_CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "D13_CreateAccount";
            this.Load += new System.EventHandler(this.D13_CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createaccount;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_displayName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_displayName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cbx_role;
        private System.Windows.Forms.Label label1;
    }
}
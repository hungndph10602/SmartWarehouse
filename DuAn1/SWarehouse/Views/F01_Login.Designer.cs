namespace SWarehouse.Views
{
    partial class F01_Login
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_brand2 = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_visibel = new System.Windows.Forms.Button();
            this.pbx_brand = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_brand)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_login.Location = new System.Drawing.Point(341, 100);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(202, 26);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login your account!";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(345, 172);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(235, 30);
            this.txt_username.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(343, 297);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(107, 44);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(345, 241);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(235, 31);
            this.txt_password.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(344, 359);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(107, 48);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.Location = new System.Drawing.Point(12, 33);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(178, 66);
            this.lbl_brand.TabIndex = 8;
            this.lbl_brand.Text = "Smart";
            // 
            // lbl_brand2
            // 
            this.lbl_brand2.AutoSize = true;
            this.lbl_brand2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_brand2.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand2.Location = new System.Drawing.Point(17, 100);
            this.lbl_brand2.Name = "lbl_brand2";
            this.lbl_brand2.Size = new System.Drawing.Size(262, 56);
            this.lbl_brand2.TabIndex = 9;
            this.lbl_brand2.Text = "Warehouse";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_welcome.Location = new System.Drawing.Point(335, 44);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(347, 56);
            this.lbl_welcome.TabIndex = 10;
            this.lbl_welcome.Text = "Welcome back!";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // btn_visibel
            // 
            this.btn_visibel.FlatAppearance.BorderSize = 0;
            this.btn_visibel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visibel.Image = global::SWarehouse.Properties.Resources.invisible__1_;
            this.btn_visibel.Location = new System.Drawing.Point(586, 241);
            this.btn_visibel.Name = "btn_visibel";
            this.btn_visibel.Size = new System.Drawing.Size(46, 31);
            this.btn_visibel.TabIndex = 11;
            this.btn_visibel.UseVisualStyleBackColor = true;
            this.btn_visibel.Click += new System.EventHandler(this.btn_visibel_Click);
            // 
            // pbx_brand
            // 
            this.pbx_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbx_brand.Location = new System.Drawing.Point(1, 0);
            this.pbx_brand.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbx_brand.Name = "pbx_brand";
            this.pbx_brand.Size = new System.Drawing.Size(301, 449);
            this.pbx_brand.TabIndex = 7;
            this.pbx_brand.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SWarehouse.Properties.Resources.visibility__1_;
            this.button1.Location = new System.Drawing.Point(586, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 31);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F01_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_visibel);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_brand2);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.pbx_brand);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "F01_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.F01_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_brand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pbx_brand;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_brand2;
        private System.Windows.Forms.Label lbl_welcome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_visibel;
        private System.Windows.Forms.Button button1;
    }
}
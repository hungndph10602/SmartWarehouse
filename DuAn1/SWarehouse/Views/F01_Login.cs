using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartWareHouse;
using SWarehouse.Controllers.UserServices;
using SWarehouse.Utilities;

namespace SWarehouse.Views
{
    public partial class F01_Login : Form
    {

        IUserSevice _userService { get; set; }
        SP_Login_Result _userData { get; set; }
        public F01_Login()
        {
            InitializeComponent();
            _userService = new UserService();
        }



        // 1 )Tạo phương thức các quền của Admin
        public void Admin()
        {
            #region Lối Vào 
            F02_Main.mdiobj.đăngNhậpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.đăngXuấtToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.thoátToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            #endregion

            #region Danh Mục
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.danhMụcToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Enabled = true;
            #endregion
        }
        // 2) tạo phương thức các quền của Quản lí kho
        public void WarehouseManager()
        {
            #region Lối Vào
            F02_Main.mdiobj.đăngNhậpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.đăngXuấtToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.thoátToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            #endregion

            #region Danh Mục
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Visible = false;

            F02_Main.mdiobj.danhMụcToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Enabled = false;
            #endregion
        }
        // 3) tạo phương thức các quền của nhân viên quản lí kho
        public void WarehouseStaff()
        {
            #region Lối Vào
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đăngNhậpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.đăngXuấtToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.thoátToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Enabled = true;

            #endregion

            #region Danh Mục
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Visible = false;

            F02_Main.mdiobj.danhMụcToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Enabled = false;

            #endregion
        }
        // 4)tạo phương thức các quền của Quản Lí Cửa Hàng
        public void StoreManager()
        {
            #region Lối Vào
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đăngNhậpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.đăngXuấtToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.thoátToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            #endregion
            #region Danh Mục
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.danhMụcToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Enabled = false;
            #endregion
        }
        // 5) tạo phương thức các quền của nhân viên Cửa Hàng
        public void StoreStaff()
        {
            #region Lối Vào
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đăngNhậpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.đăngXuấtToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.thoátToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.hồSơNhânViênToolStripMenuItem.Enabled = true;
            F02_Main.mdiobj.đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            #endregion
            #region Danh Mục
            F02_Main.mdiobj.danhMụcToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Visible = true;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Visible = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Visible = true;

            F02_Main.mdiobj.danhMụcToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhậpKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíXuấtKhoToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíNhàCungCấpToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíHóaĐơnToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quanrLíNhânViênToolStripMenuItem.Enabled = false;
            F02_Main.mdiobj.quảnLíkhachhangToolStripMenuItem.Enabled = false;
            #endregion
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void setRole(int Role_ID)
        {
            switch (Role_ID)
            {
                case 1:
                    MessageBox.Show("Chào Quản Lí Tất cả bộ phận !!");
                    Admin();
                    break;
                case 2:
                    MessageBox.Show("Chào Quản Lí Kho !!");
                    WarehouseManager();
                    break;
                case 3:
                    MessageBox.Show("Chào Nhân Viên quản lí kho !!");
                    WarehouseStaff();
                    break;
                case 4:
                    MessageBox.Show("Chào Quản Lí Cửa Hàng !!");
                    StoreManager();
                    break;
                case 5:
                    MessageBox.Show("Chào nhân viên Cửa Hàng !!");
                    StoreStaff();
                    break;
            }
        }
        private async void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _userService.UserLogin(txt_username.Text, txt_password.Text);
                if (data != null)
                {
                    if (data.Role_ID != 0)
                    {
                        setRole(data.Role_ID);
                        _userData = data;
                        AppConstants.UserName = data.UserName;
                        AppConstants.Role = data.Role_ID;
                        AppConstants.StaffID = data.Staff_ID;
                        AppConstants.AccountID = data.ID;
                        AppConstants.Islogin = true;
                        this.Close();
                        return;
                    }
                    else
                    {
                        _userData = new SP_Login_Result();
                        MessageBox.Show("Thông Tin Tài Khoản Không Chính Xác !");
                        return;
                    }
                }
                _userData = new SP_Login_Result();
                MessageBox.Show("Thông Tin Tài Khoản Không Chính Xác !");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void F01_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_visibel_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar== '\0')
            {
                button1.BringToFront();
                txt_password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                btn_visibel.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Dialog;
using SWarehouse.Utilities;
namespace SWarehouse.Views
{
    public partial class F14_InsideMain : Form
    {

        public F14_InsideMain()
        {
            InitializeComponent();
            AppConstants.Islogin = false;
        }

        private void btn_createbill_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D06_AddOrderDialog addOrderDialog = new D06_AddOrderDialog();
                addOrderDialog.ShowDialog();
            }

        }

        private void btn_loginflash_Click(object sender, EventArgs e)
        {
            if(AppConstants.Islogin)
            {
                MessageBox.Show("Vui lòng đăng xuất để sử dụng chức năng!");
                return;
            }    
            F01_Login f01_Login = new F01_Login();
            f01_Login.ShowDialog();

        }

        private void btn_addnewspu_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D08_SuplierDialog d08_SuplierDialog = new D08_SuplierDialog();
                d08_SuplierDialog.ShowDialog();
            }
        }

        private void btn_addnewcustomer_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D01_AddCustomerDialog d01_AddCustomerDialog = new D01_AddCustomerDialog();
                d01_AddCustomerDialog.ShowDialog();
            }
        }

        private void btn_addnewstaff_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D11_NoteRequestDialog d11_NoteRequestDialog = new D11_NoteRequestDialog();
                d11_NoteRequestDialog.ShowDialog();
            }
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                F13_Statistical f13_Statistical = new F13_Statistical();
                f13_Statistical.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D14_addproduct d14_Addproduct = new D14_addproduct();
                d14_Addproduct.ShowDialog();
            }
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D02_AddGRNDialog d02_AddGRNDialog = new D02_AddGRNDialog();
                d02_AddGRNDialog.ShowDialog();
            }
        }

        private void btn_outofstock_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                MessageBox.Show("Bạn Cần Đăng Nhập Để Sử Dụng Chức Năng Này !");
                F01_Login f01_Login = new F01_Login();
                f01_Login.ShowDialog();
            }
            else
            {
                D04_AddGDNDialog d04_AddGDNDialog = new D04_AddGDNDialog();
                d04_AddGDNDialog.ShowDialog();
            }
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn Đăng xuất không không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Tài Khoản Đã Được Đăng Xuất !");
                AppConstants.Islogin = false;
                AppConstants.Role = 0;
                AppConstants.UserName = null;
                AppConstants.StaffID = 0;
                AppConstants.AccountID = 0;
            }
        }
    }
}

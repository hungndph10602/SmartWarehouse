using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.SupplierServices;

namespace SWarehouse.Dialog
{
    public partial class D10_EditSupplierDialog : Form
    {
        private int _splierSv { get; set; }
        private string _name { get; set; }
        private string _diaChi { get; set; }
        private string _email { get; set; }
        private string _ngayTao { get; set; }
        private string _dienThoai { get; set; }
        ISupplierService _supplierService { get; set; }
        public D10_EditSupplierDialog(int SplSerV, string name, string  diaChi, string  email, string ngayTao, string  dienThoai)
        {
            InitializeComponent();
            _splierSv = SplSerV;
            _name = name;
            _diaChi = diaChi;
            _email = email;
            _ngayTao = ngayTao;
            _dienThoai = dienThoai;
            _supplierService = new SupplierService();
            loadtextBox();
        }
        public void loadtextBox()
        {
            txtSupplierName.Text = _name;
            rtxtAddress.Text = _diaChi;
            txtEmail.Text = _email;
            dtpContactDate.Value = DateTime.Parse( _ngayTao);
            txtPhoneNumber.Text = _dienThoai;
        }
        //hàm kiểm tra EMail
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //btn sửa
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
            }
            else
              if (string.IsNullOrEmpty(txtPhoneNumber.Text) == true || txtPhoneNumber.Text.Length < 9 || txtPhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại trống hoặc sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) == true || IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email trống hoặc sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(rtxtAddress.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtAddress.Focus();
            }
            else
            {
                var data = await _supplierService.editSupplier(_splierSv, txtSupplierName.Text, rtxtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, rtxtMoreInfo.Text, true);
                MessageBox.Show("Đã Sửa thành công!");
                
                this.Close();
            }
        }

        private void D10_EditSupplierDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

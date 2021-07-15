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
    public partial class D09_AddSupplierDialog : Form
    {
        ISupplierService _supplierService { get; set; }
        public D09_AddSupplierDialog()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
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

        //hàm thêm nhà cung cấp
        public async void addSupplier()
        {
            try
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
                    await _supplierService.addNewSupplier(txtSupplierName.Text, rtxtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, rtxtMoreInfo.Text, dtpContactDate.Value, true);
                    MessageBox.Show("Đã thêm thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi rồi, nạp lần đầu đi!");
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            addSupplier();
        }

        private void D09_AddSupplierDialog_Load(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

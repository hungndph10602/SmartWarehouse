using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.CustomerServices;
using SWarehouse.Models.CustomerModels;

namespace SWarehouse.Dialog
{
    public partial class D01_AddCustomerDialog : Form
    {
        private List<F04_QLKhachHangModel> _inputdata = new List<F04_QLKhachHangModel>();
        ICustomerService _customerService { get; set; }
        private List<SP_GetAllCustomer_Result> _customerData { get; set; }
        
        
        public D01_AddCustomerDialog()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            
        }

        private void lbl_TenKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void D01_AddCustomerDialog_Load(object sender, EventArgs e)
        {
            try
            {
                var data = await _customerService.getAllCustomers();
                _customerData = data;
                _inputdata = new List<F04_QLKhachHangModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputdata.Add(new F04_QLKhachHangModel
                        {
                            ID = "KHK_" + data[i].ID.ToString(),
                            TenKhachHang = data[i].Name,
                            DienThoai = data[i].Phone,
                            Email = data[i].Email
                        });
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi ");
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var mailAddressStaff = new System.Net.Mail.MailAddress(email);
                return mailAddressStaff.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public async void AddCustomer()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên Nhân Viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TenKhachHang.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_DienThoai.Text) || txt_DienThoai.Text.Length < 9 || txt_DienThoai.Text.Length > 10 || txt_DienThoai.Text == txt_DienThoai.ToString())
                {
                    MessageBox.Show("Số điện thoại trống hoặc sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DienThoai.Focus();
                    return;
                }
                if (IsValidEmail(txt_Email.Text) == false)
                {
                    MessageBox.Show("Email Không Đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.Focus();
                    return;
                }
                foreach (var item in _inputdata)
                {
                    if (txt_Email.Text.Equals(item.Email))
                    {
                        MessageBox.Show("Email đã được sử dụng");
                        return;
                    }
                    if (txt_DienThoai.Text.Equals(item.DienThoai))
                    {
                        MessageBox.Show("Số điện thoại đã được sử dụng");
                        return;
                    }
                }
                var data = await _customerService.addNewCustomer(txt_TenKhachHang.Text, txt_DienThoai.Text, txt_Email.Text);
                if (data == 0)
                    MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            this.Close();
        }
    }
}

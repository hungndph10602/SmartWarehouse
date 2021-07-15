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
    public partial class D16_editCustomer : Form
    {
        private int _idcustom { get; set; }
        private string _namecustom { get; set; }
        private string _numberphone { get; set; }
        private string _mail { get; set; }
        ICustomerService _customerService { get; set; }
        private List<F04_QLKhachHangModel> _inputdata = new List<F04_QLKhachHangModel>();

        private List<SP_GetAllCustomer_Result> _customerData { get; set; }

        public D16_editCustomer(int maso, string namecustom, string numberphone, string mail)
        {
            InitializeComponent();
            _idcustom = maso;
            _namecustom = namecustom;
            _numberphone = numberphone;
            _mail = mail;
            _customerService = new CustomerService();
            loadtextbox();

        }
        public void loadtextbox()
        {
            txt_editTenKhachHang.Text = _namecustom;
            txt_editDienThoai.Text = _numberphone;
            txt_editEmail.Text = _mail;
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
        private async void D16_editCustomer_Load(object sender, EventArgs e)
        {
            txt_editTenKhachHang.Enabled = false;
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

        private async void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_editTenKhachHang.Text) == true)
                {
                    MessageBox.Show("Vui lòng nhập tên Khách Hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_editTenKhachHang.Focus();
                }
                if (string.IsNullOrEmpty(txt_editDienThoai.Text) || txt_editDienThoai.Text.Length < 9 || txt_editDienThoai.Text.Length > 10 || txt_editDienThoai.Text == txt_editDienThoai.ToString())
                {
                    MessageBox.Show("Số điện thoại trống hoặc sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_editDienThoai.Focus();
                    return;
                }
                if (IsValidEmail(txt_editEmail.Text) == false)
                {
                    MessageBox.Show("Email Không Đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_editEmail.Focus();
                    return;
                }
                foreach (var item in _inputdata)
                {
                    if (txt_editEmail.Text.Equals(item.Email))
                    {
                        MessageBox.Show("Email đã được sử dụng");
                        return;
                    }
                    if (txt_editDienThoai.Text.Equals(item.DienThoai))
                    {
                        MessageBox.Show("Số điện thoại đã được sử dụng");
                        return;
                    }
                }
                var data = await _customerService.editcustomer(_idcustom, txt_editDienThoai.Text, txt_editEmail.Text, true);
                MessageBox.Show("Đã Sửa thành công!");

                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Sửa Không Thành Công !");
            }

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


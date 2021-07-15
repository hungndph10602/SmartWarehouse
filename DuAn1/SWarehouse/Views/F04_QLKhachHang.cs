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
using SWarehouse.Dialog;
using SWarehouse.Utilities;
using System.IO;
using SWarehouse.Models.CustomerModels;

namespace SWarehouse.Views
{
    public partial class F04_QLKhachHang : Form
    {
        public static F04_QLKhachHang mdiobjcustomer;
        private List<SP_GetAllCustomer_Result> _customerData { get; set; }
        private List<F04_QLKhachHangModel> _inputdata = new List<F04_QLKhachHangModel>();
        ICustomerService _customerService { get; set; }
        public F04_QLKhachHang()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            LoadData();

        }

        private void grb_ThôngTinChung_Enter(object sender, EventArgs e)
        {

        }

        public void btn_Sua_Click(object sender, EventArgs e)
        {
            var i = dgv_customer.CurrentRow.Index;
            var id = dgv_customer.Rows[i].Cells[0].Value.ToString();
            var namecustom = dgv_customer.Rows[i].Cells[1].Value.ToString();
            var numberphone = dgv_customer.Rows[i].Cells[2].Value.ToString();
            var mail = dgv_customer.Rows[i].Cells[3].Value.ToString();
            var newid = id.Substring(4);
            D16_editCustomer d16_EditCustomer = new D16_editCustomer(int.Parse(newid) ,namecustom, numberphone, mail);
            d16_EditCustomer.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Sua.Enabled = true;
                var i = dgv_customer.CurrentRow.Index;

            }
            catch (Exception)
            {

            }
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {

        }
        public async void LoadData()
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
                dgv_customer.DataSource = _inputdata;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi ");
            }

        }
        private void F04_QLKhachHang_Load(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                D01_AddCustomerDialog addCustomerDialog = new D01_AddCustomerDialog();
                addCustomerDialog.ShowDialog();
                LoadData();
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {

        }

        private async void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _customerService.searchCustomer(txt_TimKiem.Text);
                _inputdata = new List<F04_QLKhachHangModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {

                        _inputdata.Add(new F04_QLKhachHangModel
                        {
                            TenKhachHang = data[i].Name,
                            DienThoai = data[i].Phone,
                            Email = data[i].Email
                        });
                    }
                }
                dgv_customer.DataSource = _inputdata;
            }
            catch (Exception)
            {

                MessageBox.Show("Tìm Kiếm Lỗi !");
            }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbl_QuanLyKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

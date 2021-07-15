using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Controllers.OrderServices;
using SWarehouse.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWarehouse.Dialog
{
    public partial class D06_AddOrderDialog : Form
    {
        D07_AddOrderDetail _f07dialog { get; set; }
        private IGetIDService _getIDService { get; set; }
        private IOrderServices _OrderService { get; set; }
        public D06_AddOrderDialog()
        {
            InitializeComponent();
            InitializeQLHoaDon();
        }
        private void InitializeQLHoaDon()
        {
            try
            {
                _OrderService = new OrderService();
                _getIDService = new GetIDService();
                loadCustomers();
            }
            catch
            {
                MessageBox.Show("Load data fail");
            }
        }

        public async void loadCustomers()
        {
            try
            {
                var data = await _getIDService.getAllCustomerIDAndName();
                Dictionary<int, string> customer = new Dictionary<int, string>();
                foreach (var item in data)
                {
                    customer.Add(item.ID, item.Name);
                }
                cbx_khachhang.DataSource = new BindingSource(customer, null);
                cbx_khachhang.DisplayMember = "Value";
                cbx_khachhang.ValueMember = "Key";
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private async void addOrder()
        {
            //try
            //{
                var order_id = await _OrderService.insertNewOrder(int.Parse(cbx_khachhang.SelectedValue.ToString()), AppConstants.StaffID, dtp_thoigiantao.Value);
                _f07dialog = new D07_AddOrderDetail(order_id);
                _f07dialog.ShowDialog();
                this.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Fail");
            //}
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            addOrder();
        }

        private void btn_closee_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using SmartWareHouse;
using SWarehouse.Controllers.OrderServices;
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
    public partial class D04_AddOderDetailDialog : Form
    {
        SWareDBEntities _db = new SWareDBEntities();
        private int _grnID { get; set; }
        private IOrderServices _OrderService { get; set; }
        //private IGetIDService _getIDService { get; set; }
        public D04_AddOderDetailDialog()
        {
            InitializeComponent();
            _OrderService = new OrderService();
            loadInsertData();
        }
        private void loadInsertData()
        {
            var listProduct = from lp in _db.PRODUCTS
                              select lp.Name;
            var orderId = (from order in _db.ORDERS
                           select order.ID).Max();
            textBox2.Text = orderId.ToString();
            cbb_product.DataSource = listProduct.ToList();
        }

        private async void addOrderDetail()
        {
            var productId = (from product in _db.PRODUCTS
                             where product.Name == cbb_product.Text
                             select product.ID).SingleOrDefault();
            //_db.SP_CreateOrderDetail(productId, int.Parse(textBox2.Text), int.Parse(num_quantity.Text));
            await _OrderService.insertNewOrderDetail((productId).ToString(), int.Parse(textBox2.Text), int.Parse(num_quantity.Text));
            MessageBox.Show("ok");
            var listOrderDetail = from order_detail in _db.ORDER_DETAILS
                                  select order_detail;
            dgv_OrderDetail.DataSource = listOrderDetail.ToList();

            //qlhd.dgv_OrderDetails.DataSource = listOrderDetail.ToList();
        }
        //private void loadData()
        //{
        //    var listOrderDetail = (from order_detail in _db.ORDER_DETAILS
        //                          select order_detail).FirstOrDefault();
        //    MessageBox.Show(listOrderDetail.Product_ID.ToString());
        //}
        private void btn_add_Click(object sender, EventArgs e)
        {
            addOrderDetail();
        }
    }
}

using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Controllers.OrderServices;
using SWarehouse.Models.BillModels;
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
    public partial class D07_AddOrderDetail : Form
    {
        private static int _orderId { get; set; }
        private static int _quantity { get; set; }
        private IOrderServices _OrderService { get; set; }
        private IGetIDService _getIDService { get; set; }
        private SWareDBEntities _db { get; set; }
        private List<F07_QuanLyHoaDonChiTietModel> _orderDetail = new List<F07_QuanLyHoaDonChiTietModel>();
        public D07_AddOrderDetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            InitializeD07();
        }

        private void InitializeD07()
        {
            try
            {
                _db = new SWareDBEntities();
                _OrderService = new OrderService();
                loadProductQuantity(1);
                _getIDService = new GetIDService();
                loadProduct();
                btn_edit.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Load Data fail");
            }
        }

        /// <summary>
        /// Load Tổng Tiền Phải Thanh Toán
        /// </summary>
        private async void loadTotalMoney()
        {
            try
            {
                var data = await _OrderService.getTotalMoney(_orderId);
                txt_total.Text = data.ToString();
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        /// <summary>
        /// Hủy Hóa Đơn
        /// </summary>
        public async void breakOrder()
        {
            try
            {
                var data = await _OrderService.breakPayOrder(_orderId);
                MessageBox.Show("break successfully!");
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        /// <summary>
        /// Load Sản Phẩm Lên Control
        /// </summary>
        public async void loadProduct()
        {
            try
            {
                var data = await _getIDService.getAllProductIDAndName();
                Dictionary<int, string> product = new Dictionary<int, string>();
                foreach (var item in data)
                {
                    product.Add(item.productId, item.Product_Name);
                }
                cbx_sanpham.DataSource = new BindingSource(product, null);
                cbx_sanpham.DisplayMember = "Value";
                cbx_sanpham.ValueMember = "Key";
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        /// <summary>
        /// Load Chi Tiết Hóa Đơn Vào GridView
        /// </summary>
        /// <param name="data"></param>
        private void loadOrderDetailByOrderId(List<SP_GetAllOrderDetailByOrderId_Result> data)
        {
            try
            {
                _orderDetail = new List<F07_QuanLyHoaDonChiTietModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _orderDetail.Add(new F07_QuanLyHoaDonChiTietModel
                        {
                            TenSP = data[i].Product_Name,
                            Code = data[i].Code,
                            SoLuong = data[i].Quantity,
                            Gia = data[i].Price,
                        });
                    }
                }
                dgv_order_details.DataSource = _orderDetail;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        /// <summary>
        /// Tạo Hóa Đơn Chi Tiết
        /// </summary>
        private async void addOrderDetail()
        {
            try
            {
                await _OrderService.insertNewOrderDetail(int.Parse(cbx_sanpham.SelectedValue.ToString()), _orderId, int.Parse(nud_soluong.Text));
                MessageBox.Show("Add Succesfully!");
                nud_quantityInWarehouse.Text = (int.Parse(nud_quantityInWarehouse.Text) - int.Parse(nud_soluong.Text)).ToString();
                var data = await _OrderService.getOrderDetailByOrderId(_orderId);
                loadTotalMoney();
                loadOrderDetailByOrderId(data);
                btn_edit.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        /// <summary>
        /// Load Số Lượng Sản Phẩm
        /// </summary>
        /// <param name="productId"></param>
        private async void loadProductQuantity(int productId)
        {
            try
            {
                var ProductQuantity = (from product in _db.PRODUCT_STORE
                                       where product.Product_id == productId
                                       select product.Quantity).SingleOrDefault();
                if (ProductQuantity == null)
                {
                    nud_quantityInWarehouse.Text = "0";
                }
                else
                {
                    nud_quantityInWarehouse.Text = ProductQuantity.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        /// <summary>
        /// Thanh Toán Hóa Đơn
        /// </summary>
        private async void payOrder()
        {
            try
            {
                if (Convert.ToDecimal(txt_outputMoney.Text) < 0)
                {
                    MessageBox.Show("THiếu tiền");
                    return;
                }
                await _OrderService.payOrder(_orderId, Convert.ToDecimal(txt_inputMoney.Text), DateTime.Now);
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        /// <summary>
        /// Sửa Số Lượng Sản Phẩm Trong Hóa Đơn
        /// </summary>
        private async void updateOrderProductQuantity()
        {
            try
            {

                int productId = int.Parse(cbx_sanpham.SelectedValue.ToString());
                int quantity = int.Parse(nud_soluong.Text.ToString());
                await _OrderService.updateProductOrderDetailQuantity(_orderId, productId, quantity);
                MessageBox.Show("Update Sucessfully");
                nud_quantityInWarehouse.Text = (int.Parse(nud_quantityInWarehouse.Text) + _quantity - int.Parse(nud_soluong.Text)).ToString();
                var data = await _OrderService.getOrderDetailByOrderId(_orderId);
                loadOrderDetailByOrderId(data);
                btn_edit.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                if (nud_soluong.Value == 0)
                {
                    MessageBox.Show("Bạn phải chọn số lượng!");
                }
                else if (nud_soluong.Value > nud_quantityInWarehouse.Value)
                {
                    MessageBox.Show("Không đủ hàng để cung cấp!");
                }
                else
                {
                    addOrderDetail();
                }

            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_outputMoney.Text))
                {
                    MessageBox.Show("Chưa nhập tiền khách trả!");
                    return;
                }
                decimal ouput = Convert.ToDecimal(txt_outputMoney.Text);
                if (MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (txt_inputMoney.Text == "" || ouput < 0)
                    {
                        MessageBox.Show("Chưa trả tiền đòi trả dép bố về à!");
                        txt_inputMoney.Focus();
                    }
                    else
                    {
                        payOrder();
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }

        }
        private void btn_break_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                breakOrder();
                this.Close();
            }
        }
        private void txt_inputMoney_TextChanged(object sender, EventArgs e)
        {
            if (txt_inputMoney.Text == "")
            {
                txt_inputMoney.Text = "0";
            }
            else
            {
                txt_outputMoney.Text = (decimal.Parse(txt_inputMoney.Text) - decimal.Parse(txt_total.Text)).ToString();
            }
        }
        private void cbx_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProductQuantity(Convert.ToInt32(cbx_sanpham.SelectedValue.ToString()));
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            updateOrderProductQuantity();
        }

        private async void dgv_order_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_order_details.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string productName = dgv_order_details.Rows[e.RowIndex].Cells["TenSPDataGridViewTextBoxColumn"].Value.ToString();
                    cbx_sanpham.Text = productName;
                    nud_soluong.Text = dgv_order_details.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString();
                    _quantity = int.Parse(dgv_order_details.Rows[e.RowIndex].Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString());
                    btn_edit.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chọt nhầm chỗ rồi!^^");
            }
        }
        private void txt_inputMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Nhập text là ứng dụng die như chơi bro!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

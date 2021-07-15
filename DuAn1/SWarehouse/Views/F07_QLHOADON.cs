using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse;
using SWarehouse.Controllers.OrderServices;
using SWarehouse.Dialog;
using SWarehouse.Models.BillModels;
using SWarehouse.Utilities;
using SWarehouse.Controllers.GetIDServices;

namespace SmartWareHouse
{
    public partial class F07_QLHoaDon : Form
    {
        public static F07_QLHoaDon mdiobjBill;
        D06_AddOrderDialog d06_AddOrder;
        private IGetIDService _getIDService { get; set; }
        private IOrderServices _OrderService { get; set; }
        private int _orderID { get; set; }
        private List<F07_QuanLyHoaDonModel> _Order = new List<F07_QuanLyHoaDonModel>();
        private List<F07_QuanLyHoaDonChiTietModel> _OrderDetail = new List<F07_QuanLyHoaDonChiTietModel>();
        public F07_QLHoaDon()
        {
            InitializeComponent();
            InitializeQLHoaDon();
        }
        private async void InitializeQLHoaDon()
        {
            try
            {
                _OrderService = new OrderService();
                _getIDService = new GetIDService();
                d06_AddOrder = new D06_AddOrderDialog();
                var data = await _OrderService.getAllOrder();
                LoadCombobox();
                loadOrderData(data);
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private async void LoadCombobox()
        {
            try
            {
                var staffData = await _getIDService.getAllStaffIdAndName();
                var productData = await _getIDService.getAllProductIDAndName();
                var customerData = await _getIDService.getAllCustomerIDAndName();

                //khach hang
                Dictionary<int, string> customer = new Dictionary<int, string>();
                foreach (var item in customerData)
                {
                    customer.Add(item.ID, item.Name);
                }
                cbx_customer.DataSource = new BindingSource(customer, null);
                cbx_customer.DisplayMember = "Value";
                cbx_customer.ValueMember = "Key";

                //san pham
                Dictionary<int, string> product = new Dictionary<int, string>();
                foreach (var item in productData)
                {
                    product.Add(item.productId, item.Product_Name);
                }
                cbx_product.DataSource = new BindingSource(product, null);
                cbx_product.DisplayMember = "Value";
                cbx_product.ValueMember = "Key";

                //nhanvien
                Dictionary<int, string> staff = new Dictionary<int, string>();
                foreach (var item in staffData)
                {
                    staff.Add(item.ID, item.UserName);
                }
                cbx_staff.DataSource = new BindingSource(staff, null);
                cbx_staff.DisplayMember = "Value";
                cbx_staff.ValueMember = "Key";

            }
            catch
            {
                throw;
            }
        }
        public void loadOrderData(List<SP_GetAllOrder_Result> data)
        {
            try
            {
                _Order = new List<F07_QuanLyHoaDonModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _Order.Add(new F07_QuanLyHoaDonModel
                        {
                            HoaDon = "HD209912" + data[i].orderId,
                            TenKhachHang = data[i].customerName,
                            NguoiTao = data[i].UserName,
                            NgayTao = data[i].CreateDate,
                            TienDua = data[i].Input_Money,
                            TongTien = data[i].TotalMoney,
                            TienTra = data[i].Output_Money,
                            STT = data[i].OrderStatus
                        });
                    }
                }
                dgv_oders.DataSource = _Order;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private void F07_QLHoaDon_Load(object sender, EventArgs e)
        {
            if (AppConstants.Role == 5)
            {
                btn_edit.Enabled = false;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                d06_AddOrder.ShowDialog();
                var data = await _OrderService.getAllOrder();
                loadOrderData(data);
            }
        }
        private async void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xem danh sách không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                D07_AddOrderDetail addOrderDetail = new D07_AddOrderDetail(_orderID);
                addOrderDetail.ShowDialog();
                var data = await _OrderService.getAllOrder();
                loadOrderData(data);
            }
        }
        private async void dgv_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string orderId = "";
                var id = 0;
                if (dgv_oders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //Hiển thị thông tin chi tiết hóa đơn từ hóa đơn được chọn
                    orderId = dgv_oders.Rows[e.RowIndex].Cells["hoaDonDataGridViewTextBoxColumn"].Value.ToString();
                    id = int.Parse(orderId.Substring(8));
                    dgv_oders.CurrentRow.Selected = true;
                    var OrderDetailData = await _OrderService.getOrderDetailByOrderId(id);
                    _OrderDetail = new List<F07_QuanLyHoaDonChiTietModel>();
                    if (OrderDetailData != null)
                    {
                        for (int i = 0; i < OrderDetailData.Count; i++)
                        {
                            _OrderDetail.Add(new F07_QuanLyHoaDonChiTietModel
                            {
                                TenSP = OrderDetailData[i].Product_Name,
                                Code = OrderDetailData[i].Code,
                                Gia = OrderDetailData[i].Price,
                                SoLuong = OrderDetailData[i].Quantity,
                            });
                        }
                    }
                    dgv_orderDetail.DataSource = _OrderDetail;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chọt nhầm chỗ rồi! ^^");
            }
        }

        private void cbx_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string searchCustomer = cbx_customer.Text;
                var data = new List<F07_QuanLyHoaDonModel>();
                foreach (var item in _Order)
                {
                    if (!string.IsNullOrEmpty(searchCustomer))
                        if (item.TenKhachHang.Equals(searchCustomer))
                        {
                            data.Add(item);
                        }
                }
                dgv_oders.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private async void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _OrderService.searchOrderByString(txt_TimKiem.Text);
                _Order = new List<F07_QuanLyHoaDonModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _Order.Add(new F07_QuanLyHoaDonModel
                        {
                            HoaDon = "HD209912" + data[i].orderId,
                            TenKhachHang = data[i].customerName,
                            NguoiTao = data[i].UserName,
                            NgayTao = data[i].CreateDate,
                            TienDua = data[i].Input_Money,
                            TongTien = data[i].TotalMoney,
                            TienTra = data[i].Output_Money,
                            STT = data[i].OrderStatus
                        });
                    }
                }
                dgv_oders.DataSource = _Order;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void cbx_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string searchStaff = cbx_staff.Text;
                var data = new List<F07_QuanLyHoaDonModel>();
                foreach (var item in _Order)
                {
                    if (!string.IsNullOrEmpty(searchStaff))
                        if (item.NguoiTao.Equals(searchStaff))
                        {
                            data.Add(item);
                        }
                }
                dgv_oders.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void cbx_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string searchProduct = cbx_product.Text;
                var data = new List<F07_QuanLyHoaDonChiTietModel>();
                foreach (var item in _OrderDetail)
                {
                    if (!string.IsNullOrEmpty(searchProduct))
                        if (item.TenSP.Equals(searchProduct))
                        {
                            data.Add(item);
                        }
                }
                dgv_orderDetail.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void dtp_dateCreate_CloseUp(object sender, EventArgs e)
        {
            try
            {

                var searchNgayNhap = dtp_dateCreate.Value.ToString("dd/MM/yyyy");
                var data = new List<F07_QuanLyHoaDonModel>();
                foreach (var item in _Order)
                {
                    if (!string.IsNullOrEmpty(searchNgayNhap))
                        if (Convert.ToDateTime(item.NgayTao).ToString("dd/MM/yyyy").Equals(searchNgayNhap))
                        {
                            data.Add(item);
                        }
                }
                dgv_oders.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
    }
}

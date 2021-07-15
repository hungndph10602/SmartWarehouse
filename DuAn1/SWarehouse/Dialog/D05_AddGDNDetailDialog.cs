using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Utilities;
using SWarehouse.Controllers.GoodsDeliveryNoteServices;
using SWarehouse.Models.GDNModels;
using SWarehouse.Controllers.ProductServices;

namespace SWarehouse.Dialog
{
    public partial class D05_AddGDNDetailDialog : Form
    {
        IGoodsDeliveryNoteService _GDNServices { get; set; }
        IProductServices _productServices { get; set; }

        private string[] GDNStatus = new string[] { "Chờ xử lý", "Đã hoàn thành", "Huỷ", "Vjp" };
        private int _gdnId { get; set; }
        private int _nrID { get; set; }
        private int _warehouseID { get; set; }
        private List<F06_QLXuatKhoChiTiet> _inputDetailData = new List<F06_QLXuatKhoChiTiet>();
        private List<SP_getAllProductIDAndName_Result> _pro = new List<SP_getAllProductIDAndName_Result>();
        private List<F06_QLXuatKhoModel> _inputData = new List<F06_QLXuatKhoModel>();
        public D05_AddGDNDetailDialog(int GDNId, int NRID, int warehouseID)
        {
            InitializeComponent();
            _GDNServices = new GoodsDeliveryNoteService();
            _productServices = new ProductService();
            _gdnId = GDNId;
            _nrID = NRID;
            _warehouseID = warehouseID;
            loadCboData();
            loadDgvData();
            LoadDetailData(_gdnId);
        }
        public async void loadCboData()
        {
            var productData = await _GDNServices.getAllProductIDNName();

            _pro = productData;
            //sanpham
            Dictionary<int, string> products = new Dictionary<int, string>();
            foreach (var item in productData)
            {
                products.Add(item.productId, item.Product_Name);
            }
            cboProduct.DataSource = new BindingSource(products, null);
            cboProduct.DisplayMember = "Value";
            cboProduct.ValueMember = "Key";
        }
        private async void LoadDetailData(int grnID)
        {
            try
            {
                var data = await _GDNServices.getGDNDetail(grnID);
                _inputDetailData = new List<F06_QLXuatKhoChiTiet>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputDetailData.Add(new F06_QLXuatKhoChiTiet
                        {
                            SanPham = data[i].ProductName,
                            SoLuongXuat = data[i].Quantity_of_request.ToString(),
                            SoLuongXuatThuc = data[i].Actual_Amount.ToString(),
                        });
                    }
                }
                dgvDetailGDN.DataSource = _inputDetailData;
            }
            catch
            {
                throw;
            }
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn lưu dữ liệu phiếu xuất này không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _GDNServices.updateGDNStatus(_gdnId);
                    await _GDNServices.payGDN(_gdnId);
                    this.Close();
                    MessageBox.Show("Đã cập nhật thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void D05_AddGDNDetailDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public async void loadDgvData()
        {
            dgvDetailGDN.DataSource = await _GDNServices.getGDNDetail(_gdnId);
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboProduct.Text) == true)
                {
                    MessageBox.Show("Vui lòng chọn 1 mã sản phẩm!");
                    cboProduct.Focus();
                    return;
                }
                if (nmrActualAmount.Value <= 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng thực là 1 số dương!");
                    nmrActualAmount.Focus();
                    return;
                }
                if (nmrRequestAmount.Value <= 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng xuất là 1 số dương!");
                    nmrRequestAmount.Focus();
                    return;
                }
                if (nmrActualAmount.Value > nmrRequestAmount.Value)
                {
                    MessageBox.Show("Số lượng xuất vượt quá số lượng yêu cầu!");
                    return;
                }
                if(nmrActualAmount.Value > nud_least.Value)
                {
                    MessageBox.Show("Số lượng trong kho không đủ!");
                    return;
                }
                await _GDNServices.updateProductAmmount(_gdnId, int.Parse(nmrActualAmount.Value.ToString()), int.Parse(cboProduct.SelectedValue.ToString()));
                MessageBox.Show("Đã thêm thành công!");
                LoadDetailData(_gdnId);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có sản phẩm này trong phiếu xuất!");
            }
        }

        private void D05_AddGDNDetailDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private async void dgvDetailGDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvDetailGDN.CurrentRow.Index;
            dgvDetailGDN.CurrentRow.Selected = true;
            cboProduct.SelectedIndex = cboProduct.FindString(dgvDetailGDN.Rows[i].Cells["sanPhamDataGridViewTextBoxColumn"].Value.ToString());
            nmrRequestAmount.Value = int.Parse(dgvDetailGDN.Rows[i].Cells[1].Value.ToString());
            try
            {
                var productQuantity = await _GDNServices.getQuantityInWarehouse(_warehouseID, int.Parse(cboProduct.SelectedValue.ToString()));
                nud_least.Value = (decimal)productQuantity.Quantity;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void grb_ChiTietPhieuXuat_Enter(object sender, EventArgs e)
        {

        }

        private void cboProduct_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

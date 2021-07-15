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
using SWarehouse.Controllers.GRNServices;
using SWarehouse.Dialog;
using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Models.GRNModels;

namespace SWarehouse.Views
{
    public partial class F05_QlNhapkho : Form
    {
        private string[] GRNStatus = new string[] { "Status", "Đã thanh toán", "Hoá đơn đang nợ", "Chờ xử lý", "Huỷ" };
        private IGetIDService _getIDService { get; set; }
        private IGRNService _grnService { get; set; }
        private int _id { get; set; }
        string searchNhanVien = string.Empty;
        string searchNgayNhap = string.Empty;
        string searchTrangThai = string.Empty;
        string searchKho = string.Empty;
        private D02_AddGRNDialog _AddGRNDialog { get; set; }
        private List<ManageWarehouseInputModel> _inputData = new List<ManageWarehouseInputModel>();
        private List<ManageWarehouseInputDetaiModel> _inputDetailData = new List<ManageWarehouseInputDetaiModel>();
        public F05_QlNhapkho()
        {
            InitializeComponent();
            _grnService = new GRNService();
            _getIDService = new GetIDService();
            InitializeWarehouseInput();

        }
        private void F05_QlNhapkho_Load(object sender, EventArgs e)
        {
            if (AppConstants.Role == 3 || AppConstants.Role == 1)
            {
                btn_edit.Enabled = false;
            }
        }
        private async void InitializeWarehouseInput()
        {
            try
            {
                var staffData = await _getIDService.getAllStaffIdAndName();
                var supplierData = await _getIDService.getAllSupplierIDAndName();
                var warehouseData = await _getIDService.getAllWarehouseIDAndName();
                var productData = await _getIDService.getAllProductIDAndName();

                //san pham
                Dictionary<int, string> product = new Dictionary<int, string>();
                foreach (var item in productData)
                {
                    product.Add(item.productId, item.Product_Name);
                }
                cbx_matHang.DataSource = new BindingSource(product, null);
                cbx_matHang.DisplayMember = "Value";
                cbx_matHang.ValueMember = "Key";

                //kho
                Dictionary<int, string> warehouse = new Dictionary<int, string>();
                foreach (var item in warehouseData)
                {
                    warehouse.Add(item.ID, item.Name);
                }
                cbx_kho.DataSource = new BindingSource(warehouse, null);
                cbx_kho.DisplayMember = "Value";
                cbx_kho.ValueMember = "Key";

                //Nha cung cap
                Dictionary<int, string> supplier = new Dictionary<int, string>();
                foreach (var item in supplierData)
                {
                    supplier.Add(item.ID, item.Name);
                }
                cbx_nhaCungCap.DataSource = new BindingSource(supplier, null);
                cbx_nhaCungCap.DisplayMember = "Value";
                cbx_nhaCungCap.ValueMember = "Key";

                //nhanvien
                Dictionary<int, string> staff = new Dictionary<int, string>();
                foreach (var item in staffData)
                {
                    staff.Add(item.ID, item.UserName);
                }
                cbx_nhanVien.DataSource = new BindingSource(staff, null);
                cbx_nhanVien.DisplayMember = "Value";
                cbx_nhanVien.ValueMember = "Key";

            }
            catch
            {
                throw;
            }
            var data = await _grnService.getAllGRN();
            LoadData(data);
        }
        private void LoadData(List<SP_GetAllGRN_Result> data)
        {
            try
            {
                _inputData = new List<ManageWarehouseInputModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if(data[i].TotalMoney== null)
                        {
                            data[i].TotalMoney = 0;
                        }
                        if (data[i].MoneyPaid == null)
                        {
                            data[i].MoneyPaid = 0;
                        }
                        string status = GRNStatus[int.Parse(data[i].Status.ToString())];
                        _inputData.Add(new ManageWarehouseInputModel
                        {
                            PhieuNhap = AppConstants.BaseGRNID + data[i].ID.ToString(),
                            NhanVien = data[i].UserName,
                            Kho = data[i].Warehouse_Name,
                            NgayLap = DateTime.Parse(data[i].CreateDate.ToString()).ToString("dd/MM/yyyy"),
                            TrangThai = status,
                            Detail = data[i].MoreInfo,
                            SoLuongMatHang = data[i].CountProduct.ToString(),
                            TongTien = (decimal)data[i].TotalMoney,
                            ChuaThanhToan = (decimal)data[i].TotalMoney - (decimal)data[i].MoneyPaid
                        });
                    }
                }
                dgv_ThongTinChung.DataSource = _inputData;

            }
            catch
            {
                throw;
            }
        }
        private async void LoadDetailData(int grnID)
        {
            try
            {
                var data = await _grnService.getGRNDetailByGRNId(grnID);
                _inputDetailData = new List<ManageWarehouseInputDetaiModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputDetailData.Add(new ManageWarehouseInputDetaiModel
                        {
                            MatHang = data[i].ProductName,
                            NhaCungCap = data[i].SupplierName,
                            SoLuong = int.Parse(data[i].Quantity_of_request.ToString()),
                            HangThieu = int.Parse(data[i].Quantity_of_request.ToString()) - int.Parse(data[i].Actual_Amount.ToString()),
                            LoHang = "",
                            GiaNhap = decimal.Parse(data[i].Cost.ToString()),
                            GiaBan = decimal.Parse(data[i].Price.ToString())
                        });
                    }
                }
                dgv_detail.DataSource = _inputDetailData;
            }
            catch
            {
                throw;
            }
        }

        private void dgv_ThongTinChung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_ThongTinChung.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_ThongTinChung.CurrentRow.Selected = true;
                    var data = dgv_ThongTinChung.Rows[e.RowIndex].Cells["phieuNhapDataGridViewTextBoxColumn"].Value.ToString();
                    _id = int.Parse(data.Substring(9));
                    LoadDetailData(_id);
                }
            }
            catch
            {
            }
        }
        private async void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _grnService.searchGRNbyString(txt_search.Text);
                _inputData = new List<ManageWarehouseInputModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        string status = GRNStatus[int.Parse(data[i].Status.ToString())];
                        _inputData.Add(new ManageWarehouseInputModel
                        {
                            PhieuNhap = AppConstants.BaseGRNID + data[i].ID.ToString(),
                            NhanVien = data[i].UserName,
                            Kho = data[i].Warehouse_Name,
                            NgayLap = DateTime.Parse(data[i].CreateDate.ToString()).ToString("dd/MM/yyyy"),
                            TrangThai = status,
                            Detail = data[i].MoreInfo,
                            SoLuongMatHang = data[i].CountProduct.ToString(),
                            TongTien = (decimal)data[i].TotalMoney,
                            ChuaThanhToan = (decimal)data[i].TotalMoney - (decimal)data[i].MoneyPaid
                        });
                    }
                }
                dgv_ThongTinChung.DataSource = _inputData;

            }
            catch
            {
                throw;
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            _AddGRNDialog = new D02_AddGRNDialog();
            _AddGRNDialog.ShowDialog();
            var data = await _grnService.getAllGRN();
            LoadData(data);
        }

        private async void btn_edit_Click(object sender, EventArgs e)
        {
            D03_AddGRNDetailDialog AddGRNDetailDialog = new D03_AddGRNDetailDialog(_id);
            AddGRNDetailDialog.ShowDialog();
            LoadDetailData(_id);
            var data = await _grnService.getAllGRN();
            LoadData(data);
        }

        private async void btn_done_Click(object sender, EventArgs e)
        {
            PayGRNDialog payGRNDialog = new PayGRNDialog(_id);
            payGRNDialog.ShowDialog();
            var data = await _grnService.getAllGRN();
            LoadData(data);
        }

        private void cbx_nhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchNhanVien = cbx_nhanVien.Text;
            var data = new List<ManageWarehouseInputModel>();
            foreach (var item in _inputData)
            {
                if (!string.IsNullOrEmpty(searchNhanVien))
                    if (item.NhanVien.Equals(searchNhanVien))
                    {
                        data.Add(item);
                    }
            }
            dgv_ThongTinChung.DataSource = data;
        }

        private void dtp_ngayLap_CloseUp(object sender, EventArgs e)
        {
            searchNgayNhap = dtp_ngayLap.Value.ToString("dd/MM/yyyy");
            var data = new List<ManageWarehouseInputModel>();
            foreach (var item in _inputData)
            {
                if (!string.IsNullOrEmpty(searchNgayNhap))
                    if (item.NgayLap.Equals(searchNgayNhap))
                    {
                        data.Add(item);
                    }
            }
            dgv_ThongTinChung.DataSource = data;
        }

        private void cbx_kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchKho = cbx_kho.Text;
            var data = new List<ManageWarehouseInputModel>();
            foreach (var item in _inputData)
            {
                if (!string.IsNullOrEmpty(searchKho))
                    if (item.Kho.Equals(searchKho))
                    {
                        data.Add(item);
                    }
            }
            dgv_ThongTinChung.DataSource = data;
        }

        private void rb_dakiem_Click(object sender, EventArgs e)
        {
            searchTrangThai = "True";
            var data = new List<ManageWarehouseInputModel>();
            foreach (var item in _inputData)
            {
                if (!string.IsNullOrEmpty(searchTrangThai))
                    if (item.TrangThai.ToString().Equals(searchTrangThai))
                    {
                        data.Add(item);
                    }
            }
            dgv_ThongTinChung.DataSource = data;
        }

        private void rb_chuakiem_Click(object sender, EventArgs e)
        {
            searchTrangThai = "False";
            var data = new List<ManageWarehouseInputModel>();
            foreach (var item in _inputData)
            {
                if (!string.IsNullOrEmpty(searchTrangThai))
                    if (item.TrangThai.ToString().Equals(searchTrangThai))
                    {
                        data.Add(item);
                    }
            }
            dgv_ThongTinChung.DataSource = data;
        }

        private void cbx_matHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var searchMatHang = cbx_matHang.Text;
            var data = new List<ManageWarehouseInputDetaiModel>();
            foreach (var item in _inputDetailData)
            {
                if (!string.IsNullOrEmpty(searchMatHang))
                    if (item.MatHang.ToString().Equals(searchMatHang))
                    {
                        data.Add(item);
                    }
            }
            dgv_detail.DataSource = data;
        }

        private void cbx_nhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            var searchNhaCungCap = cbx_nhaCungCap.Text;
            var data = new List<ManageWarehouseInputDetaiModel>();
            foreach (var item in _inputDetailData)
            {
                if (!string.IsNullOrEmpty(searchNhaCungCap))
                    if (item.NhaCungCap.ToString().Equals(searchNhaCungCap))
                    {
                        data.Add(item);
                    }
            }
            dgv_detail.DataSource = data;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SWarehouse.Utilities;
using SWarehouse.Controllers.GoodsDeliveryNoteServices;
using SWarehouse.Dialog;
using SWarehouse.Models.GDNModels;
namespace SWarehouse
{
    public partial class F06_QLXuatKho : Form
    {
        private string[] GDNStatus = new string[] {  "Đã hoàn thành", "Chưa hoàn thành", "Chờ xử lý", "Huỷ" };
        GoodsDeliveryNoteService _GDNServices { get; set; }
        Dialog.D04_AddGDNDialog _AddGDNDialog { get; set; }
        private int _id { get; set; }
        string searchNhanVien = string.Empty;
        string searchKho = string.Empty;
        string searchNgayXuat = string.Empty;
        string searchTrangThai = string.Empty;
        int _warehouseID { get; set; }
        Dialog.D05_AddGDNDetailDialog _AddGDNDetailDialog { get; set; }
        private List<F06_QLXuatKhoModel> _inputData = new List<F06_QLXuatKhoModel>();
        private List<F06_QLXuatKhoChiTiet> _inputDetailData = new List<F06_QLXuatKhoChiTiet>();
        public F06_QLXuatKho()
        {
            InitializeComponent();
            _GDNServices = new GoodsDeliveryNoteService();
            btn_Sua.Enabled = false;
            loadCboData();
        }
        //load dữ liệu lên cbb
        public async void loadCboData()
        {
            try
            {
                var warehouseData = await _GDNServices.getAllWareHouseIDNName();
                var staffData = await _GDNServices.getAllStaffIDNName();
                var productData = await _GDNServices.getAllProductIDNName();
                //kho
                Dictionary<int, string> kho = new Dictionary<int, string>();
                foreach (var item in warehouseData)
                {
                    kho.Add(item.ID, item.Name);
                }
                cboKho.DataSource = new BindingSource(kho, null);
                cboKho.DisplayMember = "Value";
                cboKho.ValueMember = "Key";
                //staff
                Dictionary<int, string> staff = new Dictionary<int, string>();
                foreach (var item in staffData)
                {
                    staff.Add(item.ID, item.UserName);
                }
                cboNhanVien.DataSource = new BindingSource(staff, null);
                cboNhanVien.DisplayMember = "Value";
                cboNhanVien.ValueMember = "Key";
                //product
                Dictionary<int, string> prod = new Dictionary<int, string>();
                foreach (var item in productData)
                {
                    prod.Add(item.productId, item.Product_Name);
                }
                cboSanPham.DataSource = new BindingSource(prod, null);
                cboSanPham.DisplayMember = "Value";
                cboSanPham.ValueMember = "Key";
                var data = await _GDNServices.getAllGDN();
                LoadData(data);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi");
            }
        }
        //load dữ liệu chi tiết
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
                            SoLuongXuatThuc =data[i].Actual_Amount.ToString(),
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
        //sự kiện click dgv
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var warehouse =  dgvGDN.Rows[e.RowIndex].Cells["khoDataGridViewTextBoxColumn"].FormattedValue.ToString();
                _warehouseID = int.Parse(warehouse.Substring(6));
                object value = dgvGDN.Rows[e.RowIndex].Cells["phieuXuatDataGridViewTextBoxColumn"].FormattedValue;
            var stt = dgvGDN.Rows[e.RowIndex].Cells["trangThaiDataGridViewTextBoxColumn"].Value.ToString();
                if (stt.Equals("Chưa hoàn thành") ==true|| stt.Equals("Hủy") == true || stt.Equals("Chờ xử lý") == true)
            {
                btn_Sua.Enabled = true;
            }
            else
            {
                btn_Sua.Enabled = false;
            }
                if (dgvGDN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                   dgvGDN.CurrentRow.Selected = true;
                    var data = dgvGDN.Rows[e.RowIndex].Cells["phieuXuatDataGridViewTextBoxColumn"].Value.ToString();
                    _id = int.Parse(data.Substring(9));
                    LoadDetailData(_id);
                }
            }
            catch(Exception)
            {
            }
        }

        //load
        private void F06_QLXuatKho_Load(object sender, EventArgs e)
        {
            if (AppConstants.Role == 3)
            {
                btn_Sua.Enabled = false;
            }
        }
        //btn tìm kiếm
        private async void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text) == true)
                {
                    MessageBox.Show("Không tìm kiếm được phiếu xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                }
                else
                {
                    loadCboData();
                    dgvGDN.DataSource = await _GDNServices.searchGDN(txtSearch.Text);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi");
            }

        }
       //btn thêm
        private void btn_Them_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (MessageBox.Show("Bạn có muốn thêm không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    D04_AddGDNDialog addGDN = new D04_AddGDNDialog();
                    addGDN.ShowDialog();
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Lỗi rồi, nạp lần đầu đi");
            //}
        }
        //btn thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //btn sửa
        private async void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var i = dgvGDN.CurrentRow.Index;
                    var id = dgvGDN.Rows[i].Cells[0].Value.ToString();
                    var newid = id.Substring(9);
                    var nrId= dgvGDN.Rows[i].Cells[3].Value.ToString();
                    var newNrId = nrId.Substring(8);
                    D05_AddGDNDetailDialog d05 = new D05_AddGDNDetailDialog(int.Parse(newid),int.Parse(newNrId),_warehouseID);
                    d05.ShowDialog();
                    var data = await _GDNServices.getAllGDN();
                    LoadData(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //load dữ liệu
        private void LoadData(List<SP_GetAllGDN_Result> data)
        {
            //try
            //{
                _inputData = new List<F06_QLXuatKhoModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        string status = GDNStatus[int.Parse(data[i].Status.ToString())];
                        _inputData.Add(new F06_QLXuatKhoModel
                        {
                            PhieuXuat = AppConstants.BaseGDNID + data[i].ID.ToString(),
                            Kho = data[i].WarehouseName,
                            NhanVien = data[i].UserName,
                            RequestNote = AppConstants.BaseRequestID + data[i].Request_ID.ToString(),
                            NgayXuat = DateTime.Parse(data[i].CreateDate.ToString()).ToString("dd/MM/yyyy"),
                            TrangThai = status
                        });
                    }
                }
                dgvGDN.DataSource = _inputData;

            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            //}
        }
        //sự kiện tìm kiếm cbo Nhân viên
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                searchNhanVien = cboNhanVien.Text;
                var data = new List<F06_QLXuatKhoModel>();
                foreach (var item in _inputData)
                {
                    if (!string.IsNullOrEmpty(searchNhanVien))
                        if (item.NhanVien.Equals(searchNhanVien))
                        {
                            data.Add(item);
                        }
                }
                dgvGDN.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện thay đổi cbo kho
        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                searchKho = cboKho.Text;
                var data = new List<F06_QLXuatKhoModel>();
                foreach (var item in _inputData)
                {
                    if (!string.IsNullOrEmpty(searchKho))
                        if (item.Kho.Equals(searchKho))
                        {
                            data.Add(item);
                        }
                }
                dgvGDN.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện dtp 
        private void dtpNgayXuat_CloseUp(object sender, EventArgs e)
        {
            searchNgayXuat = dtpNgayXuat.Value.ToString("dd/MM/yyyy");
            var data = new List<F06_QLXuatKhoModel>();
            foreach (var item in _inputData)
            {
                if (!string.IsNullOrEmpty(searchNgayXuat))
                    if (item.NgayXuat.Equals(searchNgayXuat))
                    {
                        data.Add(item);
                    }
            }
            dgvGDN.DataSource = data;
        }

        private void dgvGDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Dialog;
using SWarehouse.Models.NoteRequestModels;
using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Controllers.NoteRequestServices;

namespace SWarehouse.Views
{
    public partial class F12_NoteRequest : Form
    {
        private string[] GDNStatus = new string[] { "Chờ xử lý", "Đã hoàn thành"};
        private IGetIDService _getIDService { get; set; }
        string searchNgay = string.Empty;
        bool searchStt;
        string searchProduct;
        private int _id { get; set; }
        private INoteRequestServices _noteRequestServices { get; set; }
        private List<F12_NoteRequestModel> _inputData = new List<F12_NoteRequestModel>();
        private List<F12_NoteRequestDetailModel> _inputDetailData = new List<F12_NoteRequestDetailModel>();
        public F12_NoteRequest()
        {
            InitializeComponent();
            _getIDService = new GetIDService();
            _noteRequestServices = new NoteRequestServices();
            InitializeNoteRequest();
        }
        private async void InitializeNoteRequest()
        {
            try
            {
                var staffData = await _getIDService.getAllStaffIdAndName();
                var productData = await _getIDService.getAllProductIDAndName();
                //nhanvien
                Dictionary<int, string> staff = new Dictionary<int, string>();
                foreach (var item in staffData)
                {
                    staff.Add(item.ID, item.UserName);
                }
                cbx_nhanVien.DataSource = new BindingSource(staff, null);
                cbx_nhanVien.DisplayMember = "Value";
                cbx_nhanVien.ValueMember = "Key";
                //san pham
                Dictionary<int, string> product = new Dictionary<int, string>();
                foreach (var item in productData)
                {
                    product.Add(item.productId, item.Product_Name);
                }
                cbx_matHang.DataSource = new BindingSource(product, null);
                cbx_matHang.DisplayMember = "Value";
                cbx_matHang.ValueMember = "Key";
                LoadDataToDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //load dữ liệu lên dgv
        private async void LoadDataToDGV()
        {
            //try
            //{
                var data = await _noteRequestServices.getAllDR();
                _inputData = new List<F12_NoteRequestModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                    int a=0;
                    if (data[i].DRStatus.Equals(true))
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                        string status = GDNStatus[a];
                        _inputData.Add(new F12_NoteRequestModel
                        {
                            PhieuYeuCau = "PYC_763221" + data[i].RequestID,
                            NhanVien = data[i].UserName,
                            NgayTao = DateTime.Parse(data[i].DRCreateDate.ToString()).ToString("dd/MM/yyyy"),
                            TrangThai = status
                        });
                    }
                }
                dgv_yeuCau.DataSource = _inputData;
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            //}
        }
        //btn đóng
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //btn thêm
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tạo yêu cầu không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                D11_NoteRequestDialog d10 = new D11_NoteRequestDialog();
                d10.ShowDialog();
            }
        }
        //btn sửa
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                D12_NoteRequestDetailDialog d10 = new D12_NoteRequestDetailDialog(_id);
                d10.ShowDialog();
            }
        }
        //sự kiện cbo nhân viên thay đổi
        private void cbx_nhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var data = new List<F12_NoteRequestModel>();
                foreach (var item in _inputData)
                {
                    if (!string.IsNullOrEmpty(cbx_nhanVien.Text))
                        if (item.NhanVien.Equals(cbx_nhanVien.Text))
                        {
                            data.Add(item);
                        }
                }
                dgv_yeuCau.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện cbo mặt hàng thay đổi
        private void cbx_matHang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                searchProduct = cbx_matHang.Text;
                var data = new List<F12_NoteRequestDetailModel>();
                foreach (var item in _inputDetailData)
                {
                    if (!string.IsNullOrEmpty(cbx_matHang.Text.ToString()))
                        if (item.TenSanPham.Equals(cbx_matHang.Text))
                        {
                            data.Add(item);
                        }
                }
                dgvNoteRequestDetail.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện cbo nhân viên thay đổi
        private void cbx_nhanVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var data = new List<F12_NoteRequestModel>();
                foreach (var item in _inputData)
                {
                    if (!string.IsNullOrEmpty(cbx_nhanVien.Text))
                        if (item.NhanVien.Equals(cbx_nhanVien.Text))
                        {
                            data.Add(item);
                        }
                }
                dgv_yeuCau.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện dtp ngày thay đổi
        private void dtp_datecreate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                searchNgay = dtp_datecreate.Value.ToString("dd/MM/yyyy");
                var data = new List<F12_NoteRequestModel>();
                foreach (var item in _inputData)
                {
                    if (!string.IsNullOrEmpty(searchNgay))
                        if (item.NgayTao.Equals(searchNgay))
                        {
                            data.Add(item);
                        }
                }
                dgv_yeuCau.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //load data lên dgv khi cbb phiếu xuất thay đổi
        private async void LoadNRData(int NRID)
        {
            try
            {
                var data = await _noteRequestServices.searchNR(NRID);
            _inputData = new List<F12_NoteRequestModel>();
            if (data != null)
            {
                for (int i = 0; i < data.Count; i++)
                {
                        string status = GDNStatus[int.Parse(data[i].Status.ToString())];
                        _inputData.Add(new F12_NoteRequestModel
                    {
                        PhieuYeuCau = data[i].request_id.ToString(),
                        NhanVien = data[i].UserName,
                        NgayTao = DateTime.Parse(data[i].CreateDate.ToString()).ToString("dd/MM/yyyy"),
                        TrangThai = status
                    });
                }
            }
            dgv_yeuCau.DataSource = _inputData;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //btn tìm kiếm
        private  void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadNRData(int.Parse(txt_TimKiem.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy phiếu yêu cầu!");
            }
        }
        //load data lên dgv chi tiết
        private async void LoadDetailData(int NRID)
        {
            try
            {
                var data = await _noteRequestServices.getAllDRDetailByID(NRID);
            _inputDetailData = new List<F12_NoteRequestDetailModel>();
            if (data != null)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    _inputDetailData.Add(new F12_NoteRequestDetailModel
                    {
                        MaSanPham = data[i].Product_ID.ToString(),
                        TenSanPham = data[i].ProductName,
                        SoLuong = int.Parse(data[i].Quantity.ToString()),
                    });
                }
            }
            dgvNoteRequestDetail.DataSource = _inputDetailData;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        private void LoadData(List<Sp_GetAllDR_Result> data)
        {
            //try
            //{
                _inputData = new List<F12_NoteRequestModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        string status = GDNStatus[int.Parse(data[i].DRStatus.ToString())];
                        _inputData.Add(new F12_NoteRequestModel
                        {
                            PhieuYeuCau = "PYC_763221" + data[i].RequestID,
                            NhanVien = data[i].UserName,
                            NgayTao = DateTime.Parse(data[i].DRCreateDate.ToString()).ToString("dd/MM/yyyy"),
                            TrangThai = status
                        });
                    }
                }
                dgv_yeuCau.DataSource = _inputData;

            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            //}
        }
        //sự kiện bấm vào dgv
        private void dgv_yeuCau_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                #region set readonly while status done
                object value = dgv_yeuCau.Rows[e.RowIndex].Cells["trangThaiDataGridViewTextBoxColumn"].Value.ToString();
                if (value.Equals("Chờ xử lý"))
                {
                    dgv_yeuCau.Rows[e.RowIndex].Cells["trangThaiDataGridViewTextBoxColumn"].ReadOnly = false;
                    btn_edit.Enabled = true;
                }
                else
                {
                    dgv_yeuCau.Rows[e.RowIndex].Cells["trangThaiDataGridViewTextBoxColumn"].ReadOnly = true;
                    btn_edit.Enabled = false;
                }
                #endregion
                if (dgv_yeuCau.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_yeuCau.CurrentRow.Selected = true;
                    var data = dgv_yeuCau.Rows[e.RowIndex].Cells["phieuYeuCauDataGridViewTextBoxColumn"].Value.ToString();
                    _id = int.Parse(data.Substring(10));
                    LoadDetailData(_id);
                    //if (e.ColumnIndex == 3)
                    //{
                    //    if (Convert.ToBoolean(dgv_yeuCau.Rows[e.RowIndex].Cells["trangThaiDataGridViewTextBoxColumn"].EditedFormattedValue) == true)
                    //    {
                    //        var GRNData = await _noteRequestServices.getAllDR();
                    //        LoadData(GRNData);
                    //    }
                    //}

                }
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện rad checked
        private void Rdo_active_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                searchStt = Rdo_active.Checked; ;
                var data = new List<F12_NoteRequestModel>();
                foreach (var item in _inputData)
                {

                    if (item.TrangThai.Equals(searchStt))
                    {
                        data.Add(item);
                    }
                }
                dgv_yeuCau.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện double click
        private async void dgv_yeuCau_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                dgv_yeuCau.CurrentRow.Selected = true;
                var i = dgv_yeuCau.CurrentRow.Index;
                var data = dgv_yeuCau.Rows[i].Cells["phieuYeuCauDataGridViewTextBoxColumn"].Value.ToString();
                _id = int.Parse(data.Substring(10));
                var NRRQ = await _noteRequestServices.updateNRStatus(_id);
                LoadDataToDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }

        private void F12_NoteRequest_Load(object sender, EventArgs e)
        {

        }

      
    }
}

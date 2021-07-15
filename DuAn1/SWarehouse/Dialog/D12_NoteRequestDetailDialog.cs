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
using SWarehouse.Controllers.NoteRequestServices;
using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Models.NoteRequestModels;

namespace SWarehouse.Dialog
{
    public partial class D12_NoteRequestDetailDialog : Form
    {
        NoteRequestServices _requestServices { get; set; }
        GetIDService _getIDService { get; set; }
        private int _NRQID { get; set; }
        private List<F12_NoteRequestDetailModel> _inputDetailData = new List<F12_NoteRequestDetailModel>();
        public D12_NoteRequestDetailDialog(int NRQID)
        {
            InitializeComponent();
            _requestServices = new NoteRequestServices();
            _getIDService = new GetIDService();
            _NRQID = NRQID;
            loadCboData();
        }
        public async void loadCboData()
        {
            var productData = await _getIDService.getAllProductIDAndName();
            //sanpham
            Dictionary<int, string> products = new Dictionary<int, string>();
            foreach (var item in productData)
            {
                products.Add(item.productId, item.Product_Name);
            }
            cboSanPham.DataSource = new BindingSource(products, null);
            cboSanPham.DisplayMember = "Value";
            cboSanPham.ValueMember = "Key";
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _requestServices.addNoteRequestDetail(int.Parse(cboSanPham.SelectedValue.ToString()), _NRQID, int.Parse(nmrQuantity.Value.ToString()));
                MessageBox.Show("Đã thêm thành công!");
                loadDataToDgv(_NRQID);
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có sản phẩm này trong yêu cầu xuất!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn lưu dữ liệu phiếu yêu cầu này không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                  
                    this.Close();
                    MessageBox.Show("Đã cập nhật thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void D12_NoteRequestDetailDialog_Load(object sender, EventArgs e)
        {

        }
        public async void loadDataToDgv(int _NRQID)
        {
            try
            {
                var data = await _requestServices.getAllDRDetailByID(_NRQID);
                _inputDetailData = new List<F12_NoteRequestDetailModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputDetailData.Add(new F12_NoteRequestDetailModel
                        {
                            MaSanPham = "SP_" + data[i].Product_ID,
                            TenSanPham = data[i].ProductName.ToString(),
                            SoLuong = int.Parse(data[i].Quantity.ToString()),
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

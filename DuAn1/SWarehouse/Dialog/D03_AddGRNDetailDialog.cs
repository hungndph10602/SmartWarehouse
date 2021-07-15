using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.GRNServices;
using SWarehouse.Controllers.GetIDServices;
namespace SWarehouse.Dialog
{
    public partial class D03_AddGRNDetailDialog : Form
    {
        private int _grnID { get; set; }
        private IGRNService _gRNService { get; set; }
        private IGetIDService _getIDService { get; set; }
        public D03_AddGRNDetailDialog(int GRNId)
        {
            InitializeComponent();
            _grnID = GRNId;
            _gRNService = new GRNService();
            _getIDService = new GetIDService();
            InitializeAddGRNDetailDialog();
            LoadData();
        }
        public async void InitializeAddGRNDetailDialog()
        {
            var supplierData = await _getIDService.getAllSupplierIDAndName();
            var productData = await _getIDService.getAllProductIDAndName();
            //suplier
            Dictionary<int, string> supplier = new Dictionary<int, string>();
            foreach (var item in supplierData)
            {
                supplier.Add(item.ID, item.Name);
            }
            cbx_supplier.DataSource = new BindingSource(supplier, null);
            cbx_supplier.DisplayMember = "Value";
            cbx_supplier.ValueMember = "Key";
            //Product
            Dictionary<int, string> product = new Dictionary<int, string>();
            foreach (var item in productData)
            {
                product.Add(item.productId, item.Product_Name);
            }
            cbx_product.DataSource = new BindingSource(product, null);
            cbx_product.DisplayMember = "Value";
            cbx_product.ValueMember = "Key";

        }
        private async void btn_ok_Click(object sender, EventArgs e)
        {
            if (dgv_GRNDetail.RowCount == 0)
            {
                MessageBox.Show("Chi tiết trống , không thể hoàn thành");
            }
            else
            {
                await _gRNService.updateQuantityToWarehouse(_grnID);
                var result = MessageBox.Show("Bạn có muốn thanh toán không?","Thanh toán",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    PayGRNDialog payGRNDialog = new PayGRNDialog(_grnID);
                    payGRNDialog.ShowDialog();
                }
                this.Close();
            }
            this.Close();
        }
        private async void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            var data = await _gRNService.insertNewGRNDetail(int.Parse(cbx_product.SelectedValue.ToString()), _grnID, int.Parse(cbx_supplier.SelectedValue.ToString()), (int)nud_request.Value, (int)nud_actual.Value, nud_cost.Value);
            LoadData();
        }
        private async void LoadData()
        {
            dgv_GRNDetail.DataSource = await _gRNService.getGRNDetailByGRNId(_grnID);
        }
    }
}

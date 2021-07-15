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
using SWarehouse.Controllers.GRNServices;
using SWarehouse.Controllers.GetIDServices;

namespace SWarehouse.Dialog
{
    public partial class D02_AddGRNDialog : Form
    {
       
        D03_AddGRNDetailDialog _AddGRNDetailDialog { get; set; }
        private IGetIDService _getIDService { get; set; }
        IGRNService _gRNService { get; set; }
        private int? GRNId { get; set; }
        public D02_AddGRNDialog()
        {
            InitializeComponent();
            _gRNService = new GRNService();
            _getIDService = new GetIDService();
            LoadData();
        }

        private async void btn_ok_Click(object sender, EventArgs e)
        {
            GRNId = await _gRNService.insertNewGRN(int.Parse(cbx_warehouse.SelectedValue.ToString()),dtp_ngayNhap.Value,txt_description.Text);
            _AddGRNDetailDialog = new D03_AddGRNDetailDialog(int.Parse(GRNId.ToString()));
            _AddGRNDetailDialog.ShowDialog();
            this.Close();
        }
        private async void LoadData()
        {
            var warehouseData = await _getIDService.getAllWarehouseIDAndName();
            //Warehouse
            Dictionary<int, string> warehouse = new Dictionary<int, string>();
            foreach (var item in warehouseData)
            {
                warehouse.Add(item.ID, item.Name);
            }
            cbx_warehouse.DataSource = new BindingSource(warehouse, null);
            cbx_warehouse.DisplayMember = "Value";
            cbx_warehouse.ValueMember = "Key";
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
namespace SWarehouse.Dialog
{
    public partial class D04_AddGDNDialog : Form
    {
        GoodsDeliveryNoteService _GDNServices { get; set; }
        private int _GDNId;
        private int _NRID;
        public D04_AddGDNDialog()
        {
            InitializeComponent();
            _GDNServices = new GoodsDeliveryNoteService();
            loadCboData();
        }
      
        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboWareHouseId.Text) == true)
            {
                MessageBox.Show("Vui lòng chọn 1 mã kho!");
            }
            else
            {
                var GDN_ID = await _GDNServices.addGDN( int.Parse(cboWareHouseId.SelectedValue.ToString()), int.Parse(cboNRId.SelectedValue.ToString()), DateTime.Now, rtxtMoreInf.Text) ;
                _GDNId = int.Parse(GDN_ID.ToString());
                _NRID = int.Parse(cboNRId.SelectedValue.ToString());
                MessageBox.Show("Thêm thành công!");
                D05_AddGDNDetailDialog addGDNDDetail = new D05_AddGDNDetailDialog(int.Parse(_GDNId.ToString()),int.Parse(_NRID.ToString()), int.Parse(cboWareHouseId.SelectedValue.ToString()));
                addGDNDDetail.ShowDialog();
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public async void loadCboData()
        {
            var warehouseData = await _GDNServices.getAllWareHouseIDNName();
            
            //kho
            Dictionary<int, string> kho = new Dictionary<int, string>();
            foreach (var item in warehouseData)
            {
                kho.Add(item.ID, item.Name);
            }
            cboWareHouseId.DataSource = new BindingSource(kho, null);
            cboWareHouseId.DisplayMember = "Value";
            cboWareHouseId.ValueMember = "Key";
            //phiếu yc nhập
            Dictionary<int, string> pn = new Dictionary<int, string>();
            try
            {
                var NRData = await _GDNServices.getAllUnDoneNR();
                if (NRData != null)
                {
                    foreach (var item in NRData)
                    {
                        pn.Add(item.RequestId, item.Status);
                    }
                    cboNRId.DataSource = new BindingSource(pn, null);
                    cboNRId.DisplayMember = "Value";
                    cboNRId.ValueMember = "Key";
                }
                else
                {
                    MessageBox.Show("Không có yêu cầu nhập nào!");
                    cboNRId.Enabled = false;
                }
            }
            catch (Exception)
            {
               
            }
        }
        private void D04_AddGDNDialog_Load(object sender, EventArgs e)
        {

        }

        private void grb_ThongTinChung_Enter(object sender, EventArgs e)
        {

        }
    }
}

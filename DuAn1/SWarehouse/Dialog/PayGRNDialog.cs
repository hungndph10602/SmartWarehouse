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
using SWarehouse.Utilities;

namespace SWarehouse.Dialog
{
    public partial class PayGRNDialog : Form
    {
        private int _grnID { get; set; }
        IGRNService _grnService { get; set; }
        public PayGRNDialog( int grn_id)
        {
            InitializeComponent();
            _grnID = grn_id;
            _grnService = new GRNService();
            loadData();
        }
        private async void loadData()
        {
            txt_grn.Text = AppConstants.BaseGRNID + _grnID;
            try
            {
                var data = await _grnService.getAmountOwn(_grnID);
                if (data != null)
                {
                    if (data.TotalMoney == null)
                    {
                        data.TotalMoney = 0;
                    }
                    if (data.MoneyPaid == null)
                    {
                        data.MoneyPaid = 0;
                    }
                    nud_least.Value = (decimal)(data.TotalMoney - data.MoneyPaid);
                }
                else
                {
                    nud_least.Value = 0;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load số tiền còn lại cần thanh toán!");
            }
        }

        private async void btn_pay_Click(object sender, EventArgs e)
        {
            if (nud_pay.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập tiền thanh toán");
                return;
            }
            if (nud_pay.Value > nud_least.Value)
            {
                MessageBox.Show("Số tiền trả vượt quá số tiền còn lại!");
                return;
            }
            var result = MessageBox.Show("Xác nhận thanh toán?","Thanh toán",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    await _grnService.PayGRN(_grnID, nud_pay.Value);
                    MessageBox.Show("Thanh toán thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                }
                this.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

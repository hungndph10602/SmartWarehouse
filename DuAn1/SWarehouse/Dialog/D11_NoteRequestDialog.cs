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
using SWarehouse.Controllers.NoteRequestServices;

namespace SWarehouse.Dialog
{
    public partial class D11_NoteRequestDialog : Form
    {
        NoteRequestServices _NoteRequestServices { get; set; }
        private int _NRID;
        public D11_NoteRequestDialog()
        {
            InitializeComponent();
            _NoteRequestServices = new NoteRequestServices();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var NRRQ = await _NoteRequestServices.addNoteRequest(DateTime.Now, rtb_moreInfo.Text, false);
            _NRID = NRRQ;
            MessageBox.Show("Thêm thành công!");
            D12_NoteRequestDetailDialog d12 = new D12_NoteRequestDetailDialog(_NRID);
            d12.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

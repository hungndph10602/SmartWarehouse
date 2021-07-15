using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.UserServices;
namespace SWarehouse
{
    public partial class F10_DoiMatKhau : Form
    {
        IUserSevice _userSevice { get; set; }
        public F10_DoiMatKhau()
        {
            InitializeComponent();
            _userSevice = new UserService();
        }
       
        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            var data = _userSevice.changeUserPassWord(txt_newpass.Text);
            if (data != null)
            {
                if (data.Result !=0)
                {
                    MessageBox.Show("Oke ban Oi");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Loi roi ban ei");
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Loi roi ban ei");
            this.Close();
            return;
        }
    }
}

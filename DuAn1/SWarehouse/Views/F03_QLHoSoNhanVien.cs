using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.StaffServices;
using SWarehouse.Utilities;

namespace SWarehouse.Views
{
    public partial class F03_QLHoSoNhanVien : Form
    {
        IStaffServices _staffServices { get; set; }
        private int _id { get; set; }

        private SP_GetStaffById_Result _staffData
        {
            get => StaffData;
            set => _staffData = value;
        }
        public SP_GetStaffById_Result StaffData { get; set; }
        public F03_QLHoSoNhanVien(int ID)
        {
            InitializeComponent();
            _id = ID;
            _staffServices = new StaffServices();
            InitializeQLHoSoNhanVien();
            loadStaffData();
        }
        public Image ByteToImg(byte[] byteString)
        {

            if (byteString == null)
                return null ;
            if (byteString.Length > 100)
            {
                byte[] imgBytes = byteString;
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            return null;
        }
        public void loadStaffData()
        {
            txt_staffID.Text = _id.ToString();
            txt_staffName.Text = StaffData.StaffName;
            txt_staffEmail.Text = StaffData.Email;
            txt_staffPhone.Text = StaffData.Phone;
            rtb_staffAddress.Text = StaffData.Address;
            PB_staffprofile.Image = ByteToImg(StaffData.Image);
        }
        public async void InitializeQLHoSoNhanVien()
        {
            try
            {

                var data = await _staffServices.getStaffById(_id);
                if (data != null)
                {
                    if (data.StaffName != "")
                    {
                        StaffData = data;
                    }
                    else
                    {
                        StaffData = new SP_GetStaffById_Result();
                    }
                }
                else
                {
                    StaffData = new SP_GetStaffById_Result();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                F10_DoiMatKhau dmk = new F10_DoiMatKhau();
                dmk.ShowDialog();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Models.StaffModels;
using SWarehouse.Controllers.UserServices;
using SWarehouse.Controllers.StaffServices;
using System.IO;

namespace SWarehouse.Views
{
    public partial class F11_FogotPassword : Form

    {
        StaffServices _staffServices { get; set; }
        private List<SP_GetAllStaff_Result> _staffData { get; set; }
        private List<F09__QLNhanVienModel> _inputdata = new List<F09__QLNhanVienModel>();
        IUserSevice _userSevice { get; set; }
        public F11_FogotPassword()
        {
            InitializeComponent();
            _userSevice = new UserService();
            _staffServices = new StaffServices();
            loaddata();
        }
        //chuyển array sang ảnh
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        //chuyển từ byte sang hình ảnh
        public Image ByteToImg(byte[] byteString)
        {
            if (byteString == null)
                return null;
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
        //lấy dữ liệu
        public async void loaddata()
        {
            try
            {
                var data = await _staffServices.getAllStaff();
                _staffData = data;
                _inputdata = new List<F09__QLNhanVienModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i].Image != null)
                        {
                            _inputdata.Add(new F09__QLNhanVienModel
                            {
                                TenDangNhap = data[i].UserName,
                                Email = data[i].Email,
                                TenNhanVien = data[i].StaffName,
                                TrangThai = data[i].Status.ToString(),
                                DiaChi = data[i].Address,
                                SDT = data[i].Phone,
                                Luong = decimal.Parse(data[i].Salary.ToString()),
                                Img = ByteToImg(data[i].Image)
                            });
                        }

                        else
                            _inputdata.Add(new F09__QLNhanVienModel
                            {
                                TenDangNhap = data[i].UserName,
                                Email = data[i].Email,
                                TenNhanVien = data[i].StaffName,
                                TrangThai = data[i].Status.ToString(),
                                DiaChi = data[i].Address,
                                SDT = data[i].Phone,
                                Luong = decimal.Parse(data[i].Salary.ToString()),
                                Img = null,
                            });
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Lỗi :" + s);
            }
        }
        //btn đóng
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //tạo chuỗi ngẫu nhiên
        public string chuoiRandom(int size, bool lowercase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowercase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        //tạo số ngẫu nhiên
        public int soRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //hàm gửi mail
        public void SendEmail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential cred = new NetworkCredential("ngthln1201@gmail.com", "nguyenthanh15");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("ngthln1201@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu! (-5% lương tháng này)";
                msg.Body = "Chào anh/chị!, \n Mật khẩu mới của anh/chị là :" + matKhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email khôi phục đã được gửi tới bạn!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không gửi được email, vui lòng thử lại!");
            }

        }
        //btn quên mk
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập email muốn khôi phục mật khẩu!");
                    txtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txt_username.Text))
                {
                    MessageBox.Show("Vui lòng nhập user name muốn khôi phục mật khẩu!");
                    txt_username.Focus();
                }
                else
                {
                    foreach (var item in _inputdata)
                    {
                        if (txtEmail.Text.Equals(item.Email) == true && txt_username.Text.Equals(item.TenDangNhap) == true)
                        {

                            string mkm = chuoiRandom(3, true) + soRandom(1000, 9999);
                            var data = _userSevice.changeUserPassWord(mkm);
                            //bnv.doiMatKhau(txtEmail.Text, bnv.layMktheoEmail(txtEmail.Text), mkm);
                            SendEmail(txtEmail.Text, mkm);
                            return;
                        }
                    }
                    MessageBox.Show("Không có dữ liệu Email và tài khoản!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
    }
}

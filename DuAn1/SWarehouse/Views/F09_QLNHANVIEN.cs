using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.StaffServices;
using SWarehouse.Models.StaffModels;
using SWarehouse;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using SWarehouse.Dialog;

namespace SmartWareHouse
{
    public partial class F09_QLNhanVien : Form
    {
        IStaffServices _staffServices { get; set; }
        private string[] Staffstatus = new string[] { "Không Hoạt động", "Hoạt Động" };
        private byte[] _image { get; set; }
        private int _staffID { get; set; }
        private string _staffName { get; set; }
        private List<SP_GetAllStaff_Result> _staffData { get; set; }
        private List<F09__QLNhanVienModel> _inputdata = new List<F09__QLNhanVienModel>();
        public F09_QLNhanVien()
        {
            InitializeComponent();
            _staffServices = new StaffServices();
            loaddata();
        }
        //Sử Dụng SP_getallstaff để lấy hết dữ liệu nhân viên ra
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
                        string status = Staffstatus[Convert.ToInt32(data[i].Status)];
                        if (data[i].Image != null)
                        {
                            _inputdata.Add(new F09__QLNhanVienModel
                            {
                                TenDangNhap = data[i].UserName,
                                Email = data[i].Email,
                                TenNhanVien = data[i].StaffName,
                                TrangThai = status,
                                DiaChi = data[i].Address,
                                SDT = data[i].Phone,
                                Luong = decimal.Parse(data[i].Salary.ToString()),
                                Img = ByteToImg(data[i].Image),
                                Role = data[i].RoleName

                            });
                        }

                        else
                            _inputdata.Add(new F09__QLNhanVienModel
                            {
                                TenDangNhap = data[i].UserName,
                                Email = data[i].Email,
                                TenNhanVien = data[i].StaffName,
                                TrangThai = status,
                                DiaChi = data[i].Address,
                                SDT = data[i].Phone,
                                Luong = decimal.Parse(data[i].Salary.ToString()),
                                Img = null,
                                Role = data[i].RoleName
                            });
                    }
                }
                dgv_QLNV.DataSource = _inputdata;
            }
            catch (Exception s)
            {
                MessageBox.Show("Lỗi :" + s);
            }
        }
        private void F09_QLNhanVien_Load(object sender, EventArgs e)
        {
            txt_urd.Visible = false;
            loaddata();
            txt_username.Enabled = false;
            btn_createAccount.Enabled = false;
        }
        // check validate của email
        bool IsValidEmail(string email)
        {
            try
            {
                var mailAddressStaff = new System.Net.Mail.MailAddress(email);
                return mailAddressStaff.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //Phương thức Thêm Mới Nhân Viên
        public async void addStaff()
        {
            bool status;
            try
            {
                if (string.IsNullOrEmpty(txt_nameStaff.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên Nhân Viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nameStaff.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_numberphone.Text) || txt_numberphone.Text.Length < 9 || txt_numberphone.Text.Length > 10 || txt_numberphone.Text == sdt.ToString())
                {
                    MessageBox.Show("Số điện thoại trống hoặc sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_numberphone.Focus();
                    return;
                }
                if (rdo_active.Checked == false && rdo_unactive.Checked == false)
                {
                    MessageBox.Show("Hãy Lữa chọn trạng thái hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_salary.Text))
                {
                    MessageBox.Show("Lương Không Đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_salary.Focus();
                    return;
                }
                if (IsValidEmail(txt_email.Text) == false)
                {
                    MessageBox.Show("Email Không Đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                    return;
                }
                if (rdo_active.Checked == false)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                foreach (var item in _inputdata)
                {
                    if (txt_email.Text.Equals(item.Email))
                    {
                        MessageBox.Show("Email đã được sử dụng");
                        return;
                    }
                    if (txt_numberphone.Text.Equals(item.SDT))
                    {
                        MessageBox.Show("Số điện thoại đã được sử dụng");
                        return;
                    }
                }
                images = converImgToByte();

                var data = await _staffServices.addNewStaff(txt_nameStaff.Text, RTB_adress.Text, txt_numberphone.Text, txt_email.Text, decimal.Parse(txt_salary.Text), images, false);
                if (data == 0)
                    MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Nhập Lại!");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                addStaff();
            }
            loaddata();
        }
        private void dgv_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_QLNV.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue != null)
                {
                    dgv_QLNV.CurrentRow.Selected = true;
                    if (_staffData[e.RowIndex].StaID != 0)
                        _staffID = _staffData[e.RowIndex].StaID;
                    txt_username.Text = dgv_QLNV.Rows[e.RowIndex].Cells["tendangnhap"].FormattedValue.ToString();
                    txt_email.Text = dgv_QLNV.Rows[e.RowIndex].Cells
                        ["email"].FormattedValue.ToString();
                    txt_nameStaff.Text = dgv_QLNV.Rows[e.RowIndex].Cells["tennhanvien"].FormattedValue.ToString();
                    _staffName = txt_nameStaff.Text;
                    if (dgv_QLNV.Rows[e.RowIndex].Cells
                        ["trangthai"].Value.ToString() == "Hoạt Động")
                    {
                        rdo_unactive.Checked = false;
                        rdo_active.Checked = true;
                    }
                    else
                    {
                        rdo_unactive.Checked = true;
                        rdo_active.Checked = false;
                    }
                    RTB_adress.Text = dgv_QLNV.Rows[e.RowIndex].Cells
                        ["diachi"].FormattedValue.ToString();
                    txt_numberphone.Text = dgv_QLNV.Rows[e.RowIndex].Cells
                        ["sdt"].FormattedValue.ToString();
                    txt_salary.Text = dgv_QLNV.Rows[e.RowIndex].Cells
                        ["Luong"].FormattedValue.ToString();
                    if (_staffData[e.RowIndex].Image != null)
                    {
                        PB_imgstaff.Image = ByteToImg(_staffData[e.RowIndex].Image);
                        _image = _staffData[e.RowIndex].Image;
                    }
                    else
                    {
                        PB_imgstaff.Image = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Click Vào Phần Chứa Dữ Liệu");
            }
            if (string.IsNullOrEmpty(txt_username.Text) == true)
            {
                btn_createAccount.Enabled = true;
            }
            else
            {
                btn_createAccount.Enabled = false;
            }
        }
        //Phương thức chỉnh sửa thông tin nhân viên
        public async void editStaff()
        {
            string mail = txt_email.Text;
            string phone = txt_numberphone.Text;
            string status = "";
            try
            {
                if (string.IsNullOrEmpty(txt_nameStaff.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên Nhân Viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nameStaff.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_numberphone.Text) || txt_numberphone.Text.Length < 9 || txt_numberphone.Text.Length > 10)
                {
                    MessageBox.Show("Số điện thoại trống hoặc sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_numberphone.Focus();
                    return;
                }
                if (rdo_active.Checked == false && rdo_unactive.Checked == false)
                {
                    MessageBox.Show("Hãy Lữa chọn trạng thái hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_salary.Text))
                {
                    MessageBox.Show("Lương Không Đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_salary.Focus();
                    return;
                }
                if (IsValidEmail(txt_email.Text) == false)
                {
                    MessageBox.Show("Email Không Đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                    return;
                }
                else
                {
                    if (rdo_active.Checked == true)
                    {
                        status = "True";
                    }
                    if (rdo_unactive.Checked == true)
                    {
                        status = "False";
                    }
                    //var countphone = 0;
                    //var countemail = 0;
                    foreach (var item in _inputdata)
                    {
                         if (txt_email.Text.Equals(item.Email))
                        {
                            MessageBox.Show("Email đã được sử dụng");
                            return;
                        }
                        else if (txt_numberphone.Text.Equals(item.SDT) )
                        {
                            MessageBox.Show("Số điện thoại đã được sử dụng");
                            return;
                        }
                    }
                    //if (countphone > 1)
                    //{
                    //    MessageBox.Show("Số Điện Thoại đã được sử dụng");
                    //    return;
                    //}
                    //if (countemail > 1)
                    //{
                    //    MessageBox.Show("Email đã được sử dụng");
                    //    return;
                    //}
                    //images = converImgToByte();
                    if (string.IsNullOrEmpty(txt_urd.Text))
                    {
                        images = _image;
                    }
                    else
                    {
                        images = converImgToByte();
                    }
                    var data = await _staffServices.editStaff(_staffID, RTB_adress.Text, txt_numberphone.Text, txt_email.Text, decimal.Parse(txt_salary.Text), txt_nameStaff.Text, images, Convert.ToBoolean(status));
                    if (data == 0)
                        MessageBox.Show("Đã Sửa thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Nhập Lại!");
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editStaff();
            }

            loaddata();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            this.Close();
        }
        private async void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _staffServices.SearchStaffByString(txt_Search.Text);
                _inputdata = new List<F09__QLNhanVienModel>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        string status = Staffstatus[Convert.ToInt32(data[i].Status)];
                        _inputdata.Add(new F09__QLNhanVienModel
                        {
                            TenDangNhap = "DN_" + data[i].UserName,
                            Email = data[i].Email,
                            TenNhanVien = data[i].StaffName,
                            TrangThai = status,
                            DiaChi = data[i].Address,
                            SDT = data[i].Phone,
                            Luong = decimal.Parse(data[i].Salary.ToString()),
                            Img = ByteToImg(data[i].Image),
                            Role = data[i].RoleName
                        });
                    }
                }
                dgv_QLNV.DataSource = _inputdata;
            }
            catch (Exception s)
            {
                MessageBox.Show("lỗi Vui Lòng Tìm Kiếm Lại ");
            }
        }
        byte[] images = null;
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        public void uploadimg()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_urd.Text = fileDialog.FileName;
                    PB_imgstaff.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch (Exception)
            {
                throw;
            }
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

        private byte[] converImgToByte()
        {
            if (!string.IsNullOrEmpty(txt_urd.Text))
            {
                FileStream fs;
                fs = new FileStream(txt_urd.Text, FileMode.Open, FileAccess.Read);
                byte[] picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, int.Parse(fs.Length.ToString()));
                fs.Close();
                return picbyte;
            }
            return null;
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            uploadimg();
        }
        private void PB_imgstaff_Click(object sender, EventArgs e)
        {

        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            D13_CreateAccount createAccountDialog = new D13_CreateAccount(_staffID, _staffName);
            createAccountDialog.ShowDialog();
            loaddata();
        }
    }


}


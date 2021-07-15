using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Controllers.StaffServices;

namespace SWarehouse.Dialog
{
    public partial class D13_CreateAccount : Form
    {
        private IGetIDService _getIDService { get; set; }
        private IStaffServices _staffServices { get; set; }
        private List<SP_GetAllStaff_Result> _inputData { get; set; }
        private int _staffID { get; set; }
        private string _staffName { get; set; }
        private string _username { get; set; }
        private bool _isOK = false;
        string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ", };

        string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", };
        public D13_CreateAccount(int staffID, string staffName)
        {
            InitializeComponent();
            _getIDService = new GetIDService();
            _staffServices = new StaffServices();
            _staffID = staffID;
            _staffName = staffName;
            LoadData();
        }
        private async void LoadData()
        {
            var role = await _getIDService.getAllRoleIdAndName();
            txt_displayName.Text = _staffName;
            Dictionary<int, string> supplier = new Dictionary<int, string>();
            foreach (var item in role)
            {
                supplier.Add(item.ID, item.Name);
            }
            cbx_role.DataSource = new BindingSource(supplier, null);
            cbx_role.DisplayMember = "Value";
            cbx_role.ValueMember = "Key";

            InitializeUsername();
        }
        private async void btn_AddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_displayName.Text))
            {
                MessageBox.Show("Tên hiển thị không được để trống");
                return;
            }
            if (txt_password.Text.Count() < 6)
            {
                if (string.IsNullOrEmpty(txt_password.Text))
                    MessageBox.Show("Mật khẩu không được để trống");
                else
                    MessageBox.Show("Mật khẩu phải dài hơn 6 ký tự!");
                txt_password.Focus();
                return;
            }
            var result = MessageBox.Show("Bạn có muốn tạo tài khoản", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                var data = await _staffServices.CreateAccount(_staffID, txt_username.Text, txt_password.Text, int.Parse(cbx_role.SelectedValue.ToString()), txt_displayName.Text);
                if (data == 0)
                {
                    MessageBox.Show("Tạo tài khoản thất bại!");
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.Close();
                }
            }

        }
        private async void InitializeUsername()
        {
            string[] name = _staffName.Split(' ');
            int count = name.Count();
            for (int i = 0; i < count; ++i)
            {
                if (i != count - 1)
                {
                    _username += name[i][0];
                }
                else
                {
                    _username = name[i] + _username;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                _username = _username.Replace(arr1[i], arr2[i]);
                _username = _username.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            _username = _username.ToLower();
            _inputData = await _staffServices.getAllStaff();

            getValidUsername();
        }
        private void getValidUsername()
        {
            string username = _username;
            int count = _username.Count();
            for (int i = 0; i < _inputData.Count; i++)
            {
                username = _username;
                if (i != 0)
                    username += i;
                if (_inputData != null)
                {
                    foreach (var item in _inputData)
                    {
                        if (item.UserName != null)
                            if (item.UserName.Substring(0, count).Equals(_username))
                            {
                                if (!username.Equals(item.UserName))
                                {
                                    txt_username.Text = username;
                                    return;
                                }
                            }
                    }
                    
                }
            }
            txt_username.Text = _username;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void D13_CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

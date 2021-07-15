using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Controllers.SupplierServices;
using SWarehouse.Dialog;
using SWarehouse.Models.SupplierModels;

namespace SmartWarehouse.Views
{
    public partial class F08_QLNhaCungCap : Form
    {
        ISupplierService _supplierService { get; set; }
        string searchNhacc = string.Empty;
        string searchEmail = string.Empty;
        string searchNgay = string.Empty;
        private List<F08_SupplierModels> _inputData = new List<F08_SupplierModels>();
        //load dữ liệu
        public F08_QLNhaCungCap()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            origin();
            loadCboData();
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                var data = await _supplierService.getAllSuppliers();
                _inputData = new List<F08_SupplierModels>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputData.Add(new F08_SupplierModels
                        {
                            SupplierID = "NCC_" + data[i].ID.ToString(),
                            SupplierName = data[i].Name,
                            DiaChi = data[i].Address,
                            Email = data[i].Email,
                            NgayTao = DateTime.Parse(data[i].ContractDate.ToString()).ToString("dd/MM/yyyy"),
                            DienThoai = data[i].Phone,
                            ThongTinKhac = data[i].Moreinfo
                        });
                    };
                }
                dgvSupplier.DataSource = _inputData;
            }
            catch
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //hhàm kiểm tra EMail
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //nút tìm kiếm nhà cung cấp
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text) == true)
                {
                    MessageBox.Show("Không tìm kiếm được nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvSupplier.DataSource = await _supplierService.searchSupplier(txtSearch.Text);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //nút sửa nhà cung cấp
      
        //datagridview
        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //hàm trả lại như ban đầu
        public void origin()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            dtpContactDate.Value = DateTime.Now;
        }
        //nút thêm nhà cuung cấp
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                D09_AddSupplierDialog d09 = new D09_AddSupplierDialog();
                d09.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        public async void loadCboData()
        {
            try
            {
                var suppdata = await _supplierService.getAllSuppliers();
                //kho
                Dictionary<int, string> kho = new Dictionary<int, string>();
                foreach (var item in suppdata)
                {
                    kho.Add(item.ID, item.Name);
                }
                cbx_name.DataSource = new BindingSource(kho, null);
                cbx_name.DisplayMember = "Value";
                cbx_name.ValueMember = "Key";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        //sự kiện tìm kiếm nếu cbo name thay dổi
        private async void cbx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var data = await _supplierService.searchSupplier(cbx_name.Text);
                _inputData = new List<F08_SupplierModels>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputData.Add(new F08_SupplierModels
                        {
                            SupplierID = "NCC_" + data[i].ID.ToString(),
                            SupplierName = data[i].Name,
                            DiaChi = data[i].Address,
                            Email = data[i].Email,
                            NgayTao = DateTime.Parse(data[i].ContractDate.ToString()).ToString("dd/MM/yyyy"),
                            DienThoai = data[i].Phone,
                            ThongTinKhac = data[i].Moreinfo
                        });
                    };
                }
                dgvSupplier.DataSource = _inputData;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
            
        }
        //sự kkiện email thay đổi
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var data = new List<F08_SupplierModels>();
                foreach (var item in _inputData)
                {
                    if (!string.IsNullOrEmpty(searchEmail))
                        if (item.SupplierName.Equals(searchEmail))
                        {
                            data.Add(item);
                        }
                }
                dgvSupplier.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
        }
        private async void dtpContactDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                var data =await _supplierService.searchSupplier(dtpContactDate.Value.ToString());
                _inputData = new List<F08_SupplierModels>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputData.Add(new F08_SupplierModels
                        {
                            SupplierID = "NCC_" + data[i].ID.ToString(),
                            SupplierName = data[i].Name,
                            DiaChi = data[i].Address,
                            Email = data[i].Email,
                            NgayTao = DateTime.Parse(data[i].ContractDate.ToString()).ToString("dd/MM/yyyy"),
                            DienThoai = data[i].Phone,
                            ThongTinKhac = data[i].Moreinfo
                        });
                    };
                }
                dgvSupplier.DataSource = _inputData;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
 
        }
        //btn sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var i = dgvSupplier.CurrentRow.Index;
                var id = dgvSupplier.Rows[i].Cells[0].Value.ToString();
                var name = dgvSupplier.Rows[i].Cells[1].Value.ToString();
                var diaChi = dgvSupplier.Rows[i].Cells[2].Value.ToString();
                var email = dgvSupplier.Rows[i].Cells[3].Value.ToString();
                var ngayTao = dgvSupplier.Rows[i].Cells[4].Value.ToString();
                var dienThoai = dgvSupplier.Rows[i].Cells[5].Value.ToString();
                var newid = id.Substring(4);
                D10_EditSupplierDialog d10 = new D10_EditSupplierDialog(int.Parse(newid) , name, diaChi, email, ngayTao, dienThoai);
                d10.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }
            
        }
        //btn đóng
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       //sự kiện dtp
        private async void dtpContactDate_CloseUp_1(object sender, EventArgs e)
        {
            try
            {
                var data = await _supplierService.searchSupplier(dtpContactDate.Value.ToString());
                _inputData = new List<F08_SupplierModels>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _inputData.Add(new F08_SupplierModels
                        {
                            SupplierID = "NCC_" + data[i].ID.ToString(),
                            SupplierName = data[i].Name,
                            DiaChi = data[i].Address,
                            Email = data[i].Email,
                            NgayTao = DateTime.Parse(data[i].ContractDate.ToString()).ToString("dd/MM/yyyy"),
                            DienThoai = data[i].Phone,
                            ThongTinKhac = data[i].Moreinfo
                        });
                    };
                }
                dgvSupplier.DataSource = _inputData;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi, nạp lần đầu đi!");
            }

        }
    }
}

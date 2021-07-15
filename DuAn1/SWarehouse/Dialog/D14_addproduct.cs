using SWarehouse.Controllers.GetIDServices;
using SWarehouse.Controllers.ProductServices;
using SWarehouse.Models.ProductModels;
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

namespace SWarehouse.Dialog
{
    public partial class D14_addproduct : Form
    {
        private IGetIDService _getIDService { get; set; }
        IProductServices _productServices { get; set; }
        private List<ProductModels> _inputdata = new List<ProductModels>();
        public D14_addproduct()
        {
            InitializeComponent();
            initializeD14();
        }

        private void initializeD14()
        {
            _productServices = new ProductService();
            _getIDService = new GetIDService();
            loadCombobox();
        }
        private async void loadCombobox()
        {

            var colorData = await _getIDService.getColor();
            var unitData = await _getIDService.getUnitName();
            var brandData = await _getIDService.getBrand();

            //khach hang
            Dictionary<int, string> colorList = new Dictionary<int, string>();
            foreach (var item in colorData)
            {
                colorList.Add(item.ID, item.Name);
            }
            cbx_color.DataSource = new BindingSource(colorList, null);
            cbx_color.DisplayMember = "Value";
            cbx_color.ValueMember = "Key";

            //san pham
            Dictionary<int, string> unitList = new Dictionary<int, string>();
            foreach (var item in unitData)
            {
                unitList.Add(item.UnitId, item.UnitName);
            }
            cbb_addunit.DataSource = new BindingSource(unitList, null);
            cbb_addunit.DisplayMember = "Value";
            cbb_addunit.ValueMember = "Key";

            //nhanvien
            Dictionary<int, string> brandList = new Dictionary<int, string>();
            foreach (var item in brandData)
            {
                brandList.Add(item.ID, item.Name);
            }
            cbx_brand.DataSource = new BindingSource(brandList, null);
            cbx_brand.DisplayMember = "Value";
            cbx_brand.ValueMember = "Key";
        }

        byte[] images = null;
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
                    PB_addproduct.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Image ByteToImg(byte[] byteString)
        {

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
        private async void addProduct()
        {
            var data = await _productServices.getAllProduct();
            _inputdata = new List<ProductModels>();
            for (int i = 0; i < data.Count; i++)
            {
                _inputdata.Add(new ProductModels
                {
                    productName = data[i].Product_Name,
                    code = data[i].Code,
                    unitName = data[i].UnitName,
                    colorName = data[i].ColorName,
                    brandName = data[i].Brand_Name,
                    Image = null,
                    ShortDescription = data[i].ShortDescription,
                    LongDescription = data[i].LongDescription,
                    UserManual = data[i].ShortDescription,
                    Status = data[i].Status,
                }); ;


            }
            foreach (var item in _inputdata)
            {
                if (txt_addnameproduct.Text.Equals(item.productName))
                {
                    MessageBox.Show("Tên Sản Phẩm đã được sử dụng");
                    return;
                }
                if (txt_code.Text.Equals(item.code))
                {
                    MessageBox.Show("Code đã được sử dụng");
                    return;
                }

            }
            await _productServices.createProduct(txt_addnameproduct.Text, txt_code.Text, int.Parse(cbb_addunit.SelectedValue.ToString()), int.Parse(cbx_color.SelectedValue.ToString()), int.Parse(cbx_brand.SelectedValue.ToString()),new decimal(), images, txt_addshortdescreption.Text, RTB_adddesception.Text, RTB_addHowtouse.Text, true);
            MessageBox.Show("Add Successfully");

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                addProduct();
            }
        }

        private void btn_uploadImg_Click(object sender, EventArgs e)
        {
            uploadimg();
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

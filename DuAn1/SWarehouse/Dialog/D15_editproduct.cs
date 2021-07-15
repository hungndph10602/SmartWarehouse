using SWarehouse.Controllers.ProductServices;
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
    public partial class D15_editproduct : Form
    {
        private static int _productId { get; set; }
        IProductServices _productServices { get; set; }
        public D15_editproduct()
        {
            InitializeComponent();
            initializeD15();
        }
        private void initializeD15()
        {
            _productServices = new ProductService();
            loadProductCombobox();
        }
        byte[] images = null;
        private async void loadProductCombobox()
        {
            var productData = await _productServices.getAllProductIDAndName();
            Dictionary<int, string> productList = new Dictionary<int, string>();
            foreach (var item in productData)
            {
                productList.Add(item.productId, item.Product_Name);
            }
            cbx_product.DataSource = new BindingSource(productList, null);
            cbx_product.DisplayMember = "Value";
            cbx_product.ValueMember = "Key";
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
                    PB_editproduct.Image = Image.FromFile(fileDialog.FileName);
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
        
        private async void editProduct()
        {
            await _productServices.updateProduct(int.Parse(cbx_product.SelectedValue.ToString()), txt_editnameproduct.Text,new decimal(), images, txt_editdescreption.Text, RTB_editdescreption.Text, RTB_edithowtouse.Text);
            MessageBox.Show("Edit Successfully!");
        }
        private void btn_editclose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to edit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                editProduct();
            }
        }
    }
}

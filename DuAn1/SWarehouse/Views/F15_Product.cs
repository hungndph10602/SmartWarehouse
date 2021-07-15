using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse;
using SWarehouse.Controllers.OrderServices;
using SWarehouse.Controllers.ProductServices;
using SWarehouse.Dialog;
using SWarehouse.Models.BillModels;
using SWarehouse.Utilities;
using SWarehouse.Models.ProductModels;
using System.IO;

namespace SWarehouse.Views
{
    public partial class F15_Product : Form
    {
        IProductServices _productServices { get; set; }
        public F15_Product()
        {
            InitializeComponent();
            initializeF15();
        }
        private void initializeF15()
        {
            _productServices = new ProductService();
            loadProductList();
        }
        private List<ProductModels> _productList = new List<ProductModels>();
        private async void loadProductList()
        {
            var data = await _productServices.getAllProduct();
            loadProductList(data);
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

        private void loadProductList(List<SP_GetAllProduct_Result> data)
        {
            try
            {
                _productList = new List<ProductModels>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _productList.Add(new ProductModels
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
                }
                dgv_product.DataSource = _productList;
            }
            catch
            {
                MessageBox.Show("Oh No!");
            }
        }
        private async void loadProductByString()
        {
            try
            {
                var data = await _productServices.getProductByString(txt_search.Text);
                _productList = new List<ProductModels>();
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        _productList.Add(new ProductModels
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
                        });
                    }
                }
                dgv_product.DataSource = _productList;
            }
            catch
            {
                MessageBox.Show("Oh No!");
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                D14_addproduct d14_Addproduct = new D14_addproduct();
                d14_Addproduct.ShowDialog();
            }

        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            D15_editproduct d15_Editproduct = new D15_editproduct();
            d15_Editproduct.ShowDialog();
            loadProductList();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listData_Click(object sender, EventArgs e)
        {
            loadProductList();
        }

        private async void btn_timkiem_Click(object sender, EventArgs e)
        {
            loadProductByString();
        }
    }
}

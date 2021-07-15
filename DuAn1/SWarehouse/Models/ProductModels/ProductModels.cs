using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models.ProductModels
{
    public class ProductModels
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string code { get; set; }
        public string unitName { get; set; }
        public string colorName { get; set; }
        public string brandName { get; set; }
        public Image Image { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string UserManual { get; set; }
        public bool? Status { get; set; }
    }
}

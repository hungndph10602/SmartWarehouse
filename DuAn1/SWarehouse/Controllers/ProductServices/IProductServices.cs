using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.ProductServices
{
    interface IProductServices
    {
        Task<int> getProductQuantityByID(int productID);
        Task<int> createProduct(string name, string code, int unitId, int colorId, int brandId, decimal price, byte[] img, string shortDes, string longDes, string userManual, bool status);
        Task<int> updateProduct(int productId, string name, decimal price, byte[] img, string shortDes, string longDes, string userManual);
        Task<int> getProductById(int productId);
        Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDAndName();
        Task<List<SP_GetAllProduct_Result>> getAllProduct();
        Task<List<SP_GetProductByString_Result>> getProductByString(string param);
    }
}

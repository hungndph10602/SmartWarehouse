using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.ProductServices
{
    class ProductService : IProductServices
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<int> getProductQuantityByID(int productID)
        {
            var data = _db.SP_GetProductQuantityByID(productID);
            int result = data == 0? default(int):0;
            return Task.FromResult(result);
        }
        public Task<int> createProduct(string name, string code, int unitId, int colorId, int brandId,decimal price, byte[] img, string shortDes, string longDes, string userManual, bool status)
        {
            var data = _db.SP_CreateProduct(name, code, unitId, colorId, brandId,price, img,shortDes, longDes, userManual,status);
            return Task.FromResult(data);
        }
        public Task<int> updateProduct(int productId, string name,decimal price, byte[] img, string shortDes, string longDes, string userManual)
        {
            var data = _db.SP_UpdateProduct(productId, name,price, img, shortDes, longDes, userManual);
            return Task.FromResult(data);
        }
        public Task<int> getProductById(int productId)
        {
            var data = _db.SP_GetProductById (productId);
            return Task.FromResult(int.Parse(data.ToString()));
        }

        public Task<List<SP_GetAllProduct_Result>> getAllProduct()
        {
            var data = _db.SP_GetAllProduct();
            List<SP_GetAllProduct_Result> results = new List<SP_GetAllProduct_Result>();
            if (data != null)
            {
                foreach (SP_GetAllProduct_Result item in data)
                    results.Add(item);
                return Task.FromResult(results);
            }
            return Task.FromResult(results);
        }

        public Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDAndName()
        {
            var data = _db.SP_getAllProductIDAndName();
            List<SP_getAllProductIDAndName_Result> results = new List<SP_getAllProductIDAndName_Result>();
            if (data != null)
            {
                foreach (SP_getAllProductIDAndName_Result item in data)
                    results.Add(item);
                return Task.FromResult(results);
            }
            return Task.FromResult(results);
        }
        public Task<List<SP_GetProductByString_Result>> getProductByString(string param)
        {
            var data = _db.SP_GetProductByString(param);
            List<SP_GetProductByString_Result> results = new List<SP_GetProductByString_Result>();
            if (data != null)
            {
                foreach (SP_GetProductByString_Result item in data)
                    results.Add(item);
                return Task.FromResult(results);
            }
            return Task.FromResult(results);
        }

    }
}

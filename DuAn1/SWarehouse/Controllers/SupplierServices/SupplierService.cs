using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.SupplierServices
{
    public class SupplierService :ISupplierService
    {
        SWareDBEntities _db = new SWareDBEntities();
        //lấy toàn bộ nhà cung cấp
        public Task<List<SP_GetAllSupplier_Result>> getAllSuppliers()
        {
            try
            {
                var data = _db.SP_GetAllSupplier();
                List<SP_GetAllSupplier_Result> result = new List<SP_GetAllSupplier_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllSupplier_Result item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetAllSupplier_Result>());
            }
            catch
            {
                throw;
            }
        }
        //thêm nhà cung cấp
        public Task<int> addNewSupplier(string name, string address, string email, string phone, string moreInfo, DateTime contractDate, bool status)
        {
            try
            {
                _db.SP_CreateSupplier(name, address, email, phone, moreInfo, contractDate, status);
                _db.SaveChanges();
                return Task.FromResult(1);
            }
            catch
            {
                throw;
            }
        }
        //tìm nhà cung cấp
        public Task<List<SP_SearchSupplier_Result>> searchSupplier(string param)
        {
            try
            {
                var data = _db.SP_SearchSupplier(param);
                List<SP_SearchSupplier_Result> result = new List<SP_SearchSupplier_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);

                }
                return Task.FromResult(new List<SP_SearchSupplier_Result>());
            }
            catch
            {
                throw;
            }
        }
        //sửa nhà cung cấp
        public Task<int> editSupplier(int id, string name, string address, string email, string phone, string moreInfo, bool status)
        {
            try
            {
                var data = _db.SP_UpdateSupplier(id, name, address, email, phone, moreInfo, status);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        //lấy tên và Id nhà cung cấp
        public Task<List<SP_getAllSupplierIDAndName_Result>> getSupplierNameId()
        {
            try
            {
                var data = _db.SP_getAllSupplierIDAndName();
                List<SP_getAllSupplierIDAndName_Result> result = new List<SP_getAllSupplierIDAndName_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_getAllSupplierIDAndName_Result>());
            }
            catch
            {
                throw;
            }
        }
    }
}


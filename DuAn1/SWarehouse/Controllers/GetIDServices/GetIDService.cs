using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.GetIDServices
{
    public class GetIDService : IGetIDService
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<List<SP_GetRoleIdAndName_Result>> getAllRoleIdAndName()
        {
            var data = _db.SP_GetRoleIdAndName();
            List<SP_GetRoleIdAndName_Result> result = new List<SP_GetRoleIdAndName_Result>();
            foreach(var item in data)
            {
                result.Add(item);
            }
            return Task.FromResult(result);
        }
        public Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDAndName()
        {
            try
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
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetAllAccountIdAndName_Result>> getAllStaffIdAndName()
        {
            try
            {
                var data = _db.SP_GetAllAccountIdAndName();
                List<SP_GetAllAccountIdAndName_Result> results = new List<SP_GetAllAccountIdAndName_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_getAllSupplierIDAndName_Result>> getAllSupplierIDAndName()
        {
            try
            {
                var data = _db.SP_getAllSupplierIDAndName();
                List<SP_getAllSupplierIDAndName_Result> results = new List<SP_getAllSupplierIDAndName_Result>();
                if (data != null)
                {
                    foreach (SP_getAllSupplierIDAndName_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_getAllWarehouseIDAndName_Result>> getAllWarehouseIDAndName()
        {
            try
            {
                var data = _db.SP_getAllWarehouseIDAndName();
                List<SP_getAllWarehouseIDAndName_Result> results = new List<SP_getAllWarehouseIDAndName_Result>();
                if (data != null)
                {
                    foreach (SP_getAllWarehouseIDAndName_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }

        public Task<List<SP_GetAllCustomerIdAndName_Result>> getAllCustomerIDAndName()
        {
            try
            {
                var data = _db.SP_GetAllCustomerIdAndName();
                List<SP_GetAllCustomerIdAndName_Result> results = new List<SP_GetAllCustomerIdAndName_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllCustomerIdAndName_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetBrandIdAndName_Result>> getBrand()
        {
            try
            {
                var data = _db.SP_GetBrandIdAndName();
                List<SP_GetBrandIdAndName_Result> results = new List<SP_GetBrandIdAndName_Result>();
                if (data != null)
                {
                    foreach (SP_GetBrandIdAndName_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetColorIdAndName_Result>> getColor()
        {
            try
            {
                var data = _db.SP_GetColorIdAndName();
                List<SP_GetColorIdAndName_Result> results = new List<SP_GetColorIdAndName_Result>();
                if (data != null)
                {
                    foreach (SP_GetColorIdAndName_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetUnitIdAndName_Result>> getUnitName()
        {
            try
            {
                var data = _db.SP_GetUnitIdAndName();
                List<SP_GetUnitIdAndName_Result> results = new List<SP_GetUnitIdAndName_Result>();
                if (data != null)
                {
                    foreach (SP_GetUnitIdAndName_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch
            {
                throw;
            }
        }

    }
}

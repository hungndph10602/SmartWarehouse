using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWarehouse.Utilities;

namespace SWarehouse.Controllers.GRNServices
{
    public class GRNService : IGRNService
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<SP_GetAmountOwn_Result> getAmountOwn(int grn_id)
        {
            var data = _db.SP_GetAmountOwn(grn_id);
            return Task.FromResult(data.FirstOrDefault());
        }
        public Task<int> updateQuantityToWarehouse(int grn_id)
        {
            var data = _db.SP_SetGRNProductQuantity(grn_id);
            return Task.FromResult(data);
        }
        public Task<int> PayGRN(int grn_id,decimal moneyInput)
        {
            var data = _db.SP_PayGRN(grn_id,moneyInput);
            return Task.FromResult(data);
        }
        public Task<int> updateGRNStatus(int GRN_ID)
        {
            try
            {
                var data = _db.SP_updateGRNStatus(GRN_ID);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<int> insertNewGRNDetail(int proID,int GRNId,int supplierID,int quantity,int actual,decimal cost)
        {
            try
            {
                var data = _db.SP_CreateGRNDetail(proID,GRNId,supplierID,quantity,actual,cost);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<int?> insertNewGRN(int warehouseId,DateTime dateCreate, string moreInfo)
        {
            try
            {
                var data = _db.SP_CreateGRN(warehouseId,AppConstants.StaffID,dateCreate , moreInfo);
                return Task.FromResult(data.FirstOrDefault());
            }
            catch
            {
                throw;
            }
            
        }

        public Task<List<SP_SearchGRNByString_Result>> searchGRNbyString(string str)
        {
            try
            {
                List<SP_SearchGRNByString_Result> results = new List<SP_SearchGRNByString_Result>();
                var data = _db.SP_SearchGRNByString(str);
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

        public Task<List<SP_GetAllGRN_Result>> getAllGRN()
        {
            try
            {
                var data = _db.SP_GetAllGRN();
                List<SP_GetAllGRN_Result> result = new List<SP_GetAllGRN_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllGRN_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetGRNDetailByGRNID_Result>> getGRNDetailByGRNId(int grnID)
        {
            try
            {
                var data = _db.SP_GetGRNDetailByGRNID(grnID);
                List<SP_GetGRNDetailByGRNID_Result> results = new List<SP_GetGRNDetailByGRNID_Result>();
                if (data != null)
                {
                    foreach (SP_GetGRNDetailByGRNID_Result item in data)
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

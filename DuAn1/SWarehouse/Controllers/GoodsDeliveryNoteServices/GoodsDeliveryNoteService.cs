using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWarehouse.Utilities;

namespace SWarehouse.Controllers.GoodsDeliveryNoteServices
{
    class GoodsDeliveryNoteService : IGoodsDeliveryNoteService
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<SP_GetProductQuantityInWarehouse_Result> getQuantityInWarehouse(int warehouseID,int productID)
        {
            var data = _db.SP_GetProductQuantityInWarehouse(warehouseID, productID);
            return Task.FromResult(data.FirstOrDefault());
        }
        //lấy toàn bộ dữ liệu phiếu xuất
        public Task<List<SP_GetAllGDN_Result>> getAllGDN()
        {
            try
            {
                var data = _db.SP_GetAllGDN();
                List<SP_GetAllGDN_Result> result = new List<SP_GetAllGDN_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllGDN_Result item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetAllGDN_Result>());
            }
            catch
            {
                throw;
            }
        }
        //lấy chi tiết phiếu xuất
         public Task<List<SP_GetGDNDetailById_Result>> getGDNDetail(int id)
        {
            try
            {
                var data = _db.SP_GetGDNDetailById(id);
                List<SP_GetGDNDetailById_Result> result = new List<SP_GetGDNDetailById_Result>();
                if (data != null)
                {
                    foreach (SP_GetGDNDetailById_Result item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetGDNDetailById_Result>());
            }
            catch
            {
                throw;
            }
        }
        //tìm kiếm phiếu xuất
        public Task<List<SP_SearchGDNByString_Result>> searchGDN(string param)
        {
            try
            {
                var data = _db.SP_SearchGDNByString(param);
                List<SP_SearchGDNByString_Result> result = new List<SP_SearchGDNByString_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_SearchGDNByString_Result>());
            }
            catch
            {
                throw;
            }
        }
        //thêm phiếu xuất
        public Task<int?> addGDN(int wareHouseId,int request_ID, DateTime createDate, string moreInf)
        {
            try
            {
                var data = _db.SP_CreateGDN(request_ID, AppConstants.StaffID,wareHouseId,createDate, moreInf);
                _db.SaveChanges();
                return Task.FromResult(data.FirstOrDefault());
            }
            catch
            {
                throw;
            }
        }
        //thêm chi tiết phiếu xuất
        public Task<int> addGDNDetail(int productId, int gdnId, int quantityRequest, int actualAmount)
        {
            try
            {
                _db.SP_CreateGDN_Detail(productId, gdnId, quantityRequest, actualAmount);
                _db.SaveChanges();
                return Task.FromResult(1);
            }
            catch
            {
                throw;
            }
        }
        //lấy tất cả mã kho
        public Task<List<SP_getAllWarehouseIDAndName_Result>> getAllWareHouseIDNName()
        {
            try
            {
                var data = _db.SP_getAllWarehouseIDAndName();
                List<SP_getAllWarehouseIDAndName_Result> result = new List<SP_getAllWarehouseIDAndName_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_getAllWarehouseIDAndName_Result>());
            }
            catch
            {
                throw;
            }
        }
        //lấy tất cả mã phiếu yêu cầu nhập
        public Task<List<SP_GetAllUnDoneRequest_Result>> getAllUnDoneNR()
        {
            try
            {
                var data = _db.SP_GetAllUnDoneRequest();
                List<SP_GetAllUnDoneRequest_Result> result = new List<SP_GetAllUnDoneRequest_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetAllUnDoneRequest_Result>());
            }
            catch
            {
                throw;
            }
        }

        //lấy tất cả mã sản phẩm
        public Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDNName()
        {
            try
            {
                var data = _db.SP_getAllProductIDAndName();
                List<SP_getAllProductIDAndName_Result> result = new List<SP_getAllProductIDAndName_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_getAllProductIDAndName_Result>());
            }
            catch
            {
                throw;
            }
        }
        //lấy tất cả mã nhân vien
        public Task<List<SP_GetAllAccountIdAndName_Result>> getAllStaffIDNName()
        {
            try
            {
                var data = _db.SP_GetAllAccountIdAndName();
                List<SP_GetAllAccountIdAndName_Result> result = new List<SP_GetAllAccountIdAndName_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetAllAccountIdAndName_Result>());
            }
            catch
            {
                throw;
            }
        }
        //thay đổi trạng thái phiếu xuất
        public Task<int> updateGDNStatus(int GDNId)
        {
            try
            {
                var data = _db.SP_UpdateGDNStatus(GDNId);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        //cập nhật sô luọng trong chi tiết
        public Task<int> updateProductAmmount(int GDNId,int qtt,int productID)
        {
            try
            {
                var data = _db.SP_UpdateActualAmountGDN(GDNId,qtt,productID);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        //pay GDN
        public Task<int> payGDN(int GDNId)
        {
            try
            {
                var data = _db.SP_PayGDN(GDNId);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.GoodsDeliveryNoteServices
{
    interface IGoodsDeliveryNoteService
    {
        /// <summary>
        /// get product least in warehouse
        /// </summary>
        /// <param name="warehouseID"></param>
        /// <param name="productID"></param>
        /// <returns></returns>
        Task<SP_GetProductQuantityInWarehouse_Result> getQuantityInWarehouse(int warehouseID, int productID);
        /// <summary>
        /// load dữ liệu phiếu xuất
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllGDN_Result>> getAllGDN();
        /// <summary>
        /// load dữ liệu phiếu xuất chi tiết
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<SP_GetGDNDetailById_Result>> getGDNDetail(int id);
        /// <summary>
        /// tìm kiếm phiếu xuất
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<SP_SearchGDNByString_Result>> searchGDN(string param);
        /// <summary>
        /// Add new GDN to database
        /// </summary>
        /// <param name="wareHouseId"></param>
        /// <param name="createDate"></param>
        /// <param name="moreInf"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int?> addGDN(int wareHouseId,int request_ID, DateTime createDate, string moreInf);
        /// <summary>
        /// Add GDN Detail into database with GDN ID
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="gdnId"></param>
        /// <param name="quantityRequest"></param>
        /// <param name="actualAmount"></param>
        /// <returns></returns>
        Task<int> addGDNDetail(int productId, int gdnId, int quantityRequest, int actualAmount);
        /// <summary>
        /// load dữ liệu mã kho và tên kho
        /// </summary>
        /// <returns></returns>
        Task<List<SP_getAllWarehouseIDAndName_Result>> getAllWareHouseIDNName();
        /// <summary>
        /// load dữ liệu mã và tên sản phẩm
        /// </summary>
        /// <returns></returns>
        Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDNName();
        /// <summary>
        /// load dữ liệu account IDvà tên nhân viên
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllAccountIdAndName_Result>> getAllStaffIDNName();
        /// <summary>
        /// cập nhật trạng thái phiếu xuất
        /// </summary>
        /// <param name="GDNId"></param>
        /// <returns></returns>
        Task<int> updateGDNStatus(int GDNId);
        Task<List<SP_GetAllUnDoneRequest_Result>> getAllUnDoneNR();
        Task<int> updateProductAmmount(int GDNId, int qtt, int productID);
        Task<int> payGDN(int GDNId);
    }
}
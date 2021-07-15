using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.GRNServices
{
    interface IGRNService
    {
        /// <summary>
        /// Get Amount Own
        /// </summary>
        /// <param name="grn_id"></param>
        /// <returns></returns>
        Task<SP_GetAmountOwn_Result> getAmountOwn(int grn_id);
        /// <summary>
        /// set status of GRN to 2,disable edit and update quantity to warehouse
        /// </summary>
        /// <param name="grn_id"></param>
        /// <returns></returns>
        Task<int> updateQuantityToWarehouse(int grn_id);
        /// <summary>
        /// Pay grn
        /// </summary>
        /// <param name="grn_id"></param>
        /// <param name="moneyInput"></param>
        /// <returns></returns>
        Task<int> PayGRN(int grn_id, decimal moneyInput);
        /// <summary>
        /// Set status of GRN with GRN_ID to Done
        /// </summary>
        /// <param name="GRN_ID"></param>
        /// <returns></returns>
        Task<int> updateGRNStatus(int GRN_ID);
        /// <summary>
        /// Add new detail into GRN with GRN ID
        /// </summary>
        /// <param name="proID"></param>
        /// <param name="GRNId"></param>
        /// <param name="supplierID"></param>
        /// <param name="quantity"></param>
        /// <param name="actual"></param>
        /// <param name="cost"></param>
        /// <param name="price"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        Task<int> insertNewGRNDetail(int proID, int GRNId, int supplierID, int quantity, int actual, decimal cost);
       /// <summary>
       /// Add new GRN to database
       /// </summary>
       /// <param name="warehouseId"></param>
       /// <param name="moreInfo"></param>
       /// <returns></returns>
        Task<int?> insertNewGRN(int warehouseId, DateTime dateCreate,string moreInfo);
        /// <summary>
        /// get all Good Receive Note
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllGRN_Result>> getAllGRN();
        /// <summary>
        /// Get all Goods Receive Note Detail by Goods Receive Note ID
        /// </summary>
        /// <param name="grnID"></param>
        /// <returns></returns>
        Task<List<SP_GetGRNDetailByGRNID_Result>> getGRNDetailByGRNId(int grnID);
        /// <summary>
        /// Get all Goods Receive Note by string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        Task<List<SP_SearchGRNByString_Result>> searchGRNbyString(string str);
    }
}

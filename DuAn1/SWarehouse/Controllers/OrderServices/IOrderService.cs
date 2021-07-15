using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.OrderServices
{
    interface IOrderServices
    {
        /// <summary>
        /// get all order which have staff name or user name contain @param
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<List<SP_SearchOrderByString_Result>> searchOrderByString(string param);
        /// <summary>
        /// thêm hóa đơn
        /// </summary>
        /// <param name="customer_id"></param>
        /// <param name="account_id"></param>
        /// <param name="createdate"></param>
        /// <returns></returns>
        Task<int> insertNewOrder(int customer_id, int account_id, DateTime createdate);
        /// <summary>
        /// Thêm chi tiết hóa đơn
        /// </summary>
        /// <param name="proID"></param>
        /// <param name="orderId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        Task<int> insertNewOrderDetail(int proID, int orderId, int quantity);
        /// <summary>
        /// lấy tất cả hóa đơn
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllOrder_Result>> getAllOrder();

        //Task<List<SP_GetAllOrderDetail_Result>> getAllOrderDeltail();

        Task<int> payOrder(int orderId, decimal inputMoney, DateTime actualTimepay);

        Task<List<SP_GetAllOrderDetailByOrderId_Result>> getOrderDetailByOrderId(int orderId);

        Task<int> breakPayOrder(int orderId);
        Task<int> updateProductOrderDetailQuantity(int orderId, int productId, int quantity);
        Task<decimal> getTotalMoney(int orderId);
        Task<int> getQuantityProduct(int productId);
    }

}

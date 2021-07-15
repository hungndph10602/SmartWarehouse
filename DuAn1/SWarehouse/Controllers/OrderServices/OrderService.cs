using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWarehouse.Controllers.OrderServices
{
    class OrderService : IOrderServices
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<List<SP_SearchOrderByString_Result>> searchOrderByString(string param)
        {
            try
            {
                var data = _db.SP_SearchOrderByString(param);
                List<SP_SearchOrderByString_Result> result = new List<SP_SearchOrderByString_Result>();
                foreach (var item in data)
                {
                    result.Add(item);
                }
                return Task.FromResult(result);
            }
            catch
            {
                throw;
            }
        }
        public Task<int> insertNewOrder(int customer_id, int account_id, DateTime createdate)
        {
            try
            {
                var data = _db.SP_CreateOrderAdd(customer_id, account_id, createdate);
                return Task.FromResult(int.Parse((data.FirstOrDefault()).ToString()));
            }
            catch
            {
                throw;
            }
        }
        public Task<int> insertNewOrderDetail(int proId, int orderId, int quantity)
        {
            try
            {
                var data = _db.SP_CreateOrderDetail(proId, orderId, quantity);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<int> payOrder(int orderId, decimal inputMoney, DateTime actualTimepay)
        {
            try
            {
                var data = _db.SP_PayOrder(orderId, inputMoney, actualTimepay);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<int> breakPayOrder(int orderId)
        {
            try
            {
                var data = _db.SP_BreakPayOrder(orderId);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<decimal> getTotalMoney(int orderId)
        {
            var data = _db.SP_GetTotalMoney(orderId);
            return Task.FromResult(decimal.Parse(data.FirstOrDefault().ToString()));
        }
        public Task<List<SP_GetAllOrder_Result>> getAllOrder()
        {
            try
            {
                var data = _db.SP_GetAllOrder();
                List<SP_GetAllOrder_Result> result = new List<SP_GetAllOrder_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllOrder_Result item in data)
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
        public Task<int> updateProductOrderDetailQuantity(int orderId, int productId, int quantity)
        {
            var data = _db.SP_UpdateOrderProductQuantity(orderId, productId, quantity);
            return Task.FromResult(data);
        }
        public Task<int> getQuantityProduct(int productId)
        {
            var data = _db.SP_GetProductQuantity(productId);
            return Task.FromResult(int.Parse(data.ToString()));
        }
        public Task<List<SP_GetAllOrderDetailByOrderId_Result>> getOrderDetailByOrderId(int orderId)
        {
            try
            {
                var data = _db.SP_GetAllOrderDetailByOrderId(orderId);
                List<SP_GetAllOrderDetailByOrderId_Result> result = new List<SP_GetAllOrderDetailByOrderId_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllOrderDetailByOrderId_Result item in data)
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
    }
}

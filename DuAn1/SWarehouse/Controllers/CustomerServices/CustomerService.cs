using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        // chỉnh sửa dữ liệu khách hàng
        public Task<int> editcustomer(int id, string phone, string email, bool status)
        {
            try
            {
                var data = _db.SP_EditCustomer(id, phone, email, status);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        //Lấy toàn bộ dữ liệu nhà cung cấp
        SWareDBEntities _db = new SWareDBEntities();
        public Task<List<SP_GetAllCustomer_Result>> getAllCustomers()
        {
            try
            {
                var data = _db.SP_GetAllCustomer();
                List<SP_GetAllCustomer_Result> result = new List<SP_GetAllCustomer_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllCustomer_Result item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetAllCustomer_Result>());
            }
            catch
            {
                throw;
            }
        }
        // Thêm khách hàng
        public Task<int> addNewCustomer(string name, string phone, string email)
        {
            var data = _db.SP_CreateCustomer(name, phone, email);
            _db.SaveChanges();
            return Task.FromResult(data);

        }

        // Tìm kiếm thông tin khách hàng
        public Task<List<SP_GetCustomerByString_Result>> searchCustomer(string str)
        {
            List<SP_GetCustomerByString_Result> getCustomerByString_Results = new List<SP_GetCustomerByString_Result>();

            var data = _db.SP_GetCustomerByString(str);
            if (data != null)
            {
                foreach (SP_GetCustomerByString_Result item in data)
                {
                    getCustomerByString_Results.Add(item);
                }
                return Task.FromResult(getCustomerByString_Results);
            }
            return Task.FromResult(new List<SP_GetCustomerByString_Result>());
        }
    }
}

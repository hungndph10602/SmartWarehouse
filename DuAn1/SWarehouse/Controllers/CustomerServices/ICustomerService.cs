using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.CustomerServices
{
    interface ICustomerService
    {
        /// <summary>
        /// Chức năng Load thông tin khách hàng-- Do Đăng(dangnhph) đẹp trai làm !!!
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllCustomer_Result>> getAllCustomers();
        /// <summary>
        /// Chức năng thêm Khách Hàng-- Do Đăng làm!
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns></returns>   
        Task<int> addNewCustomer(string name, string phone, string email);
        /// <summary>
        /// Search Customer theo ngẫu nhiên --- Đăng làm
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        Task<List<SP_GetCustomerByString_Result>> searchCustomer(string str);
        /// <summary>
        /// edit khách hàng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int> editcustomer(int id, string phone, string email, bool status);

    }
}

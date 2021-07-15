using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.SupplierServices
{
    interface ISupplierService
    {
        /// <summary>
        ///lấy toàn bộ dữ liệu bảng supplierService(luanntph11597)
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllSupplier_Result>> getAllSuppliers();
        /// <summary>
        /// thêm nhà cung cấp(luanntph1597)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="moreInfo"></param>
        /// <param name="contractDate"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int> addNewSupplier(string name, string address, string email, string phone, string moreInfo, DateTime contractDate, bool status);
       /// <summary>
       /// tìm kiếm nhà cung cấp
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        Task<List<SP_SearchSupplier_Result>> searchSupplier(string id);
        /// <summary>
        /// sửa nhà cung cấp
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="moreInfo"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int> editSupplier(int id, string name, string address, string email, string phone, string moreInfo, bool status);
        Task<List<SP_getAllSupplierIDAndName_Result>> getSupplierNameId();
    }
}

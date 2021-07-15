using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.GetIDServices
{
    interface IGetIDService
    {
        /// <summary>
        /// Get all Role ID and Name
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetRoleIdAndName_Result>> getAllRoleIdAndName();
        /// <summary>
        /// Get All product ID and Name
        /// </summary>
        /// <returns></returns>
        Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDAndName();
        /// <summary>
        /// Get all staff ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllAccountIdAndName_Result>> getAllStaffIdAndName();
        /// <summary>
        /// Get all Warehouse ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_getAllWarehouseIDAndName_Result>> getAllWarehouseIDAndName();
        /// <summary>
        /// Get all Supplier ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_getAllSupplierIDAndName_Result>> getAllSupplierIDAndName();
        /// <summary>
        /// Get all customer ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllCustomerIdAndName_Result>> getAllCustomerIDAndName();
        /// <summary>
        /// Get all brand ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetBrandIdAndName_Result>> getBrand();
        /// <summary>
        /// Get all color ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetColorIdAndName_Result>> getColor();
        /// <summary>
        /// Get all Unit ID
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetUnitIdAndName_Result>> getUnitName();
    }
}

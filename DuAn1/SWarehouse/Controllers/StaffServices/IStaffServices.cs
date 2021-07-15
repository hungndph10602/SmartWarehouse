using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.StaffServices
{
    interface IStaffServices
    {
        /// <summary>
        /// Return 1 if username invalid or 0 if user is valid
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        Task<int> CheckValidUsername(string username);
        /// <summary>
        /// Lấy thông tin nhân viên bằng ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Task<SP_GetStaffById_Result> getStaffById(int ID);
        /// <summary>
        /// Lấy Toàn Bộ Dữ Liệu Nhân Viên (Khanhvbph10675)
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetAllStaff_Result>> getAllStaff();
        /// <summary>
        /// Thêm Mới Nhân Viên (Khanhvbph10675)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="salary"></param>
        ///  <param name="image"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int> addNewStaff(string name, string address, string phone, string email, decimal salary, byte[] image, bool status);
        /// <summary>
        /// Chỉnh sửa thông tin nhân viên (khanhvbph10675)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="salary"></param>
        /// <param name="moreInfo"></param>
        /// <param name="image"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int> editStaff(int id, string address, string phone, string email, decimal salary, string moreInfo, byte[] image, bool status);
        /// <summary>
        /// Tìm Kiếm Nhân Viên sdt hoặc email
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<List<SP_SearchStaffByString_Result>> SearchStaffByString(string search);
        Task<int> CreateAccount(int staff,string username,string password,int role,string displayName);
    }
}

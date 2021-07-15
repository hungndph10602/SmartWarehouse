using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.UserServices
{
    interface IUserSevice
    {
        /// <summary>
        /// User login by username and password
        /// Khanhvb
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<SP_Login_Result> UserLogin(string username, string password);
        /// <summary>
        /// (Khanhvbph10675) Đổi Mật Khẩu của tài khoản đang đăng nhập Nha các baby <3
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        Task<int> changeUserPassWord(string newPassword);
    }
}


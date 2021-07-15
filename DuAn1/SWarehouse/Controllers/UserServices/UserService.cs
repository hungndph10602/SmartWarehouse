using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWarehouse.Utilities;
namespace SWarehouse.Controllers.UserServices
{
    public class UserService : IUserSevice
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<SP_Login_Result> UserLogin(string username, string password)
        {
            try
            {
                var data = _db.SP_Login(username, password);
                if (data != null)
                {
                    return Task.FromResult(data.FirstOrDefault());
                }
                return Task.FromResult(new SP_Login_Result());
            }
            catch (Exception)
            {
                return Task.FromResult(new SP_Login_Result());
            }
        }
        public Task<int> changeUserPassWord(string newPassword)
        {
            try
            {
                var data = _db.SP_ChangePassword(AppConstants.UserName, newPassword);
                return Task.FromResult(data);
            }
            catch (Exception)
            {

                return Task.FromResult(0);
            }
        }
    }
}

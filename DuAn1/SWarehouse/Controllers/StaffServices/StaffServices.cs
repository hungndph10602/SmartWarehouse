using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWarehouse;


namespace SWarehouse.Controllers.StaffServices
{
    public class StaffServices : IStaffServices
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<int> CheckValidUsername(string username)
        {
            var data = _db.SP_CheckValidUsername(username);
            var result = data == null ? default(int) : 1;
            return Task.FromResult(result);
        }
        public Task<int> CreateAccount(int staff, string username, string password, int role, string displayName)
        {
            var data = _db.SP_CreateAccount(staff, username, password, displayName, role);
            return Task.FromResult(data);
        }
        public Task<int> editStaff(int id, string address, string phone, string email, decimal salary, string moreInfo, byte[] image, bool status)
        {
            try
            {

                var data = _db.SP_UpdateStaff(id, address, email, phone, salary, moreInfo, image, status);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_SearchStaffByString_Result>> SearchStaffByString(string search)
        {
            try
            {

                var data = _db.SP_SearchStaffByString(search);
                List<SP_SearchStaffByString_Result> result = new List<SP_SearchStaffByString_Result>();
                if (data != null)
                {
                    foreach (var item in data)
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

        public Task<SP_GetStaffById_Result> getStaffById(int ID)
        {
            try
            {
                var data = _db.SP_GetStaffById(ID);
                if (data != null)
                {
                    return Task.FromResult(data.FirstOrDefault());
                }
                return Task.FromResult(new SP_GetStaffById_Result());
            }
            catch
            {
                throw;
            }
        }
        public Task<int> addNewStaff(string name, string address, string phone, string email, decimal salary, byte[] image, bool status)
        {
            try
            {
                var data = _db.SP_CreateStaff(name, address, email, phone, salary, image, status);
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetAllStaff_Result>> getAllStaff()
        {
            try
            {
                var data = _db.SP_GetAllStaff();
                List<SP_GetAllStaff_Result> result = new List<SP_GetAllStaff_Result>();
                if (data != null)
                {
                    foreach (SP_GetAllStaff_Result item in data)
                    {
                        result.Add(item);
                    }
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

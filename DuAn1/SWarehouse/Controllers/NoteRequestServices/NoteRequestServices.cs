using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWarehouse.Utilities;
namespace SWarehouse.Controllers.NoteRequestServices
{
    public class NoteRequestServices: INoteRequestServices
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<List<Sp_GetAllDR_Result>> getAllDR()
        {
            var data = _db.Sp_GetAllDR();
            List<Sp_GetAllDR_Result> result = new List<Sp_GetAllDR_Result>();
            foreach(Sp_GetAllDR_Result item in data)
            {
                result.Add(item);
            }
            return Task.FromResult(result);
        }
        public Task<List<Sp_GetAllDRDetailByID_Result>> getAllDRDetailByID(int id)
        {
            var data = _db.Sp_GetAllDRDetailByID(id);
            List<Sp_GetAllDRDetailByID_Result> result = new List<Sp_GetAllDRDetailByID_Result>();
            foreach (Sp_GetAllDRDetailByID_Result item in data)
            {
                result.Add(item);
            }
            return Task.FromResult(result);
        }
        public Task<int> addNoteRequest(DateTime dateT,string moreInf,bool stt)
        {
           
            try
            {
                var data = _db.SP_CreateDeliveryRequest( AppConstants.AccountID, dateT,moreInf, stt);
                _db.SaveChanges();
                return Task.FromResult(int.Parse(data.FirstOrDefault().ToString()));
            }
            catch
            {
                throw;
            }
        }
        public Task<int> addNoteRequestDetail(int productId,int requestId,int quantity)
        {
            try
            {
                var data = _db.SP_CreateDeliveryRequestDetail(productId, requestId, quantity);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetRequestByID_Result>> searchNR(int NR)
        {
            try
            {
                var data = _db.SP_GetRequestByID(NR);
                List<SP_GetRequestByID_Result> result = new List<SP_GetRequestByID_Result>();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        result.Add(item);
                    }
                    return Task.FromResult(result);
                }
                return Task.FromResult(new List<SP_GetRequestByID_Result>());
            }
            catch
            {
                throw;
            }
        }
        //thay đổi trạng thái phiếu xuất
        public Task<int> updateNRStatus(int NRID)
        {
            try
            {
                var data = _db.SP_UpdateDeliveryRequestStatus(NRID);
                _db.SaveChanges();
                return Task.FromResult(data);
            }
            catch
            {
                throw;
            }
        }
    }
}

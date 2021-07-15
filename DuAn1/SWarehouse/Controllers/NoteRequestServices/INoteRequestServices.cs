using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.NoteRequestServices
{
    interface INoteRequestServices
    {
        Task<int> addNoteRequest(DateTime dateT, string moreInf, bool stt);
        Task<int> addNoteRequestDetail(int productId, int requestId, int quantity);
        Task<List<Sp_GetAllDR_Result>> getAllDR();
        Task<List<Sp_GetAllDRDetailByID_Result>> getAllDRDetailByID(int id);
        Task<List<SP_GetRequestByID_Result>> searchNR(int NR);
        Task<int> updateNRStatus(int NRID);
    }
}

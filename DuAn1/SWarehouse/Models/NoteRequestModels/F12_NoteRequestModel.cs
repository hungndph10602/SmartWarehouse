using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models.NoteRequestModels
{
    class F12_NoteRequestModel
    {
        public string PhieuYeuCau { get; set; }
        public string NhanVien { get; set; }
        public string NgayTao { get; set; }
        public string TrangThai { get; set; }
    }
    class F12_NoteRequestDetailModel
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
    }
}

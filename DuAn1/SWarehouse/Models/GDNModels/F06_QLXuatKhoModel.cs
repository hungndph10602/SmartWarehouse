using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models.GDNModels
{
    class F06_QLXuatKhoModel
    {
        public string PhieuXuat { get; set; }
        public string Kho { get; set; }
        public string NhanVien { get; set; }
        public string RequestNote { get; set; }
        public string NgayXuat { get; set; }
        public string TrangThai { get; set; }
    }
    class F06_QLXuatKhoChiTiet
    {
        public string SanPham { get; set; }
        public string SoLuongXuat { get; set; }
        public string SoLuongXuatThuc { get; set; }
    }
}

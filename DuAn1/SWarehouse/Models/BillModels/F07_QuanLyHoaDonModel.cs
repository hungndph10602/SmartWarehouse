using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models.BillModels
{
    class F07_QuanLyHoaDonModel
    {
        public string HoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public decimal? TongTien { get; set; }
        public bool? STT { get; set; }
        public decimal? TienDua { get; set; }
        public decimal? TienTra { get; set; }
    }
    class F07_QuanLyHoaDonChiTietModel
    {
        public string OrderId { get; set; }
        public string TenSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
        public string Code { get; set; }
    }
}

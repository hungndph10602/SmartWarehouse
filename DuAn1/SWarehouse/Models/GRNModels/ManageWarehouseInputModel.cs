using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models.GRNModels
{
    public class ManageWarehouseInputModel
    {
        public string PhieuNhap { get; set; }
        public string NhanVien { get; set; }
        public string NgayLap { get; set; }
        public string Kho { get; set; }
        public string Detail { get; set; }
        public string SoLuongMatHang { get; set; }
        public string TrangThai { get; set; }
        public decimal TongTien { get; set; }
        public decimal ChuaThanhToan { get; set; }
    }
    public class ManageWarehouseInputDetaiModel
    { 
        public string MatHang { get; set; }
        public string NhaCungCap { get; set; }
        public int SoLuong { get; set; }
        public int HangThieu { get; set; }
        public string LoHang { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
    }
}

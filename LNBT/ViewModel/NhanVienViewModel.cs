using LNBT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.ViewModel
{
    internal class NhanVienViewModel
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string VaiTro { get; set; }

        public decimal? Luong { get; set; }
        public string CaLamViec { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public string TrangThai { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }


    }
}

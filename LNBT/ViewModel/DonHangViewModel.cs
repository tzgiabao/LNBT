using LNBT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.ViewModel
{
    internal class DonHangViewModel
    {
        public int MaDonHang { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaNhanVien { get; set; }
        public DateTime NgayDatHang { get; set; }

        public decimal TongTien { get; set; }
        public string TrangThaiDonHang { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

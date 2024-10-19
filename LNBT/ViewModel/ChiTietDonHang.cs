using LNBT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.ViewModel
{
    internal class ChiTietDonHang
    {
        public int MaChiTietDonHang { get; set; }

        public int? MaDonHang { get; set; }

        public int? MaSanPham { get; set; }

        public int SoLuong { get; set; }

        public decimal Gia { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}

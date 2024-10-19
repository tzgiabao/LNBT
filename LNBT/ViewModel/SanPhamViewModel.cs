using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.ViewModel
{
    internal class SanPhamViewModel
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }

        public decimal Gia { get; set; }
        public string LoaiSanPham { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }

        public decimal? KhuyenMai { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}

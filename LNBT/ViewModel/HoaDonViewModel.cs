using LNBT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.ViewModel
{
    internal class HoaDonViewModel
    {
        public int MaHoaDon { get; set; }

        public int? MaDonHang { get; set; }
        public DateTime NgayLapHoaDon { get; set; }

        public decimal TongTien { get; set; }
        public string TrangThaiThanhToan { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}

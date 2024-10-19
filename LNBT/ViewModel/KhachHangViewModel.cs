using LNBT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.ViewModel
{
    internal class KhachHangViewModel
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public int? DiemTichLuy { get; set; }
        public DateTime? NgaySinh { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}

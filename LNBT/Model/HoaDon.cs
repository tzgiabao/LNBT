namespace LNBT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        public int? MaDonHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLapHoaDon { get; set; }

        public decimal TongTien { get; set; }

        [StringLength(50)]
        public string TrangThaiThanhToan { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}

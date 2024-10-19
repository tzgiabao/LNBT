using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LNBT.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLTSDBContext")
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TKNhanVien> TKNhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.Gia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.ThanhTien)
                .HasPrecision(21, 2);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.TongTien)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.TrangThaiDonHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(10, 2);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TrangThaiThanhToan)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.VaiTro)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Luong)
                .HasPrecision(10, 2);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CaLamViec)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Gia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.LoaiSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MoTa)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.KhuyenMai)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TKNhanVien>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TKNhanVien>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<TKNhanVien>()
                .Property(e => e.Role)
                .IsUnicode(false);
        }
    }
}

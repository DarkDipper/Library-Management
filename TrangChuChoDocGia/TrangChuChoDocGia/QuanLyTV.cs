namespace Trang_Chu
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyTV : DbContext
    {
        public QuanLyTV()
            : base("name=QuanLyTV")
        {
        }

        public virtual DbSet<DanhSachSach> DanhSachSaches { get; set; }
        public virtual DbSet<HoSo> HoSoes { get; set; }
        public virtual DbSet<MatSach> MatSaches { get; set; }
        public virtual DbSet<MuonSach> MuonSaches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanNV> TaiKhoanNVs { get; set; }
        public virtual DbSet<ThanhLy> ThanhLies { get; set; }
        public virtual DbSet<TheDocGia> TheDocGias { get; set; }
        public virtual DbSet<TraSach> TraSaches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhSachSach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachSach>()
                .Property(e => e.MaNgNhan)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachSach>()
                .Property(e => e.LuotDanhGia)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachSach>()
                .HasMany(e => e.MatSaches)
                .WithRequired(e => e.DanhSachSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhSachSach>()
                .HasMany(e => e.MuonSaches)
                .WithRequired(e => e.DanhSachSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhSachSach>()
                .HasMany(e => e.ThanhLies)
                .WithRequired(e => e.DanhSachSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhSachSach>()
                .HasMany(e => e.TraSaches)
                .WithRequired(e => e.DanhSachSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoSo>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoSo>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<HoSo>()
                .HasMany(e => e.DanhSachSaches)
                .WithOptional(e => e.HoSo)
                .HasForeignKey(e => e.MaNgNhan);

            modelBuilder.Entity<HoSo>()
                .HasOptional(e => e.TaiKhoanNV)
                .WithRequired(e => e.HoSo);

            modelBuilder.Entity<HoSo>()
                .HasMany(e => e.MatSaches)
                .WithRequired(e => e.HoSo)
                .HasForeignKey(e => e.MaNgGhiNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoSo>()
                .HasMany(e => e.TheDocGias)
                .WithOptional(e => e.HoSo)
                .HasForeignKey(e => e.MaNgLap);

            modelBuilder.Entity<HoSo>()
                .HasMany(e => e.ThanhLies)
                .WithRequired(e => e.HoSo)
                .HasForeignKey(e => e.MaNgThanhLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatSach>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<MatSach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<MatSach>()
                .Property(e => e.MaNgGhiNhan)
                .IsUnicode(false);

            modelBuilder.Entity<MuonSach>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<MuonSach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhLy>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhLy>()
                .Property(e => e.MaNgThanhLy)
                .IsUnicode(false);

            modelBuilder.Entity<TheDocGia>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TheDocGia>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TheDocGia>()
                .Property(e => e.MaNgLap)
                .IsUnicode(false);

            modelBuilder.Entity<TheDocGia>()
                .HasMany(e => e.MatSaches)
                .WithRequired(e => e.TheDocGia)
                .HasForeignKey(e => e.MaDocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheDocGia>()
                .HasMany(e => e.MuonSaches)
                .WithRequired(e => e.TheDocGia)
                .HasForeignKey(e => e.MaDocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheDocGia>()
                .HasMany(e => e.TraSaches)
                .WithRequired(e => e.TheDocGia)
                .HasForeignKey(e => e.MaDocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TraSach>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<TraSach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);
        }
    }
}

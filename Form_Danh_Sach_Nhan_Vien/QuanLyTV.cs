namespace Form_Danh_Sach_Nhan_Vien
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

        public virtual DbSet<HoSo> HoSoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoSo>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoSo>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);
        }
    }
}

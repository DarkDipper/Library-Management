namespace QuanLyKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoSo")]
    public partial class HoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoSo()
        {
            DanhSachSaches = new HashSet<DanhSachSach>();
            MatSaches = new HashSet<MatSach>();
            TheDocGias = new HashSet<TheDocGia>();
            ThanhLies = new HashSet<ThanhLy>();
        }

        [Key]
        [StringLength(5)]
        public string MaNV { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string BangCap { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(12)]
        public string DienThoai { get; set; }

        [StringLength(10)]
        public string BoPhan { get; set; }

        public DateTime? NgayLamViec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachSach> DanhSachSaches { get; set; }

        public virtual TaiKhoanNV TaiKhoanNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatSach> MatSaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheDocGia> TheDocGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhLy> ThanhLies { get; set; }
    }
}

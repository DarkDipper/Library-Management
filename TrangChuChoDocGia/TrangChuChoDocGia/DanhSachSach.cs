namespace Trang_Chu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhSachSach")]
    public partial class DanhSachSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhSachSach()
        {
            MatSaches = new HashSet<MatSach>();
            MuonSaches = new HashSet<MuonSach>();
            ThanhLies = new HashSet<ThanhLy>();
            TraSaches = new HashSet<TraSach>();
        }

        [Key]
        [StringLength(5)]
        public string MaSach { get; set; }

        [StringLength(100)]
        public string TenSach { get; set; }

        [StringLength(100)]
        public string TacGia { get; set; }

        [StringLength(50)]
        public string TheLoai { get; set; }

        public int? NamXuatBan { get; set; }

        [StringLength(100)]
        public string NhaXuatBan { get; set; }

        public DateTime? NgayNhap { get; set; }

        public int? TriGia { get; set; }

        [StringLength(30)]
        public string TinhTrang { get; set; }

        [StringLength(5)]
        public string MaNgNhan { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anh { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public float? DanhGia { get; set; }
        public string LuotDanhGia { get; set; }


        public virtual HoSo HoSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatSach> MatSaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuonSach> MuonSaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhLy> ThanhLies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraSach> TraSaches { get; set; }
    }
}

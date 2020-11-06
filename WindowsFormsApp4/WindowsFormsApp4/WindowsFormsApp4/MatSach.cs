namespace WindowsFormsApp4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatSach")]
    public partial class MatSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaDocGia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaSach { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string MaNgGhiNhan { get; set; }

        public DateTime? NgayGhiNhan { get; set; }

        public int? SoTienThu { get; set; }

        public virtual DanhSachSach DanhSachSach { get; set; }

        public virtual HoSo HoSo { get; set; }

        public virtual TheDocGia TheDocGia { get; set; }
    }
}

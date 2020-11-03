namespace QLDG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraSach")]
    public partial class TraSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaDocGia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaSach { get; set; }

        public DateTime? NgayTra { get; set; }

        public int? TienPhat { get; set; }

        public int? SoNgayMuon { get; set; }

        public virtual DanhSachSach DanhSachSach { get; set; }

        public virtual TheDocGia TheDocGia { get; set; }
    }
}

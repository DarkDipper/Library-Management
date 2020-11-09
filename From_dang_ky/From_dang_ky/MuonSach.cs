namespace From_dang_ky
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MuonSach")]
    public partial class MuonSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaDocGia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaSach { get; set; }

        public DateTime? NgayMuon { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual DanhSachSach DanhSachSach { get; set; }

        public virtual TheDocGia TheDocGia { get; set; }
    }
}

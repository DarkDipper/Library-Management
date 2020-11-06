namespace QuanLyKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuMuon")]
    public partial class LichSuMuon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TheLoai { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Thang { get; set; }
        public int? SoLuot { get; set; }
    }
}

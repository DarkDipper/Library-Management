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
        [StringLength(50)]
        public string TheLoai { get; set; }

        public int? SoLuot { get; set; }
    }
}

namespace QLDG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanNV")]
    public partial class TaiKhoanNV
    {
        [Key]
        [StringLength(5)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string TenDN { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        public virtual HoSo HoSo { get; set; }
    }
}

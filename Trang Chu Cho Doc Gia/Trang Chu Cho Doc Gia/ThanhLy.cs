namespace Trang_Chu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhLy")]
    public partial class ThanhLy
    {
        [StringLength(5)]
        public string MaSach { get; set; }

        [StringLength(5)]
        public string MaNgThanhLy { get; set; }

        public DateTime? NgayThanhLy { get; set; }

        [Key]
        [StringLength(50)]
        public string LyDo { get; set; }

        public virtual DanhSachSach DanhSachSach { get; set; }

        public virtual HoSo HoSo { get; set; }
    }
}

namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NganQuy")]
    public partial class NganQuy
    {
        [Key]
        [StringLength(10)]
        public string MaNQ { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDT { get; set; }

        public DateTime ThoiGian { get; set; }

        public decimal SoTien { get; set; }

        public virtual DoiTac DoiTac { get; set; }
    }
}

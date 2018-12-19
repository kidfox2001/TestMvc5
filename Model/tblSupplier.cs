namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSupplier")]
    public partial class tblSupplier
    {
        [Key]
        [Column(Order = 0)]
        public Guid supplier_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string supplier_code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string supplier_name { get; set; }

        [StringLength(50)]
        public string tax_code { get; set; }

        [StringLength(255)]
        public string contact { get; set; }

        [StringLength(255)]
        public string tel { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(10)]
        public string tax_id { get; set; }

        [StringLength(10)]
        public string term { get; set; }

        public int? term_days { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

       // [Key]
        [Column(Order = 3)]
        public bool is_active { get; set; }
    }
}

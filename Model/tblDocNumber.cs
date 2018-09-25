namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDocNumber")]
    public partial class tblDocNumber
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string doc_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string doc_c1 { get; set; }

        public int? doc_number { get; set; }
    }
}

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUnit")]
    public partial class tblUnit
    {
        [Key]
        [Column(Order = 0)]
        public Guid unit_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string unit_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool is_active { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }
    }
}

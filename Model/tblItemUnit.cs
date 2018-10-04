namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblItemUnit")]
    public partial class tblItemUnit
    {
        [Key]
        [Column(Order = 0)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid item_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid unit_id { get; set; }

        public decimal? cost { get; set; }

        public decimal? multiply { get; set; }

        public bool? itemunit_default { get; set; }

        public bool? is_active { get; set; }

    }
}

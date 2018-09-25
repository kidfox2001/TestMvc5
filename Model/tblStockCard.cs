namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStockCard")]
    public partial class tblStockCard
    {
        [Key]
        [Column(Order = 0)]
        public Guid sc_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string doc_number { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte doc_type { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid location_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal item_number { get; set; }

        public decimal? item_cost_total { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

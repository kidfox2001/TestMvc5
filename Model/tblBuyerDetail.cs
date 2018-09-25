namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBuyerDetail")]
    public partial class tblBuyerDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid byd_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid buyer_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid item_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid unit_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal item_number { get; set; }

        public decimal? item_cost { get; set; }

        public decimal? item_cost_total { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }
    }
}

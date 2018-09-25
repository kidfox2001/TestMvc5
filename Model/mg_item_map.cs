namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mg_item_map
    {
        [Key]
        public Guid itemunit_id { get; set; }

        [StringLength(30)]
        public string item_id { get; set; }

        [StringLength(30)]
        public string unit_id { get; set; }

        public decimal? cost { get; set; }

        public decimal? multiply { get; set; }

        public bool? itemunit_default { get; set; }

        public bool? is_active { get; set; }
    }
}

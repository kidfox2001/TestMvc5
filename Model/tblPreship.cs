namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPreship")]
    public partial class tblPreship
    {
        [Key]
        [Column(Order = 0)]
        public Guid preship_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte preship_status { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string preship_doc { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime preship_date { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid request_location { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid location_id { get; set; }

        public decimal? preship_sum_item { get; set; }

        public decimal? preship_sum_cost { get; set; }

        public string note { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid update_by { get; set; }
    }
}

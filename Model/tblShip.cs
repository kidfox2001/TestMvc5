namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblShip")]
    public partial class tblShip
    {
        [Key]
        [Column(Order = 0)]
        public Guid ship_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte ship_status { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte ship_receive_status { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ship_doc { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smalldatetime")]
        public DateTime ship_date { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid request_location { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid location_id { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ship_sum_item { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ship_sum_cost { get; set; }

        public string note { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }

        [Key]
        [Column(Order = 10)]
        public Guid update_by { get; set; }
    }
}

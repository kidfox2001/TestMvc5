namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReceiverDetail")]
    public partial class tblReceiverDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid rvd_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid receiver_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal item_receive_number { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal item_number { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal item_cost { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal item_cost_total { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

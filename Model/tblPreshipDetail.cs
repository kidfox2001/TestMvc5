namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPreshipDetail")]
    public partial class tblPreshipDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid psd_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid preship_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal item_request_number { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal item_preship_number { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal cost { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

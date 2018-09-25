namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRequestDetail")]
    public partial class tblRequestDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid rqd_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid request_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal item_number { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal cost { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

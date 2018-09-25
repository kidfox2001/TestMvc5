namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReceiveShipment")]
    public partial class tblReceiveShipment
    {
        [Key]
        [Column(Order = 0)]
        public Guid rsp_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte rsp_status { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string rsp_doc { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime rsp_date { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid location_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal rsp_sum_item { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal rsp_sum_cost { get; set; }

        public string note { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }

        [Key]
        [Column(Order = 8)]
        public Guid update_by { get; set; }
    }
}

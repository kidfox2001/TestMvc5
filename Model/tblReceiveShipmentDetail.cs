namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReceiveShipmentDetail")]
    public partial class tblReceiveShipmentDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid rspd_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid rsp_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal item_ship_number { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal item_receive_number { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal cost { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

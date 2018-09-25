namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblShipMap")]
    public partial class tblShipMap
    {
        [Key]
        [Column(Order = 0)]
        public Guid sm_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ship_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid rsp_id { get; set; }
    }
}

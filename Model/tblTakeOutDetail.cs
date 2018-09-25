namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTakeOutDetail")]
    public partial class tblTakeOutDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid tod_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid takeout_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid itemunit_id { get; set; }

        public decimal? item_number { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

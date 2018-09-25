namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTranferDetail")]
    public partial class tblTranferDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid trd_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid tran_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid itemunit_id { get; set; }

        public decimal? item_out_number { get; set; }

        public decimal? item_in_number { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }
    }
}

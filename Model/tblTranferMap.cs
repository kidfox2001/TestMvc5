namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTranferMap")]
    public partial class tblTranferMap
    {
        [Key]
        [Column(Order = 0)]
        public Guid tm_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid tran_out { get; set; }

        public Guid? tran_in { get; set; }
    }
}

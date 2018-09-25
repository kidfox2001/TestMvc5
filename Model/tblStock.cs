namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStock")]
    public partial class tblStock
    {
        [Key]
        [Column(Order = 0)]
        public Guid st_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid itemunit_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid location_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int qty { get; set; }
    }
}

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTakeOut")]
    public partial class tblTakeOut
    {
        [Key]
        [Column(Order = 0)]
        public Guid takeout_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte takeout_status { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string takeout_doc { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime takeout_date { get; set; }

        public Guid? location_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal takeout_sum_item { get; set; }

        public string note { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid update_by { get; set; }
    }
}

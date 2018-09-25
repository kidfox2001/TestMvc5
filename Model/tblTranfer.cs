namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTranfer")]
    public partial class tblTranfer
    {
        [Key]
        [Column(Order = 0)]
        public Guid tran_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte tran_type { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte tran_status { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string tran_doc { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smalldatetime")]
        public DateTime tran_date { get; set; }

        public Guid? from_location { get; set; }

        public Guid? to_location { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal tran_sum_item { get; set; }

        public string note { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid update_by { get; set; }
    }
}

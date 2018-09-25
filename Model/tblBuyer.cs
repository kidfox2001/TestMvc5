namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBuyer")]
    public partial class tblBuyer
    {
        [Key]
        [Column(Order = 0)]
        public Guid buyer_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte buyer_status { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string buyer_doc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? buyer_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? term_date { get; set; }

        public Guid? location_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? send_date { get; set; }

        public Guid? buyer { get; set; }

        public int? term { get; set; }

        public Guid? supplier_id { get; set; }

        public decimal? sum_amount { get; set; }

        public decimal? vat_percent { get; set; }

        public decimal? vat { get; set; }

        public decimal? total { get; set; }

        public bool? is_receive { get; set; }

        public string note { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public Guid? update_by { get; set; }
    }
}

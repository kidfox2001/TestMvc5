namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReceiver")]
    public partial class tblReceiver
    {
        [Key]
        [Column(Order = 0)]
        public Guid receiver_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string receiver_doc { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime receiver_date { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte receiver_status { get; set; }

        [StringLength(50)]
        public string invoice_doc { get; set; }

        public Guid? buyer_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid location_id { get; set; }

        public decimal? sum_amount { get; set; }

        public decimal? vat_percent { get; set; }

        public decimal? vat { get; set; }

        public decimal? total { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public Guid? update_by { get; set; }

        public string note { get; set; }
    }
}

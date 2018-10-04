namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblItem")]
    public partial class tblItem
    {
        [Key]
        [Column(Order = 0)]
        public Guid item_id { get; set; }

      
        [Column(Order = 1)]
        [StringLength(50)]
        public string item_code { get; set; }

        [Column(Order = 2)]
        [StringLength(255)]
        public string item_name { get; set; }

        [StringLength(50)]
        public string barcode { get; set; }

        public Guid? location_id { get; set; }
        public  tblLocation tblLocation { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public bool? is_active { get; set; }
    }
}

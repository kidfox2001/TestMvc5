namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLocation")]
    public partial class tblLocation
    {
        [Key]
        [Column(Order = 0)]
        public Guid location_id { get; set; }

  
        [Column(Order = 1)]
        [StringLength(50)]
        public string location_code { get; set; }

   
        [Column(Order = 2)]
        [StringLength(255)]
        public string location_name { get; set; }

        [StringLength(255)]
        public string location_address { get; set; }

        public byte? locationtype_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

  
        [Column(Order = 3)]
        public bool is_active { get; set; }

        public  ICollection<tblItem> tblItems { get; set; } = new HashSet<tblItem>();
    }
}

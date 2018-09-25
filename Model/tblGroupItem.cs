namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblGroupItem")]
    public partial class tblGroupItem
    {
        [Key]
        [Column(Order = 0)]
        public Guid groupitem_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string groupitem_name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public bool? is_active { get; set; }
    }
}

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCategoryItem")]
    public partial class tblCategoryItem
    {
        [Key]
        [Column(Order = 0)]
        public Guid categoryitem_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string categoryitem_name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public bool? is_active { get; set; }
    }
}

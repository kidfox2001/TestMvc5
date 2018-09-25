namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysGroup")]
    public partial class tblSysGroup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int group_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string group_name { get; set; }

        public bool? is_active { get; set; }
    }
}

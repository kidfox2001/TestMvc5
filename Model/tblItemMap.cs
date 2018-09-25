namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblItemMap")]
    public partial class tblItemMap
    {
        [Key]
        [Column(Order = 0)]
        public Guid im_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid item_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte item_level { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid item_map_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte item_map_level { get; set; }
    }
}

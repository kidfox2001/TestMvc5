namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_ip
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string wan_ip { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime mod_dt { get; set; }
    }
}

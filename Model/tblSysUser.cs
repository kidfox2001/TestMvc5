namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysUser")]
    public partial class tblSysUser
    {
        [Key]
        [Column(Order = 0)]
        public Guid user_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string user_password { get; set; }

        [StringLength(100)]
        public string user_firstname { get; set; }

        [StringLength(100)]
        public string user_lastname { get; set; }

        public int? group_id { get; set; }

        public Guid? location_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public bool? is_active { get; set; }
    }
}

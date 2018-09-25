namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRequestMap")]
    public partial class tblRequestMap
    {
        [Key]
        public Guid rm_id { get; set; }

        public Guid? request_id { get; set; }

        public Guid? preship_id { get; set; }

        public Guid? ship_id { get; set; }

        public Guid? preship_ship_id { get; set; }
    }
}

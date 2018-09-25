namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRequest")]
    public partial class tblRequest
    {
        [Key]
        [Column(Order = 0)]
        public Guid request_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte request_status { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string request_doc { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime request_date { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid location_id { get; set; }

        public decimal? request_sum_item { get; set; }

        public decimal? request_sum_cost { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid user_id { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime update_date { get; set; }

        public string note { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid update_by { get; set; }
    }
}

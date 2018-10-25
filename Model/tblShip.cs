using TFundSolution.Utils.EntityFramworks;

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblShip")]
    public partial class tblShip
    {
        [Key]
        public Guid ship_id { get; set; }

        public byte? ship_status { get; set; }

        public byte? ship_receive_status { get; set; }

        [StringLength(50)]
        public string ship_doc { get; set; }

        [xxx]
        [Required(ErrorMessage = "ต้องระบุ")]
        [DataType(DataType.DateTime, ErrorMessage = "nnn")]
        // [Column(TypeName = "smalldatetime")]
        public DateTime ship_date { get; set; }

        public Guid? request_location { get; set; }

        public Guid? location_id { get; set; }

        public decimal? ship_sum_item { get; set; }

        public decimal? ship_sum_cost { get; set; }

        public string note { get; set; }

        [Column( TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public Guid? update_by { get; set; }
    }
}

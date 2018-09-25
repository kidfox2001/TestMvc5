namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ms_sup_cr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cycle_Cr { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string supplier_code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string supplier_name { get; set; }

        [StringLength(10)]
        public string term { get; set; }

        [StringLength(30)]
        public string CODEDESC { get; set; }

        public decimal? Begin_DT { get; set; }

        public decimal? End_DT { get; set; }

        public decimal? CR_Month { get; set; }

        public decimal? Pay_Days { get; set; }
    }
}

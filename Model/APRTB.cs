namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APRTB")]
    public partial class APRTB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string TERMSCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal PAYMNBR { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AUDTDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AUDTTIME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string AUDTUSER { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(6)]
        public string AUDTORG { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal DATELASTMN { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal PCTPAYMDUE { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DISCTYPE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal PCTDISC { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal DISNBRDAYS { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal DISCDAY { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DUETYPE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal DUENBRDAYS { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal DUEDAY { get; set; }
    }
}

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TXRATE")]
    public partial class TXRATE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string AUTHORITY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BUYERCLASS { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AUDTDATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal AUDTTIME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(8)]
        public string AUDTUSER { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string AUDTORG { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ITEMRATE1 { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ITEMRATE2 { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ITEMRATE3 { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal ITEMRATE4 { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal ITEMRATE5 { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal ITEMRATE6 { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal ITEMRATE7 { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal ITEMRATE8 { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal ITEMRATE9 { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal ITEMRATE10 { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal LASTMAINT { get; set; }
    }
}

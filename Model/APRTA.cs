namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APRTA")]
    public partial class APRTA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string TERMSCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal AUDTDATE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AUDTTIME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string AUDTUSER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string AUDTORG { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string CODEDESC { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SWACTV { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal DATEINACTV { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DATELASTMN { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SWMULTPAYM { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CODEVAT { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CODEDISTYP { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal DISDAYSTR1 { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal DISDAYSTR2 { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal DISDAYSTR3 { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal DISDAYSTR4 { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal DISDAYEND1 { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal DISDAYEND2 { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal DISDAYEND3 { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal DISDAYEND4 { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal DISMTHADD1 { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal DISMTHADD2 { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal DISMTHADD3 { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal DISMTHADD4 { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal DISDAYUSE1 { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal DISDAYUSE2 { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal DISDAYUSE3 { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal DISDAYUSE4 { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CODEDUETYP { get; set; }

        [Key]
        [Column(Order = 29)]
        public decimal DUEDAYSTR1 { get; set; }

        [Key]
        [Column(Order = 30)]
        public decimal DUEDAYSTR2 { get; set; }

        [Key]
        [Column(Order = 31)]
        public decimal DUEDAYSTR3 { get; set; }

        [Key]
        [Column(Order = 32)]
        public decimal DUEDAYSTR4 { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal DUEDAYEND1 { get; set; }

        [Key]
        [Column(Order = 34)]
        public decimal DUEDAYEND2 { get; set; }

        [Key]
        [Column(Order = 35)]
        public decimal DUEDAYEND3 { get; set; }

        [Key]
        [Column(Order = 36)]
        public decimal DUEDAYEND4 { get; set; }

        [Key]
        [Column(Order = 37)]
        public decimal DUEMTHADD1 { get; set; }

        [Key]
        [Column(Order = 38)]
        public decimal DUEMTHADD2 { get; set; }

        [Key]
        [Column(Order = 39)]
        public decimal DUEMTHADD3 { get; set; }

        [Key]
        [Column(Order = 40)]
        public decimal DUEMTHADD4 { get; set; }

        [Key]
        [Column(Order = 41)]
        public decimal DUEDAYUSE1 { get; set; }

        [Key]
        [Column(Order = 42)]
        public decimal DUEDAYUSE2 { get; set; }

        [Key]
        [Column(Order = 43)]
        public decimal DUEDAYUSE3 { get; set; }

        [Key]
        [Column(Order = 44)]
        public decimal DUEDAYUSE4 { get; set; }

        [Key]
        [Column(Order = 45)]
        public decimal CNTENTERED { get; set; }

        [Key]
        [Column(Order = 46)]
        public decimal PCTDUETOT { get; set; }
    }
}

using Model;

namespace ServicePrs
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelPrs : DbContext
    {
        public ModelPrs()
            : base("name=ModelPrs")
        {
            Database.SetInitializer<ModelPrs>(null);
        }

        public virtual DbSet<APRTA> APRTAs { get; set; }
        public virtual DbSet<APRTB> APRTBs { get; set; }
        public virtual DbSet<log_ip> log_ip { get; set; }
        public virtual DbSet<mg_item_map> mg_item_map { get; set; }
        public virtual DbSet<ms_sup_cr> ms_sup_cr { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblBuyer> tblBuyers { get; set; }
        public virtual DbSet<tblBuyerDetail> tblBuyerDetails { get; set; }
        public virtual DbSet<tblCategoryItem> tblCategoryItems { get; set; }
        public virtual DbSet<tblDocNumber> tblDocNumbers { get; set; }
        public virtual DbSet<tblGroupItem> tblGroupItems { get; set; }
        public virtual DbSet<tblItem> tblItems { get; set; }
        public virtual DbSet<tblItemMap> tblItemMaps { get; set; }
        public virtual DbSet<tblItemUnit> tblItemUnits { get; set; }
        public virtual DbSet<tblLocation> tblLocations { get; set; }
        public virtual DbSet<tblLocationType> tblLocationTypes { get; set; }
        public virtual DbSet<tblPreship> tblPreships { get; set; }
        public virtual DbSet<tblPreshipDetail> tblPreshipDetails { get; set; }
        public virtual DbSet<tblReceiver> tblReceivers { get; set; }
        public virtual DbSet<tblReceiverDetail> tblReceiverDetails { get; set; }
        public virtual DbSet<tblReceiveShipment> tblReceiveShipments { get; set; }
        public virtual DbSet<tblReceiveShipmentDetail> tblReceiveShipmentDetails { get; set; }
        public virtual DbSet<tblRequest> tblRequests { get; set; }
        public virtual DbSet<tblRequestDetail> tblRequestDetails { get; set; }
        public virtual DbSet<tblRequestMap> tblRequestMaps { get; set; }
        public virtual DbSet<tblShip> tblShips { get; set; }
        public virtual DbSet<tblShipDetail> tblShipDetails { get; set; }
        public virtual DbSet<tblShipMap> tblShipMaps { get; set; }
        public virtual DbSet<tblStock> tblStocks { get; set; }
        public virtual DbSet<tblStockCard> tblStockCards { get; set; }
        public virtual DbSet<tblSupplier> tblSuppliers { get; set; }
        public virtual DbSet<tblSysGroup> tblSysGroups { get; set; }
        public virtual DbSet<tblSysUser> tblSysUsers { get; set; }
        public virtual DbSet<tblTakeOut> tblTakeOuts { get; set; }
        public virtual DbSet<tblTakeOutDetail> tblTakeOutDetails { get; set; }
        public virtual DbSet<tblTranfer> tblTranfers { get; set; }
        public virtual DbSet<tblTranferDetail> tblTranferDetails { get; set; }
        public virtual DbSet<tblTranferMap> tblTranferMaps { get; set; }
        public virtual DbSet<tblUnit> tblUnits { get; set; }
        public virtual DbSet<TXRATE> TXRATEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APRTA>()
                .Property(e => e.TERMSCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.AUDTDATE)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.AUDTTIME)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.AUDTUSER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.AUDTORG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.CODEDESC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DATEINACTV)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DATELASTMN)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYSTR1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYSTR2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYSTR3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYSTR4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYEND1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYEND2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYEND3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYEND4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISMTHADD1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISMTHADD2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISMTHADD3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISMTHADD4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYUSE1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYUSE2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYUSE3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DISDAYUSE4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYSTR1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYSTR2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYSTR3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYSTR4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYEND1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYEND2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYEND3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYEND4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEMTHADD1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEMTHADD2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEMTHADD3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEMTHADD4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYUSE1)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYUSE2)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYUSE3)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.DUEDAYUSE4)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.CNTENTERED)
                .HasPrecision(7, 0);

            modelBuilder.Entity<APRTA>()
                .Property(e => e.PCTDUETOT)
                .HasPrecision(9, 5);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.TERMSCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.PAYMNBR)
                .HasPrecision(5, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.AUDTDATE)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.AUDTTIME)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.AUDTUSER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.AUDTORG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.DATELASTMN)
                .HasPrecision(9, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.PCTPAYMDUE)
                .HasPrecision(9, 5);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.PCTDISC)
                .HasPrecision(9, 5);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.DISNBRDAYS)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.DISCDAY)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.DUENBRDAYS)
                .HasPrecision(3, 0);

            modelBuilder.Entity<APRTB>()
                .Property(e => e.DUEDAY)
                .HasPrecision(3, 0);

            modelBuilder.Entity<log_ip>()
                .Property(e => e.wan_ip)
                .IsFixedLength();

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.Cycle_Cr)
                .IsUnicode(false);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.supplier_code)
                .IsUnicode(false);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.supplier_name)
                .IsUnicode(false);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.CODEDESC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.Begin_DT)
                .HasPrecision(3, 0);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.End_DT)
                .HasPrecision(3, 0);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.CR_Month)
                .HasPrecision(3, 0);

            modelBuilder.Entity<ms_sup_cr>()
                .Property(e => e.Pay_Days)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tblBuyer>()
                .Property(e => e.buyer_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblBuyer>()
                .Property(e => e.sum_amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblBuyer>()
                .Property(e => e.vat)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblBuyer>()
                .Property(e => e.total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblBuyer>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblCategoryItem>()
                .Property(e => e.categoryitem_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocNumber>()
                .Property(e => e.doc_type)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocNumber>()
                .Property(e => e.doc_c1)
                .IsUnicode(false);

            modelBuilder.Entity<tblGroupItem>()
                .Property(e => e.groupitem_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblItem>()
                .Property(e => e.item_code)
                .IsUnicode(false);

            modelBuilder.Entity<tblItem>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblItem>()
                .Property(e => e.barcode)
                .IsUnicode(false);

            modelBuilder.Entity<tblLocation>()
                .Property(e => e.location_code)
                .IsUnicode(false);

            modelBuilder.Entity<tblLocation>()
                .Property(e => e.location_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblLocation>()
                .Property(e => e.location_address)
                .IsUnicode(false);

            modelBuilder.Entity<tblLocationType>()
                .Property(e => e.locationtype_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblPreship>()
                .Property(e => e.preship_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPreship>()
                .Property(e => e.preship_sum_cost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPreship>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblReceiver>()
                .Property(e => e.receiver_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblReceiver>()
                .Property(e => e.invoice_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblReceiver>()
                .Property(e => e.sum_amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblReceiver>()
                .Property(e => e.vat)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblReceiver>()
                .Property(e => e.total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblReceiver>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblReceiveShipment>()
                .Property(e => e.rsp_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblReceiveShipment>()
                .Property(e => e.rsp_sum_cost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblReceiveShipment>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblRequest>()
                .Property(e => e.request_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblRequest>()
                .Property(e => e.request_sum_cost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblRequest>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblShip>()
                .Property(e => e.ship_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblShip>()
                .Property(e => e.ship_sum_cost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblShip>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblStockCard>()
                .Property(e => e.doc_number)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.supplier_code)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.supplier_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.tax_code)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.tax_id)
                .IsUnicode(false);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<tblSysGroup>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblSysUser>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblSysUser>()
                .Property(e => e.user_password)
                .IsUnicode(false);

            modelBuilder.Entity<tblSysUser>()
                .Property(e => e.user_firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblSysUser>()
                .Property(e => e.user_lastname)
                .IsUnicode(false);

            modelBuilder.Entity<tblTakeOut>()
                .Property(e => e.takeout_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblTakeOut>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblTranfer>()
                .Property(e => e.tran_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tblTranfer>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<tblUnit>()
                .Property(e => e.unit_name)
                .IsUnicode(false);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.AUTHORITY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.AUDTDATE)
                .HasPrecision(9, 0);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.AUDTTIME)
                .HasPrecision(9, 0);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.AUDTUSER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.AUDTORG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE1)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE2)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE3)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE4)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE5)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE6)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE7)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE8)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE9)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.ITEMRATE10)
                .HasPrecision(15, 5);

            modelBuilder.Entity<TXRATE>()
                .Property(e => e.LASTMAINT)
                .HasPrecision(9, 0);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop2StopDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
<<<<<<< HEAD
    public partial class Stop2ShopEntities : DbContext
    {
        public Stop2ShopEntities()
            : base("name=Stop2ShopEntities")
=======
    public partial class Stop2ShopContext : DbContext
    {
        public Stop2ShopContext()
            : base("name=Stop2ShopContext")
>>>>>>> master
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_AREA> tbl_AREA { get; set; }
        public virtual DbSet<tbl_BIN> tbl_BIN { get; set; }
        public virtual DbSet<tbl_CUSTOMER> tbl_CUSTOMER { get; set; }
        public virtual DbSet<tbl_CUSTOMER_ADDRESS> tbl_CUSTOMER_ADDRESS { get; set; }
        public virtual DbSet<tbl_CUSTOMER_TYPE> tbl_CUSTOMER_TYPE { get; set; }
        public virtual DbSet<tbl_GROUP> tbl_GROUP { get; set; }
        public virtual DbSet<tbl_ID_TABLE> tbl_ID_TABLE { get; set; }
        public virtual DbSet<tbl_ITEM_TYPE> tbl_ITEM_TYPE { get; set; }
        public virtual DbSet<tbl_MENU> tbl_MENU { get; set; }
        public virtual DbSet<tbl_PART_MFR_LOC_RACK_BIN> tbl_PART_MFR_LOC_RACK_BIN { get; set; }
        public virtual DbSet<tbl_PAYMENT_MODE> tbl_PAYMENT_MODE { get; set; }
        public virtual DbSet<tbl_PERMISSION> tbl_PERMISSION { get; set; }
        public virtual DbSet<tbl_PICK_SLIP> tbl_PICK_SLIP { get; set; }
        public virtual DbSet<tbl_PICK_SLIP_PART> tbl_PICK_SLIP_PART { get; set; }
        public virtual DbSet<tbl_PICK_SLIP_PART_DET> tbl_PICK_SLIP_PART_DET { get; set; }
        public virtual DbSet<tbl_PICK_SLIP_SO> tbl_PICK_SLIP_SO { get; set; }
        public virtual DbSet<tbl_PROCESS> tbl_PROCESS { get; set; }
        public virtual DbSet<tbl_RACK> tbl_RACK { get; set; }
        public virtual DbSet<tbl_ROLE> tbl_ROLE { get; set; }
        public virtual DbSet<tbl_SO_CLOSE_REASON> tbl_SO_CLOSE_REASON { get; set; }
        public virtual DbSet<tbl_SPARE_COST> tbl_SPARE_COST { get; set; }
        public virtual DbSet<tbl_SPARE_INV_PART_DET> tbl_SPARE_INV_PART_DET { get; set; }
        public virtual DbSet<tbl_SPARE_INVOICE> tbl_SPARE_INVOICE { get; set; }
        public virtual DbSet<tbl_SPARE_INVOICE_PART> tbl_SPARE_INVOICE_PART { get; set; }
        public virtual DbSet<tbl_SPARE_PART> tbl_SPARE_PART { get; set; }
        public virtual DbSet<tbl_SPARE_PART_LOC> tbl_SPARE_PART_LOC { get; set; }
        public virtual DbSet<tbl_SPARE_PO> tbl_SPARE_PO { get; set; }
        public virtual DbSet<tbl_SPARE_PO_DET> tbl_SPARE_PO_DET { get; set; }
        public virtual DbSet<tbl_SPARE_SALE_ORDER> tbl_SPARE_SALE_ORDER { get; set; }
        public virtual DbSet<tbl_SPARE_SO_PART> tbl_SPARE_SO_PART { get; set; }
        public virtual DbSet<tbl_STATE> tbl_STATE { get; set; }
        public virtual DbSet<tbl_STORAGE_LOC> tbl_STORAGE_LOC { get; set; }
        public virtual DbSet<tbl_USER> tbl_USER { get; set; }
        public virtual DbSet<tbl_USER_ROLE> tbl_USER_ROLE { get; set; }
        public virtual DbSet<tbl_VENDOR> tbl_VENDOR { get; set; }
    }
}

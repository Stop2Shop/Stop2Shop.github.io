//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stop2ShopDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_SPARE_SALE_ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SPARE_SALE_ORDER()
        {
            this.tbl_PICK_SLIP_PART = new HashSet<tbl_PICK_SLIP_PART>();
            this.tbl_PICK_SLIP_SO = new HashSet<tbl_PICK_SLIP_SO>();
            this.tbl_SPARE_INVOICE_PART = new HashSet<tbl_SPARE_INVOICE_PART>();
            this.tbl_SPARE_SO_PART = new HashSet<tbl_SPARE_SO_PART>();
        }
    
        public int OWNER_ID { get; set; }
        public int SALE_ORDER_ID { get; set; }
        public Nullable<int> SALE_ORDER_NO { get; set; }
        public System.DateTime ORDER_DATE { get; set; }
        public Nullable<int> LOCATION_ID { get; set; }
        public Nullable<int> CUSTOMER_ID { get; set; }
        public Nullable<short> PAYMENT_MODE_ID { get; set; }
        public Nullable<int> REF_CUST_PO { get; set; }
        public Nullable<System.DateTime> REF_CUST_PO_DATE { get; set; }
        public Nullable<byte> BILL_TYPE { get; set; }
        public Nullable<decimal> ORDER_VALUE { get; set; }
        public byte STATUS { get; set; }
        public bool PICKSLIP_EXISTS { get; set; }
        public Nullable<short> REASON_ID { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_ON { get; set; }
        public string MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public bool ACTIVE { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        public virtual tbl_CUSTOMER tbl_CUSTOMER { get; set; }
        public virtual tbl_PAYMENT_MODE tbl_PAYMENT_MODE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PICK_SLIP_PART> tbl_PICK_SLIP_PART { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PICK_SLIP_SO> tbl_PICK_SLIP_SO { get; set; }
        public virtual tbl_SO_CLOSE_REASON tbl_SO_CLOSE_REASON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SPARE_INVOICE_PART> tbl_SPARE_INVOICE_PART { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SPARE_SO_PART> tbl_SPARE_SO_PART { get; set; }
        public virtual tbl_STORAGE_LOC tbl_STORAGE_LOC { get; set; }
    }
}

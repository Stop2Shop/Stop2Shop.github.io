//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_PICK_SLIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PICK_SLIP()
        {
            this.tbl_PICK_SLIP_PART = new HashSet<tbl_PICK_SLIP_PART>();
            this.tbl_PICK_SLIP_SO = new HashSet<tbl_PICK_SLIP_SO>();
            this.tbl_SPARE_INVOICE = new HashSet<tbl_SPARE_INVOICE>();
        }
    
        public int OWNER_ID { get; set; }
        public int PICK_SLIP_ID { get; set; }
        public Nullable<int> PICK_SLIP_NO { get; set; }
        public System.DateTime PICK_SLIP_DATE { get; set; }
        public Nullable<System.DateTime> PS_CONFIRMED_DATE { get; set; }
        public Nullable<decimal> SLIP_VALUE { get; set; }
        public bool STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_ON { get; set; }
        public string MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public bool ACTIVE { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PICK_SLIP_PART> tbl_PICK_SLIP_PART { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PICK_SLIP_SO> tbl_PICK_SLIP_SO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SPARE_INVOICE> tbl_SPARE_INVOICE { get; set; }
    }
}

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
    
    public partial class tbl_RACK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_RACK()
        {
            this.tbl_BIN = new HashSet<tbl_BIN>();
            this.tbl_PART_MFR_LOC_RACK_BIN = new HashSet<tbl_PART_MFR_LOC_RACK_BIN>();
            this.tbl_SPARE_PART_LOC = new HashSet<tbl_SPARE_PART_LOC>();
        }
    
        public int OWNER_ID { get; set; }
        public short RACK_ID { get; set; }
        public Nullable<int> LOCATION_ID { get; set; }
        public string RACK_DESC { get; set; }
        public bool DEF_RACK { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BIN> tbl_BIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PART_MFR_LOC_RACK_BIN> tbl_PART_MFR_LOC_RACK_BIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SPARE_PART_LOC> tbl_SPARE_PART_LOC { get; set; }
        public virtual tbl_STORAGE_LOC tbl_STORAGE_LOC { get; set; }
    }
}

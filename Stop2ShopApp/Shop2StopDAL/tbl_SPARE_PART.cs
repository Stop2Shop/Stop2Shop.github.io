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
    
    public partial class tbl_SPARE_PART
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SPARE_PART()
        {
            this.tbl_SPARE_COST = new HashSet<tbl_SPARE_COST>();
            this.tbl_SPARE_PART_LOC = new HashSet<tbl_SPARE_PART_LOC>();
        }
    
        public int OWNER_ID { get; set; }
        public int SPARE_PART_ID { get; set; }
        public string PART_NO { get; set; }
        public string DESCRIPTION { get; set; }
        public bool BLOCK_ORD { get; set; }
        public Nullable<byte> ITEM_TYPE_ID { get; set; }
        public bool BLOCK_FOR_ISSUE { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_ON { get; set; }
        public string MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public bool ACTIVE { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        public virtual tbl_ITEM_TYPE tbl_ITEM_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SPARE_COST> tbl_SPARE_COST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SPARE_PART_LOC> tbl_SPARE_PART_LOC { get; set; }
    }
}

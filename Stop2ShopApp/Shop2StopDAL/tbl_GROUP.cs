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
    
    public partial class tbl_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_GROUP()
        {
            this.tbl_PROCESS = new HashSet<tbl_PROCESS>();
        }
    
        public byte GROUP_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string GROUP_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PROCESS> tbl_PROCESS { get; set; }
    }
}

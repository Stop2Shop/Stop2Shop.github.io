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
    
    public partial class tbl_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_USER()
        {
            this.tbl_USER_ROLE = new HashSet<tbl_USER_ROLE>();
        }
    
        public string USER_PROFILE_ID { get; set; }
        public string PASSWORD { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_USER_ROLE> tbl_USER_ROLE { get; set; }
    }
}

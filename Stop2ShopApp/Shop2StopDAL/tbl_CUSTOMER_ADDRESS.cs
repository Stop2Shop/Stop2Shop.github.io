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
    
    public partial class tbl_CUSTOMER_ADDRESS
    {
        public int CUSTOMER_ID { get; set; }
        public byte ADDRESS_TYPE { get; set; }
        public string ADDRESS_LINE_1 { get; set; }
        public string ADDRESS_LINE_2 { get; set; }
        public string ADDRESS_LINE_3 { get; set; }
        public string CITY { get; set; }
        public Nullable<short> AREA_ID { get; set; }
        public string LANDMARK { get; set; }
        public string STATE_ID { get; set; }
        public string PIN_CODE { get; set; }
        public bool SAME_AS_COMM { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        public virtual tbl_AREA tbl_AREA { get; set; }
        public virtual tbl_CUSTOMER tbl_CUSTOMER { get; set; }
        public virtual tbl_STATE tbl_STATE { get; set; }
    }
}

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
    
    public partial class tbl_SPARE_SO_PART
    {
        public int OWNER_ID { get; set; }
        public int SPARE_SO_PART_ID { get; set; }
        public int SALE_ORDER_ID { get; set; }
        public int SPARE_PART_ID { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public Nullable<byte> STATUS { get; set; }
        public Nullable<short> REASON_ID { get; set; }
        public bool PICKSLIP_EXISTS { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<int> SPARE_PO_PART_ID { get; set; }
        public System.Guid ROWGUID { get; set; }
    
        public virtual tbl_SO_CLOSE_REASON tbl_SO_CLOSE_REASON { get; set; }
        public virtual tbl_SPARE_SALE_ORDER tbl_SPARE_SALE_ORDER { get; set; }
    }
}

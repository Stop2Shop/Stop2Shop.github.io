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
    
    public partial class tbl_MENU
    {
        public short MENU_ID { get; set; }
        public string FORM_NAME { get; set; }
        public string PARENT_TITLE { get; set; }
        public Nullable<short> SHORT_KEY { get; set; }
        public string SHORT_KEY_DESC { get; set; }
        public Nullable<byte> MENU_LEVEL { get; set; }
        public string TITLE { get; set; }
        public Nullable<byte> MENU_SEQ { get; set; }
        public Nullable<byte> OPERATION { get; set; }
        public string ASSEMBLY_NAME { get; set; }
        public string PROCESS { get; set; }
    
        public virtual tbl_PROCESS tbl_PROCESS { get; set; }
    }
}

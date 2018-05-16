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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Invoices = new HashSet<Invoice>();
            this.OrderLines = new HashSet<OrderLine>();
            this.Orders1 = new HashSet<Order>();
        }
    
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int SalespersonPersonID { get; set; }
        public Nullable<int> PickedByPersonID { get; set; }
        public int ContactPersonID { get; set; }
        public Nullable<int> BackorderOrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime ExpectedDeliveryDate { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public bool IsUndersupplyBackordered { get; set; }
        public string Comments { get; set; }
        public string DeliveryInstructions { get; set; }
        public string InternalComments { get; set; }
        public Nullable<System.DateTime> PickingCompletedWhen { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
        public virtual Person Person2 { get; set; }
        public virtual Person Person3 { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders1 { get; set; }
        public virtual Order Order1 { get; set; }
    }
}

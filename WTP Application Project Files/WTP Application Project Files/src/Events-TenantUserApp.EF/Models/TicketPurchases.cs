//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Events_TenantUserApp.EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketPurchases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TicketPurchases()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int TicketPurchaseId { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public decimal PurchaseTotal { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customers Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerSupportEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTicket()
        {
            this.tblAssignTickets = new HashSet<tblAssignTicket>();
            this.tblTicketDetails = new HashSet<tblTicketDetail>();
            this.tblTicketSolutions = new HashSet<tblTicketSolution>();
        }
    
        public int TicketId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> TicketTypeId { get; set; }
        public Nullable<int> SoftwareId { get; set; }
        public Nullable<bool> TicketAssignStatus { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAssignTicket> tblAssignTickets { get; set; }
        public virtual tblSoftware tblSoftware { get; set; }
        public virtual tblTicketType tblTicketType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTicketDetail> tblTicketDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTicketSolution> tblTicketSolutions { get; set; }
    }
}

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
    
    public partial class tblTicketSolution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTicketSolution()
        {
            this.tblAssignDevelopers = new HashSet<tblAssignDeveloper>();
        }
    
        public int TicketSolutionId { get; set; }
        public Nullable<int> TicketId { get; set; }
        public Nullable<int> TicketDetailId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> ProblemId { get; set; }
        public Nullable<int> SolutionId { get; set; }
        public string SolutionSpecification { get; set; }
        public Nullable<bool> AssignedToDeveloper { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Problem Problem { get; set; }
        public virtual Solution Solution { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAssignDeveloper> tblAssignDevelopers { get; set; }
        public virtual tblTicket tblTicket { get; set; }
        public virtual tblTicketDetail tblTicketDetail { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}

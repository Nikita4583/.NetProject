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
    
    public partial class tblSoftwareType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSoftwareType()
        {
            this.tblSoftwares = new HashSet<tblSoftware>();
        }
    
        public int SoftwareTypeId { get; set; }
        public string SoftwareTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSoftware> tblSoftwares { get; set; }
    }
}
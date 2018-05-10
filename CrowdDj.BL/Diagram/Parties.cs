//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrowdDj.BL.Diagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parties
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parties()
        {
            this.Guests = new HashSet<Guests>();
            this.PartyGuests = new HashSet<PartyGuests>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public byte[] RowVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guests> Guests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyGuests> PartyGuests { get; set; }
        public virtual PlayLists PlayLists { get; set; }
    }
}

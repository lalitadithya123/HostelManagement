//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.Allotments = new HashSet<Allotment>();
        }
    
        public int hostelBlockNumber { get; set; }
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public decimal rent { get; set; }
        public int maxOccupancy { get; set; }
        public int currentOccupancy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Allotment> Allotments { get; set; }
        public virtual Hostel Hostel { get; set; }
    }
}

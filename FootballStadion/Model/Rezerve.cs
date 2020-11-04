//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballStadion.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezerve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezerve()
        {
            this.Rezerv_to_Rooms = new HashSet<Rezerv_to_Rooms>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> PlayDate { get; set; }
        public Nullable<System.DateTime> FromTime { get; set; }
        public Nullable<System.DateTime> ToTime { get; set; }
        public string Price { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> StadiumId { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezerv_to_Rooms> Rezerv_to_Rooms { get; set; }
        public virtual Stadium Stadium { get; set; }
    }
}
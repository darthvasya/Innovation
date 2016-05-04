//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InnovationRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.balanceInfs = new HashSet<balanceInf>();
            this.Licenses = new HashSet<License>();
            this.realizations = new HashSet<realization>();
        }
    
        public string name { get; set; }
        public int ID_adress { get; set; }
        public int ID_contact { get; set; }
        public int ID_company { get; set; }
        public int ID_worksheet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<balanceInf> balanceInfs { get; set; }
        public virtual contact contact { get; set; }
        public virtual worksheet worksheet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<License> Licenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<realization> realizations { get; set; }
    }
}

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
    
    public partial class worksheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public worksheet()
        {
            this.Companies = new HashSet<Company>();
        }
    
        public int ID_worksheet { get; set; }
        public int ID_fieldActivity { get; set; }
        public int ID_branch { get; set; }
        public int ID_ownership { get; set; }
        public string ware { get; set; }
    
        public virtual Branch Branch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }
        public virtual FieldActivity FieldActivity { get; set; }
        public virtual Ownersheep Ownersheep { get; set; }
    }
}

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
    
public partial class PersonStatu
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PersonStatu()
    {

        this.contacts = new HashSet<contact>();

    }


    public int ID_PersonStatus { get; set; }

    public Nullable<int> ID_PersonPost { get; set; }

    public Nullable<int> ID_IndividualOrEntry { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<contact> contacts { get; set; }

    public virtual IndividualOrEntry IndividualOrEntry { get; set; }

    public virtual PersonPost PersonPost { get; set; }

}

}


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
    
public partial class FieldActivity
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public FieldActivity()
    {

        this.innovationWorksheets = new HashSet<innovationWorksheet>();

        this.worksheets = new HashSet<worksheet>();

    }


    public int ID_fieldActivity { get; set; }

    public string fieldActivity1 { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<innovationWorksheet> innovationWorksheets { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<worksheet> worksheets { get; set; }

}

}


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
    
public partial class balanceInf
{

    public int ID_company { get; set; }

    public int ID_balance { get; set; }

    public decimal activ { get; set; }

    public decimal passiv { get; set; }



    public virtual Company Company { get; set; }

}

}

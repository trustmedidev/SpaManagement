//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmaptax
    {
        public int MapTaxId { get; set; }
        public Nullable<int> FK_TaxId { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> FK_BranchID { get; set; }
    
        public virtual tblbranch tblbranch { get; set; }
        public virtual tbltaxmaster tbltaxmaster { get; set; }
    }
}

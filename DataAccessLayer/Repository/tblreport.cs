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
    
    public partial class tblreport
    {
        public int ReportId { get; set; }
        public int ClientId { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string ReportPath { get; set; }
        public string ClientName { get; set; }
        public string UserName { get; set; }
        public string Passwords { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Fk_BranchID { get; set; }
    
        public virtual tblbranch tblbranch { get; set; }
    }
}

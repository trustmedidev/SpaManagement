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
    
    public partial class tblmoduleright
    {
        public int UserCd { get; set; }
        public int ModuleCd { get; set; }
        public int BranchCd { get; set; }
        public Nullable<bool> AllowYN { get; set; }
        public Nullable<bool> addRight { get; set; }
        public Nullable<bool> editRight { get; set; }
        public Nullable<bool> delRight { get; set; }
        public Nullable<bool> printRight { get; set; }
    }
}
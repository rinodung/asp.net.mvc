//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_HOINGHI_ChiPhi_Chitiet
    {
        public int Id { get; set; }
        public Nullable<int> ChiphiId { get; set; }
        public string Dichvu { get; set; }
        public Nullable<double> Soluong { get; set; }
        public Nullable<double> Dongia { get; set; }
        public Nullable<double> Thanhtien { get; set; }
    
        public virtual tbl_HOINGHI_ChiPhi tbl_HOINGHI_ChiPhi { get; set; }
    }
}
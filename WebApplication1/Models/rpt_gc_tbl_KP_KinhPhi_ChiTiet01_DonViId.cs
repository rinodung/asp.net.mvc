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
    
    public partial class rpt_gc_tbl_KP_KinhPhi_ChiTiet01_DonViId
    {
        public int Id { get; set; }
        public Nullable<int> KinhPhiId { get; set; }
        public Nullable<int> DonViId { get; set; }
        public Nullable<int> DonViCTId { get; set; }
        public Nullable<int> DeTaiId { get; set; }
        public Nullable<int> DeTaiCTId { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string GhiChu { get; set; }
        public string tbl_KP_KinhPhi_KinhPhiId_Name { get; set; }
        public string tbl_KP_DonVi_DonViId_Name { get; set; }
    }
}
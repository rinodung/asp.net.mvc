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
    
    public partial class tbl_PTN_PLAN_DeXuatCapTrangThietBi
    {
        public int Id { get; set; }
        public Nullable<int> KeHoachId { get; set; }
        public Nullable<int> TrangThietBiId { get; set; }
        public Nullable<double> KinhPhi { get; set; }
        public string GhiChu { get; set; }
    
        public virtual tbl_PTN_INFO_TrangThietBi tbl_PTN_INFO_TrangThietBi { get; set; }
        public virtual tbl_PTN_PLAN_LapKeHoachHoatDong tbl_PTN_PLAN_LapKeHoachHoatDong { get; set; }
    }
}
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
    
    public partial class tbl_PTN_PLAN_TuyenDung
    {
        public int Id { get; set; }
        public Nullable<int> KeHoachId { get; set; }
        public string NamDKTD { get; set; }
        public Nullable<int> HocViId { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string GhiChu { get; set; }
        public Nullable<double> KinhPhiHoTro { get; set; }
        public string TS { get; set; }
        public string ThS { get; set; }
        public string DH_CD { get; set; }
        public string Khac { get; set; }
        public Nullable<int> PhongTNId { get; set; }
    
        public virtual tbl_DM_HocVi tbl_DM_HocVi { get; set; }
        public virtual tbl_PTN_INFO_ThongTinChung tbl_PTN_INFO_ThongTinChung { get; set; }
        public virtual tbl_PTN_PLAN_LapKeHoachHoatDong tbl_PTN_PLAN_LapKeHoachHoatDong { get; set; }
    }
}

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
    
    public partial class tbl_TH_CongVanDen
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> NgayNhan { get; set; }
        public string NguoiKy { get; set; }
        public string TenCongVan { get; set; }
        public string SoCongVan { get; set; }
        public string TrichYeu { get; set; }
        public string DienGiai { get; set; }
        public Nullable<System.DateTime> NgayPhatHanh { get; set; }
        public Nullable<int> NoiPhatHanhId { get; set; }
        public Nullable<int> CoQuanNhanId { get; set; }
        public string HinhAnhFile { get; set; }
        public string NoiLuuBanGoc { get; set; }
        public string GhiChu { get; set; }
    
        public virtual tbl_TH_DM_CoQuanNhan tbl_TH_DM_CoQuanNhan { get; set; }
        public virtual tbl_TH_DM_NoiPhatHanh tbl_TH_DM_NoiPhatHanh { get; set; }
    }
}

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
    
    public partial class rpt_gc_tbl_TH_CongVanDen02_CoQuanNhanId
    {
        public int Id { get; set; }
        public System.DateTime NgayNhan { get; set; }
        public string NguoiKy { get; set; }
        public string TenCongVan { get; set; }
        public string TrichYeu { get; set; }
        public string SoCongVan { get; set; }
        public Nullable<int> LoaiCongVanId { get; set; }
        public System.DateTime NgayPhatHanh { get; set; }
        public Nullable<int> NoiPhatHanhId { get; set; }
        public Nullable<int> CoQuanNhanId { get; set; }
        public string FileDinhKem { get; set; }
        public string NoiLuuBanGoc { get; set; }
        public string ToanVan { get; set; }
        public string tbl_TH_DM_LoaiCongVan_LoaiCongVanId_Ten { get; set; }
        public string tbl_TH_DM_NoiPhatHanh_NoiPhatHanhId_Ten { get; set; }
        public string tbl_TH_DM_CoQuanNhan_CoQuanNhanId_Ten { get; set; }
    }
}
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
    
    public partial class rpt_gc_tbl_NEWS_ThongBao02_NguoiDuaTinId
    {
        public int Id { get; set; }
        public Nullable<int> PageId { get; set; }
        public Nullable<int> LoaiThongBao { get; set; }
        public string Ten { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> NguoiDuaTinId { get; set; }
        public Nullable<System.DateTime> NgayDuaTin { get; set; }
        public string HinhAnh { get; set; }
        public string tbl_NEWS_DM_Page_PageId_Name { get; set; }
        public string tbl_NEWS_LoaiThongBao_LoaiThongBao_Name { get; set; }
        public string tbl_BANKHCN_DanhSachCanBo_NguoiDuaTinId_Name { get; set; }
    }
}

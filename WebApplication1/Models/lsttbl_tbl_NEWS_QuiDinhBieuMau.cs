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
    
    public partial class lsttbl_tbl_NEWS_QuiDinhBieuMau
    {
        public int Id { get; set; }
        public Nullable<int> PageId { get; set; }
        public string tbl_NEWS_DM_Page_PageId_Name { get; set; }
        public Nullable<int> LoaiQuiDinhId { get; set; }
        public string tbl_NEWS_LoaiQuiDinh_LoaiQuiDinhId_Name { get; set; }
        public string Ten { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> NguoiDuaTinId { get; set; }
        public string tbl_BANKHCN_DanhSachCanBo_NguoiDuaTinId_Name { get; set; }
        public Nullable<System.DateTime> NgayDuaTin { get; set; }
        public Nullable<System.DateTime> NgayBanHanh { get; set; }
        public string HinhAnh { get; set; }
    }
}

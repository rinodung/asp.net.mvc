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
    
    public partial class lsttbl_tbl_DHQG_HoatDongTieuBieu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TomTat { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> NguoiDangTin { get; set; }
        public string tbl_HSCB_LyLichCanBo_NguoiDangTin_Ten { get; set; }
        public Nullable<System.DateTime> NgayDangTin { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> BanQuanLyId { get; set; }
        public string tbl_BanQuanLy_BanQuanLyId_Name { get; set; }
    }
}

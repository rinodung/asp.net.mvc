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
    
    public partial class lst_gc_tbl_HSCB_XuatBanSach02_SanPham
    {
        public int Id { get; set; }
        public int CanBoId { get; set; }
        public string TenSach { get; set; }
        public Nullable<int> NhaXuatBan { get; set; }
        public Nullable<int> NamXuatBan { get; set; }
        public Nullable<bool> TacGiaChinh { get; set; }
        public Nullable<bool> DongTacGia { get; set; }
        public string ButDanh { get; set; }
        public Nullable<int> SanPham { get; set; }
        public string tbl_HSCB_LyLichCanBo_CanBoId_Ten { get; set; }
        public string tbl_DM_NhaXuatBan_NhaXuatBan_Ten { get; set; }
        public string tbl_DA_ThongTinChung_SanPham_Ten { get; set; }
    }
}
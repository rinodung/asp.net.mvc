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
    
    public partial class rpt_gc_tbl_PTN_PhuLuc_400_MaThietBiId
    {
        public int Id { get; set; }
        public Nullable<int> MaThietBiId { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string NguoiNhan { get; set; }
        public string NguoiGiao { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public int tbl_PTN_INFO_TrangThietBi_MaThietBiId_Id { get; set; }
    }
}

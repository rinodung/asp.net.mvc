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
    
    public partial class rpt_gc_tbl_PTN_WORKING_DaoTaoNhanLuc02_HocViId
    {
        public int Id { get; set; }
        public Nullable<int> PhongTNId { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<int> MaNguonNhanLucId { get; set; }
        public Nullable<int> HocVienId { get; set; }
        public Nullable<System.DateTime> NgayNhapHoc { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<int> HocViId { get; set; }
        public string GhiChu { get; set; }
        public string tbl_PTN_INFO_ThongTinChung_PhongTNId_Name { get; set; }
        public string tbl_DM_DaoTaoNhanLuc_MaNguonNhanLucId_Name { get; set; }
        public string tbl_DM_HocVi_HocViId_Ten { get; set; }
    }
}

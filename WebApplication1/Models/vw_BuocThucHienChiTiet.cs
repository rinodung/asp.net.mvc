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
    
    public partial class vw_BuocThucHienChiTiet
    {
        public int Id { get; set; }
        public Nullable<int> MaLoaiDuAnId { get; set; }
        public string tbl_DM_LoaiDuAn_MaLoaiDuAnId_Ten { get; set; }
        public Nullable<int> MaBuocThucHien { get; set; }
        public string tbl_DM_BuocThucHien_ChiTiet_MaBuocThucHien_Ten { get; set; }
        public string ThuocBuoc { get; set; }
    }
}
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
    
    public partial class lst_gc_tbl_PTN_INFO_PhanBoNhanLuc03_HocVi
    {
        public int Id { get; set; }
        public Nullable<int> PTNId { get; set; }
        public Nullable<int> CanBoId { get; set; }
        public Nullable<int> ChuyenNganhId { get; set; }
        public Nullable<int> HocVi { get; set; }
        public Nullable<int> ChucVuId { get; set; }
        public Nullable<bool> CanBoCoHuu { get; set; }
        public string tbl_PTN_INFO_ThongTinChung_PTNId_Name { get; set; }
        public string tbl_HSCB_LyLichCanBo_CanBoId_Ten { get; set; }
        public string tbl_DM_ChuyenNganh_ChuyenNganhId_Ten { get; set; }
        public string tbl_DM_HocVi_HocVi_Ten { get; set; }
    }
}

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
    
    public partial class lst_gc_tbl_PTN_TrangThietBi02_QuocGiaId
    {
        public int Id { get; set; }
        public int PhongTNId { get; set; }
        public int ThietBiId { get; set; }
        public Nullable<int> QuocGiaId { get; set; }
        public string HangSanXuat { get; set; }
        public string ThongSoKyThuat { get; set; }
        public Nullable<System.DateTime> ThoiGianMua { get; set; }
        public Nullable<System.DateTime> ThoiGianDuaVaoSuDung { get; set; }
        public string Nguoi_BoPhanSuDung { get; set; }
        public Nullable<double> TriGia { get; set; }
        public string CongDung { get; set; }
        public Nullable<int> TanSuat { get; set; }
        public string tbl_PTN_ThongTinChung_PhongTNId_Name { get; set; }
        public string tbl_DM_ThietBi_ThietBiId_Ten { get; set; }
        public string tbl_DM_QuocGia_QuocGiaId_Ten { get; set; }
    }
}

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
    
    public partial class rpt_gc_tbl_HOINGHI_DS_HN_HT01_DVThucHienId
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> LoaiHoiNghiId { get; set; }
        public Nullable<int> DVThucHienId { get; set; }
        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNgay { get; set; }
        public Nullable<int> DiaDiemId { get; set; }
        public Nullable<int> SoLuongKhachMoi { get; set; }
        public Nullable<double> TongKinhPhi { get; set; }
        public string GhiChu { get; set; }
        public string tbl_HOINGHI_Type_LoaiHoiNghiId_Name { get; set; }
        public string tbl_DM_TruongVien_DVThucHienId_Ten { get; set; }
    }
}

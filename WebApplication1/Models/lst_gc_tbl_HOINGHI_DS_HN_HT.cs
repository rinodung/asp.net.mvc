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
    
    public partial class lst_gc_tbl_HOINGHI_DS_HN_HT
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
    }
}

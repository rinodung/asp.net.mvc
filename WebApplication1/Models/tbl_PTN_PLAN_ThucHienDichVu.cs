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
    
    public partial class tbl_PTN_PLAN_ThucHienDichVu
    {
        public int Id { get; set; }
        public Nullable<int> KeHoachId { get; set; }
        public Nullable<int> DichVuId { get; set; }
        public string SoLuong { get; set; }
        public string DoanhThu { get; set; }
        public string TenDichVu { get; set; }
        public Nullable<int> PhongTNId { get; set; }
        public string DonGia { get; set; }
    
        public virtual tbl_PTN_PLAN_LapKeHoachHoatDong tbl_PTN_PLAN_LapKeHoachHoatDong { get; set; }
    }
}
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
    
    public partial class lsttbl_tbl_PTN_WORKING_DoanhThuDichVu
    {
        public int Id { get; set; }
        public Nullable<int> PTNId { get; set; }
        public string tbl_PTN_INFO_ThongTinChung_PTNId_Name { get; set; }
        public Nullable<int> DichVuId { get; set; }
        public string tbl_PTN_DM_DichVu_DichVuId_Ten { get; set; }
        public Nullable<System.DateTime> NgayTH { get; set; }
        public double SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    }
}

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
    
    public partial class lsttbl_tbl_GIAITHUONG_SV
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> GiaithuongTypeId { get; set; }
        public string tbl_GIAITHUONG_SV_Type_GiaithuongTypeId_Name { get; set; }
        public Nullable<int> DonViToChucId { get; set; }
        public string tbl_GIAITHUONG_DonViToChuc_DonViToChucId_Name { get; set; }
        public string Noidung { get; set; }
        public string Chitiet { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> Ngaybatdau { get; set; }
        public Nullable<System.DateTime> Ngayketthuc { get; set; }
        public string Ketqua { get; set; }
    }
}

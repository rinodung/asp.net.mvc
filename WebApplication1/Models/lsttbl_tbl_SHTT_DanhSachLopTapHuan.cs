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
    
    public partial class lsttbl_tbl_SHTT_DanhSachLopTapHuan
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> GioiTinhId { get; set; }
        public string tbl_DM_GioiTinh_GioiTinhId_Name { get; set; }
        public Nullable<System.DateTime> NamSinh { get; set; }
        public string NoiSinh { get; set; }
        public string CoQuan { get; set; }
        public string ChucDanh { get; set; }
        public Nullable<int> LopTapHuanId { get; set; }
        public string tbl_SHTT_LopTapHuan_LopTapHuanId_Name { get; set; }
        public Nullable<bool> CapChungChi { get; set; }
    }
}

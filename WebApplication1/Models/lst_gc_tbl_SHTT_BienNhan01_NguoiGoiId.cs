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
    
    public partial class lst_gc_tbl_SHTT_BienNhan01_NguoiGoiId
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Tomtat { get; set; }
        public string NoidungBienNhan { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string SoBienNhan { get; set; }
        public Nullable<int> NguoiNhanId { get; set; }
        public Nullable<int> NguoiGoiId { get; set; }
        public string tbl_HSCB_LyLichCanBo_NguoiNhanId_HoTen { get; set; }
        public string tbl_HSCB_LyLichCanBo_NguoiGoiId_HoTen { get; set; }
    }
}

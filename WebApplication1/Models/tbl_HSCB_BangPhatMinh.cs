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
    
    public partial class tbl_HSCB_BangPhatMinh
    {
        public int Id { get; set; }
        public Nullable<int> MaCanBoId { get; set; }
        public string TenBang { get; set; }
        public string SoHieu { get; set; }
        public Nullable<int> NamCap { get; set; }
        public string NoiCap { get; set; }
        public Nullable<bool> LaTacGia { get; set; }
        public Nullable<bool> ThamGia { get; set; }
        public string SanPham { get; set; }
    
        public virtual tbl_HSCB_LyLichCanBo tbl_HSCB_LyLichCanBo { get; set; }
    }
}

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
    
    public partial class tbl_DA_BUOCTH_KinhPhiDot2
    {
        public int Id { get; set; }
        public Nullable<int> QuaTrinhId { get; set; }
        public string SoQDCap { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string Ten { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string HinhAnh_File { get; set; }
    
        public virtual tbl_DA_QuaTrinhThucHien tbl_DA_QuaTrinhThucHien { get; set; }
    }
}

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
    
    public partial class tbl_DA_SanPhamDeTai
    {
        public int Id { get; set; }
        public Nullable<int> DuAnId { get; set; }
        public Nullable<double> Dang1 { get; set; }
        public Nullable<double> Dang2 { get; set; }
        public Nullable<double> Dang3 { get; set; }
        public Nullable<double> Dang4 { get; set; }
        public Nullable<double> Dang5 { get; set; }
        public Nullable<bool> LoaiDeTaiOrDuAn { get; set; }
        public Nullable<double> TS { get; set; }
        public Nullable<double> ThS { get; set; }
        public Nullable<double> DH { get; set; }
        public Nullable<double> Khac { get; set; }
        public Nullable<double> BaiBaoTN { get; set; }
        public Nullable<double> BaiBaoQT { get; set; }
        public Nullable<double> KyYeuTN { get; set; }
        public Nullable<double> KyYeuQT { get; set; }
        public Nullable<int> Nam { get; set; }
    
        public virtual tbl_DA_ThongTinChung tbl_DA_ThongTinChung { get; set; }
    }
}

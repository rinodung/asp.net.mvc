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
    
    public partial class tbl_HSCB_BaiBao_KyYeu
    {
        public int Id { get; set; }
        public Nullable<int> Yearth { get; set; }
        public string HoiNghi { get; set; }
        public string TenBai { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public string SanPham { get; set; }
        public string ThơiGian { get; set; }
        public string NoiToChuc { get; set; }
        public string ISBN { get; set; }
        public Nullable<bool> HoiNghiTrongNuoc { get; set; }
        public Nullable<bool> HoiNghiQuocTe { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public string NhomTacGia { get; set; }
    
        public virtual tbl_BB_Programe tbl_BB_Programe { get; set; }
        public virtual tbl_HSCB_LyLichCanBo tbl_HSCB_LyLichCanBo { get; set; }
    }
}

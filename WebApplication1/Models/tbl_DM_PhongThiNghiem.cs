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
    
    public partial class tbl_DM_PhongThiNghiem
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public Nullable<int> MaKhoaId { get; set; }
    
        public virtual tbl_DM_KhoaPhongBan tbl_DM_KhoaPhongBan { get; set; }
    }
}

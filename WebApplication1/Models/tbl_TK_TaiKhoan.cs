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
    
    public partial class tbl_TK_TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_TK_TaiKhoan()
        {
            this.tbl_TK_TaiKhoan_NhomQuyen = new HashSet<tbl_TK_TaiKhoan_NhomQuyen>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> MaNhomQuyenId { get; set; }
        public int MaCanBoId { get; set; }
        public string CheckNo { get; set; }
        public Nullable<int> QuyenPC { get; set; }
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
    
        public virtual tbl_TK_NhomQuyen tbl_TK_NhomQuyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TK_TaiKhoan_NhomQuyen> tbl_TK_TaiKhoan_NhomQuyen { get; set; }
    }
}
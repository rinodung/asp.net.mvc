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
    
    public partial class tbl_NEWS_ThongBao_ChiTiet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NEWS_ThongBao_ChiTiet()
        {
            this.tbl_NEWS_ThongBao_ChiTiet2 = new HashSet<tbl_NEWS_ThongBao_ChiTiet2>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ThongBaoId { get; set; }
        public string Ten { get; set; }
        public string NoiDung { get; set; }
        public string HinhAnh_File { get; set; }
    
        public virtual tbl_NEWS_ThongBao tbl_NEWS_ThongBao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_ThongBao_ChiTiet2> tbl_NEWS_ThongBao_ChiTiet2 { get; set; }
    }
}

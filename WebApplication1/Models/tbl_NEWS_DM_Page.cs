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
    
    public partial class tbl_NEWS_DM_Page
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NEWS_DM_Page()
        {
            this.tbl_NEWS_HinhAnhHoatDong = new HashSet<tbl_NEWS_HinhAnhHoatDong>();
            this.tbl_NEWS_LoiGioiThieu = new HashSet<tbl_NEWS_LoiGioiThieu>();
            this.tbl_NEWS_QuiDinhBieuMau = new HashSet<tbl_NEWS_QuiDinhBieuMau>();
            this.tbl_NEWS_ThongBao = new HashSet<tbl_NEWS_ThongBao>();
            this.tbl_NEWS_Tintuc = new HashSet<tbl_NEWS_Tintuc>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Priority { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_HinhAnhHoatDong> tbl_NEWS_HinhAnhHoatDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_LoiGioiThieu> tbl_NEWS_LoiGioiThieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_QuiDinhBieuMau> tbl_NEWS_QuiDinhBieuMau { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_ThongBao> tbl_NEWS_ThongBao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_Tintuc> tbl_NEWS_Tintuc { get; set; }
    }
}

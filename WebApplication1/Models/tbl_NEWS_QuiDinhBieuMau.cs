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
    
    public partial class tbl_NEWS_QuiDinhBieuMau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NEWS_QuiDinhBieuMau()
        {
            this.tbl_NEWS_QuiDinhBieuMau_ChiTiet = new HashSet<tbl_NEWS_QuiDinhBieuMau_ChiTiet>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PageId { get; set; }
        public Nullable<int> LoaiQuiDinhId { get; set; }
        public string Ten { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> NguoiDuaTinId { get; set; }
        public Nullable<System.DateTime> NgayDuaTin { get; set; }
        public Nullable<System.DateTime> NgayBanHanh { get; set; }
        public string HinhAnh { get; set; }
    
        public virtual tbl_BANKHCN_DanhSachCanBo tbl_BANKHCN_DanhSachCanBo { get; set; }
        public virtual tbl_NEWS_DM_Page tbl_NEWS_DM_Page { get; set; }
        public virtual tbl_NEWS_LoaiQuiDinh tbl_NEWS_LoaiQuiDinh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_QuiDinhBieuMau_ChiTiet> tbl_NEWS_QuiDinhBieuMau_ChiTiet { get; set; }
    }
}

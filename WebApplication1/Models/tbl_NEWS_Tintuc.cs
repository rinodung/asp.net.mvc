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
    
    public partial class tbl_NEWS_Tintuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NEWS_Tintuc()
        {
            this.tbl_NEWS_TinTuc_ChiTiet = new HashSet<tbl_NEWS_TinTuc_ChiTiet>();
        }
    
        public int Id { get; set; }
        public Nullable<int> LoaiTinId { get; set; }
        public Nullable<int> PageId { get; set; }
        public string Ten { get; set; }
        public string MoTaNgan { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> NgayDuaTin { get; set; }
        public Nullable<int> NguoiDuaTinId { get; set; }
        public string NguonTin { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<bool> IsHide { get; set; }
    
        public virtual tbl_BANKHCN_DanhSachCanBo tbl_BANKHCN_DanhSachCanBo { get; set; }
        public virtual tbl_NEWS_DM_Page tbl_NEWS_DM_Page { get; set; }
        public virtual tbl_NEWS_LoaiTin tbl_NEWS_LoaiTin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NEWS_TinTuc_ChiTiet> tbl_NEWS_TinTuc_ChiTiet { get; set; }
    }
}
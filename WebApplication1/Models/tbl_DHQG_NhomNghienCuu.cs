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
    
    public partial class tbl_DHQG_NhomNghienCuu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DHQG_NhomNghienCuu()
        {
            this.tbl_DHQG_DSThanhVien = new HashSet<tbl_DHQG_DSThanhVien>();
        }
    
        public int Id { get; set; }
        public string TenNhom { get; set; }
        public Nullable<int> TruongNhom { get; set; }
        public string LanhVucChinh { get; set; }
        public string GioiThieu { get; set; }
        public Nullable<int> CTNCId { get; set; }
        public Nullable<int> DonViId { get; set; }
        public Nullable<int> PTNId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DHQG_DSThanhVien> tbl_DHQG_DSThanhVien { get; set; }
        public virtual tbl_HSCB_LyLichCanBo tbl_HSCB_LyLichCanBo { get; set; }
        public virtual tbl_PTN_INFO_ThongTinChung tbl_PTN_INFO_ThongTinChung { get; set; }
    }
}
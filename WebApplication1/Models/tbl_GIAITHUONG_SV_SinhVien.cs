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
    
    public partial class tbl_GIAITHUONG_SV_SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_GIAITHUONG_SV_SinhVien()
        {
            this.tbl_TH_DM_PhanBien = new HashSet<tbl_TH_DM_PhanBien>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public Nullable<int> TruongVienId { get; set; }
        public Nullable<int> GiaiThuongId { get; set; }
        public Nullable<int> CongTrinhId { get; set; }
        public Nullable<int> NhomNganhId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> NamSinh { get; set; }
        public Nullable<int> GioiTinhId { get; set; }
        public string DanToc { get; set; }
        public string NamDaoTao { get; set; }
        public Nullable<int> NganhId { get; set; }
        public string Mobile { get; set; }
        public string DTNha { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> CanBoId { get; set; }
    
        public virtual tbl_HSCB_LyLichCanBo tbl_HSCB_LyLichCanBo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TH_DM_PhanBien> tbl_TH_DM_PhanBien { get; set; }
    }
}
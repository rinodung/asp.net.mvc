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
    
    public partial class tbl_SHTT_VanBangBaoHo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SHTT_VanBangBaoHo()
        {
            this.tbl_SHTT_ChuyenGiaoQuyen = new HashSet<tbl_SHTT_ChuyenGiaoQuyen>();
            this.tbl_SHTT_KieuDangCongNghiep = new HashSet<tbl_SHTT_KieuDangCongNghiep>();
            this.tbl_SHTT_NhanHieu = new HashSet<tbl_SHTT_NhanHieu>();
            this.tbl_SHTT_SangChe = new HashSet<tbl_SHTT_SangChe>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> LoaiVanBangId { get; set; }
        public string SoBang { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string SoDon { get; set; }
        public Nullable<System.DateTime> NgayNopDon { get; set; }
        public string NguoiNop { get; set; }
        public string DiaChi { get; set; }
        public string TacGia { get; set; }
        public string ChiSoIPC { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string TomTat { get; set; }
        public Nullable<int> DonViId { get; set; }
        public Nullable<int> NganhId { get; set; }
        public string HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SHTT_ChuyenGiaoQuyen> tbl_SHTT_ChuyenGiaoQuyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SHTT_KieuDangCongNghiep> tbl_SHTT_KieuDangCongNghiep { get; set; }
        public virtual tbl_SHTT_LoaiVanBang tbl_SHTT_LoaiVanBang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SHTT_NhanHieu> tbl_SHTT_NhanHieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SHTT_SangChe> tbl_SHTT_SangChe { get; set; }
    }
}

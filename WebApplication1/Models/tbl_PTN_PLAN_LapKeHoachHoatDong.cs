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
    
    public partial class tbl_PTN_PLAN_LapKeHoachHoatDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PTN_PLAN_LapKeHoachHoatDong()
        {
            this.tbl_PTN_PLAN_DaoTaoNhanLuc = new HashSet<tbl_PTN_PLAN_DaoTaoNhanLuc>();
            this.tbl_PTN_PLAN_DeXuatCapTrangThietBi = new HashSet<tbl_PTN_PLAN_DeXuatCapTrangThietBi>();
            this.tbl_PTN_PLAN_DeXuatKienNghi = new HashSet<tbl_PTN_PLAN_DeXuatKienNghi>();
            this.tbl_PTN_PLAN_ThucHienDichVu = new HashSet<tbl_PTN_PLAN_ThucHienDichVu>();
            this.tbl_PTN_PLAN_ThucHienDeTai = new HashSet<tbl_PTN_PLAN_ThucHienDeTai>();
            this.tbl_PTN_PLAN_TuyenDung = new HashSet<tbl_PTN_PLAN_TuyenDung>();
        }
    
        public int Id { get; set; }
        public int PTNId { get; set; }
        public string Ten { get; set; }
        public Nullable<int> NamBatDau { get; set; }
        public Nullable<int> NamKetThuc { get; set; }
        public string GhiChu { get; set; }
    
        public virtual tbl_PTN_INFO_ThongTinChung tbl_PTN_INFO_ThongTinChung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PTN_PLAN_DaoTaoNhanLuc> tbl_PTN_PLAN_DaoTaoNhanLuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PTN_PLAN_DeXuatCapTrangThietBi> tbl_PTN_PLAN_DeXuatCapTrangThietBi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PTN_PLAN_DeXuatKienNghi> tbl_PTN_PLAN_DeXuatKienNghi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PTN_PLAN_ThucHienDichVu> tbl_PTN_PLAN_ThucHienDichVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PTN_PLAN_ThucHienDeTai> tbl_PTN_PLAN_ThucHienDeTai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PTN_PLAN_TuyenDung> tbl_PTN_PLAN_TuyenDung { get; set; }
    }
}

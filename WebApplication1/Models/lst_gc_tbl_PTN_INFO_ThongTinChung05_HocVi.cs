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
    
    public partial class lst_gc_tbl_PTN_INFO_ThongTinChung05_HocVi
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TenVietTat { get; set; }
        public string TenGiaoDich { get; set; }
        public string TenGiaoDichVT { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public Nullable<int> PhanLoaiId { get; set; }
        public Nullable<int> PhanCapId { get; set; }
        public Nullable<int> TruongPhongId { get; set; }
        public Nullable<int> TruongVienId { get; set; }
        public string LanhVucHoatDong { get; set; }
        public string ChucNangNhiemVu { get; set; }
        public string DoiTuongPhucVu { get; set; }
        public string DienTich { get; set; }
        public string NameNonUnicode { get; set; }
        public string TransNameNonUnicode { get; set; }
        public string tbl_PTN_DM_PhanLoaiPhongThiNghiem_PhanLoaiId_Ten { get; set; }
        public string tbl_PTN_DM_PhanCap_PhanCapId_Ten { get; set; }
        public string tbl_HSCB_LyLichCanBo_TruongPhongId_Ten { get; set; }
        public Nullable<int> tbl_HSCB_LyLichCanBo_TruongPhongId_HocVi { get; set; }
        public Nullable<int> tbl_HSCB_LyLichCanBo_TruongPhongId_HocHam { get; set; }
        public string tbl_HSCB_LyLichCanBo_TruongPhongId_DienThoaiCQ { get; set; }
        public string tbl_HSCB_LyLichCanBo_TruongPhongId_DienThoaiCN { get; set; }
        public string tbl_HSCB_LyLichCanBo_TruongPhongId_EmailCN { get; set; }
        public string tbl_DM_TruongVien_TruongVienId_Ten { get; set; }
        public string tbl_DM_TruongVien_TruongVienId_DiaChi { get; set; }
        public string tbl_DM_TruongVien_TruongVienId_DienThoai { get; set; }
        public string tbl_DM_TruongVien_TruongVienId_Fax { get; set; }
        public string ChucNangNghienCuuChinh { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> ParentCode { get; set; }
        public string tbl_DM_HocVi_Code { get; set; }
    }
}

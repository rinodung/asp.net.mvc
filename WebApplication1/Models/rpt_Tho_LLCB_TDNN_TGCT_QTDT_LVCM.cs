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
    
    public partial class rpt_Tho_LLCB_TDNN_TGCT_QTDT_LVCM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Ten { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<int> MaTruongId { get; set; }
        public Nullable<int> MaKhoaId { get; set; }
        public Nullable<int> MaBoMonId { get; set; }
        public Nullable<int> PhongThiNghiemId { get; set; }
        public Nullable<int> ChucVu { get; set; }
        public Nullable<int> HocVi { get; set; }
        public Nullable<int> NamDatHocVi { get; set; }
        public Nullable<int> HocHam { get; set; }
        public Nullable<int> NamDatHocHam { get; set; }
        public string DiaChiCQ { get; set; }
        public string DienThoaiCQ { get; set; }
        public string FaxCQ { get; set; }
        public string EmailCQ { get; set; }
        public string DiaChiCN { get; set; }
        public string DienThoaiCN { get; set; }
        public string FaxCN { get; set; }
        public string EmailCN { get; set; }
        public string WebSiteCN { get; set; }
        public string HinhAnh { get; set; }
        public string tbl_BB_Science_Id_Name { get; set; }
        public string tbl_DM_TruongVien_MaTruongId_Ten { get; set; }
        public string tbl_BB_Unit_MaTruongId_Name { get; set; }
        public string tbl_DM_KhoaPhongBan_MaKhoaId_Ten { get; set; }
        public string tbl_DM_BoMon_MaBoMonId_Ten { get; set; }
        public string tbl_PTN_INFO_ThongTinChung_PhongThiNghiemId_Name { get; set; }
        public string tbl_DM_ChucVu_ChucVu_Ten { get; set; }
        public string tbl_DM_HocVi_HocVi_Ten { get; set; }
        public string tbl_DM_HocHam_HocHam_Ten { get; set; }
        public Nullable<int> NgoaiNguId { get; set; }
        public Nullable<int> Nghe { get; set; }
        public Nullable<int> Noi { get; set; }
        public Nullable<int> Viet { get; set; }
        public Nullable<int> Doc { get; set; }
        public string tbl_HSCB_LyLichCanBo_MaCanBoId_Ten { get; set; }
        public string tbl_DM_NgoaiNgu_NgoaiNguId_Ten { get; set; }
        public string tbl_DM_CapDo_Nghe_Ten { get; set; }
        public string tbl_DM_CapDo_Noi_Ten { get; set; }
        public string tbl_DM_CapDo_Viet_Ten { get; set; }
        public string tbl_DM_CapDo_Doc_Ten { get; set; }
        public string ThoiGianBanDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string NoiCOngTac { get; set; }
        public string ChucVu_CongTac { get; set; }
        public Nullable<int> BacDaoTaoId { get; set; }
        public string ThoiGian { get; set; }
        public string NoiDaoTao { get; set; }
        public string ChuyenNganh { get; set; }
        public string TenLuanAn { get; set; }
        public string tbl_DM_BacDaoTao_BacDaoTaoId_Ten { get; set; }
        public string LinhVuc { get; set; }
        public string Expr1 { get; set; }
        public string ChuyenMon { get; set; }
    }
}

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
    
    public partial class tbl_BB_Science_Magazine2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_BB_Science_Magazine2()
        {
            this.tbl_BB_Science_Magazine_GroupAuthor = new HashSet<tbl_BB_Science_Magazine_GroupAuthor>();
            this.tbl_BB_Science_Magazine2_KhenThuong = new HashSet<tbl_BB_Science_Magazine2_KhenThuong>();
        }
    
        public int Id { get; set; }
        public string PaperTitle { get; set; }
        public Nullable<int> Yearth { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> ProgrameId { get; set; }
        public string Magazine { get; set; }
        public Nullable<int> MagazineId { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public string MagazineDetail { get; set; }
        public string Abstract { get; set; }
        public Nullable<int> TypeOfAuthor { get; set; }
        public string HinhAnh_File { get; set; }
        public Nullable<int> Months { get; set; }
        public string ProjectCode { get; set; }
        public string WebLink { get; set; }
        public string NhomTacGia { get; set; }
        public Nullable<int> LoaiTapChiId { get; set; }
        public Nullable<int> LinhVucId { get; set; }
        public Nullable<int> DeTaiId { get; set; }
        public string LinhVuc { get; set; }
        public Nullable<double> DiemIF { get; set; }
    
        public virtual tbl_BB_Magazine tbl_BB_Magazine { get; set; }
        public virtual tbl_BB_Programe tbl_BB_Programe { get; set; }
        public virtual tbl_BB_Science tbl_BB_Science { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BB_Science_Magazine_GroupAuthor> tbl_BB_Science_Magazine_GroupAuthor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BB_Science_Magazine2_KhenThuong> tbl_BB_Science_Magazine2_KhenThuong { get; set; }
        public virtual tbl_DM_LinhVuc tbl_DM_LinhVuc { get; set; }
        public virtual tbl_DM_LoaiTacGia tbl_DM_LoaiTacGia { get; set; }
        public virtual tbl_DM_LoaiTapChi tbl_DM_LoaiTapChi { get; set; }
        public virtual tbl_BB_Unit tbl_BB_Unit { get; set; }
    }
}
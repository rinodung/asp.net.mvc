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
    
    public partial class tbl_DM_BuocThucHien_ChiTiet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DM_BuocThucHien_ChiTiet()
        {
            this.tbl_DA_QuaTrinhThucHien = new HashSet<tbl_DA_QuaTrinhThucHien>();
            this.tbl_DA_QuiTrinhThucHien = new HashSet<tbl_DA_QuiTrinhThucHien>();
        }
    
        public int Id { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> BuocId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DA_QuaTrinhThucHien> tbl_DA_QuaTrinhThucHien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DA_QuiTrinhThucHien> tbl_DA_QuiTrinhThucHien { get; set; }
        public virtual tbl_DM_BuocThucHien tbl_DM_BuocThucHien { get; set; }
    }
}

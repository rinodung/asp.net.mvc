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
    
    public partial class tbl_DM_LoaiTacGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DM_LoaiTacGia()
        {
            this.tbl_BB_Science_Magazine2 = new HashSet<tbl_BB_Science_Magazine2>();
            this.tbl_HSCB_BaiBao = new HashSet<tbl_HSCB_BaiBao>();
        }
    
        public int Id { get; set; }
        public string Ten { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BB_Science_Magazine2> tbl_BB_Science_Magazine2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HSCB_BaiBao> tbl_HSCB_BaiBao { get; set; }
    }
}

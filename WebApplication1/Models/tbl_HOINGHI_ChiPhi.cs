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
    
    public partial class tbl_HOINGHI_ChiPhi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_HOINGHI_ChiPhi()
        {
            this.tbl_HOINGHI_ChiPhi_Chitiet = new HashSet<tbl_HOINGHI_ChiPhi_Chitiet>();
        }
    
        public int Id { get; set; }
        public Nullable<int> HoinghiId { get; set; }
        public string Noidungchi { get; set; }
        public string Thoigian { get; set; }
        public string Nguoichi { get; set; }
        public Nullable<double> Sotien { get; set; }
        public string Nguoinhantien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HOINGHI_ChiPhi_Chitiet> tbl_HOINGHI_ChiPhi_Chitiet { get; set; }
        public virtual tbl_HOINGHI_DS_HN_HT tbl_HOINGHI_DS_HN_HT { get; set; }
    }
}

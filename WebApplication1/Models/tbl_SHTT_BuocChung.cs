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
    
    public partial class tbl_SHTT_BuocChung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SHTT_BuocChung()
        {
            this.tbl_SHTT_Thongtinchung_BuocThucHien = new HashSet<tbl_SHTT_Thongtinchung_BuocThucHien>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> LoaiBuocId { get; set; }
    
        public virtual tbl_SHTT_BienNhan tbl_SHTT_BienNhan { get; set; }
        public virtual tbl_SHTT_DM_LoaiBuocThucHien tbl_SHTT_DM_LoaiBuocThucHien { get; set; }
        public virtual tbl_SHTT_Giaynhanxet tbl_SHTT_Giaynhanxet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SHTT_Thongtinchung_BuocThucHien> tbl_SHTT_Thongtinchung_BuocThucHien { get; set; }
        public virtual tbl_SHTT_ToTrinh tbl_SHTT_ToTrinh { get; set; }
    }
}

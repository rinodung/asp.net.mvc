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
    
    public partial class tbl_CONFIG_PTN_CHANGECODE
    {
        public int Id { get; set; }
        public Nullable<int> ConfigId { get; set; }
        public string Type { get; set; }
        public string IsPopUp { get; set; }
        public string InsertLine { get; set; }
        public string InsertStr { get; set; }
        public string ReplLine { get; set; }
        public string ReplStr { get; set; }
        public string DelLine { get; set; }
        public string DelStr { get; set; }
    }
}

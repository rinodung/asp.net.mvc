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
    
    public partial class rpt_gc_tbl_CONFIG_REPORT_MULTI
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string TableName { get; set; }
        public string ShowName { get; set; }
        public string TypeReport { get; set; }
        public string MainTable { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string CssHeader { get; set; }
        public string CssTD { get; set; }
        public string CssSumGobal { get; set; }
        public string CssSumGroupBy { get; set; }
        public string isBuild { get; set; }
        public Nullable<int> GroupBy { get; set; }
        public string GroupByArr { get; set; }
        public string GroupByArrContent { get; set; }
        public string SumCol { get; set; }
        public string FileName { get; set; }
        public string PathName { get; set; }
    }
}

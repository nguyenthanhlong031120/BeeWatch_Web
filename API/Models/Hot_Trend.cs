//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hot_Trend
    {
        public int id { get; set; }
        public string Image { get; set; }
        public Nullable<int> id_Accounts { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual Watches Watches { get; set; }
    }
}
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
    
    public partial class WatchesinCarts
    {
        public int id_Carts { get; set; }
        public int id_Watches { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual Carts Carts { get; set; }
        public virtual Watches Watches { get; set; }
    }
}

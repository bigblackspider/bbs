//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBS.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WebsiteItem
    {
        public int WebsiteItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public int WebsiteId { get; set; }
    
        public virtual Website Website { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace de1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Beverages = new HashSet<Beverage>();
        }
    
        public int CatID { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Beverage> Beverages { get; set; }
    }
}

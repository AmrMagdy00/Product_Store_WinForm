//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductStore_DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class UpdatedProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public bool IsNew { get; set; }
        public bool IsNotified { get; set; }
    
        public virtual Category Category { get; set; }
    }
}

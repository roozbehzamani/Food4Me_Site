//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainEnterpriseProject.Models.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_ShoppingCart
    {
        public int ID { get; set; }
        public int FoodCount { get; set; }
        public int FoodID { get; set; }
        public string UserEmail { get; set; }
    
        public virtual tab_products tab_products { get; set; }
        public virtual Tab_users Tab_users { get; set; }
    }
}

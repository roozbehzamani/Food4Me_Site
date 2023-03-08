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
    
    public partial class tab_products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tab_products()
        {
            this.Tbl_OrderFactorItem = new HashSet<Tbl_OrderFactorItem>();
            this.Tbl_ShoppingCart = new HashSet<Tbl_ShoppingCart>();
        }
    
        public int id { get; set; }
        public int cost { get; set; }
        public string name { get; set; }
        public string User_Email { get; set; }
        public int resID { get; set; }
        public int menuID { get; set; }
        public string Recipe { get; set; }
        public string foodImage { get; set; }
        public string CreateMaterial { get; set; }
        public string bakingTime { get; set; }
        public Nullable<int> FoodCount { get; set; }
        public Nullable<bool> OrderType { get; set; }
    
        public virtual Tab_users Tab_users { get; set; }
        public virtual Tbl_Menu Tbl_Menu { get; set; }
        public virtual Tbl_Restaurant Tbl_Restaurant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_OrderFactorItem> Tbl_OrderFactorItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ShoppingCart> Tbl_ShoppingCart { get; set; }
    }
}
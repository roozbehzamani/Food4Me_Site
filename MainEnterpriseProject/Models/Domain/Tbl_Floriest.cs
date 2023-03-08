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
    
    public partial class Tbl_Floriest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Floriest()
        {
            this.Tbl_FloristUserImage = new HashSet<Tbl_FloristUserImage>();
            this.Tbl_Flower = new HashSet<Tbl_Flower>();
            this.Tbl_FlowerOrder = new HashSet<Tbl_FlowerOrder>();
            this.Tbl_FlowerReservationFactor = new HashSet<Tbl_FlowerReservationFactor>();
        }
    
        public int ID { get; set; }
        public string FName { get; set; }
        public string FAddress { get; set; }
        public string FImage { get; set; }
        public string userEmail { get; set; }
        public string FLatLng { get; set; }
        public string FPhone { get; set; }
        public string FBusinessLicense { get; set; }
        public bool FEnable { get; set; }
        public double FPoints { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_FloristUserImage> Tbl_FloristUserImage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Flower> Tbl_Flower { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_FlowerOrder> Tbl_FlowerOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_FlowerReservationFactor> Tbl_FlowerReservationFactor { get; set; }
    }
}
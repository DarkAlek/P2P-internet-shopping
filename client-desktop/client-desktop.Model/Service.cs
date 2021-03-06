//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client_desktop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ServiceChoosed = new HashSet<ServiceChoosed>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int ProviderId { get; set; }
        public decimal Price { get; set; }
        public int RegionId { get; set; }
    
        public virtual Provider Provider { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceChoosed> ServiceChoosed { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inlam1.entityFramwork_gorom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategorier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategorier()
        {
            this.Recepts = new HashSet<Recept>();
        }
    
        public int KategoriID { get; set; }
        public string KategoriBeskrivning { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recept> Recepts { get; set; }
    }
}

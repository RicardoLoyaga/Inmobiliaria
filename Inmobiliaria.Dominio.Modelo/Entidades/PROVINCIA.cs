//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inmobiliaria.Dominio.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROVINCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVINCIA()
        {
            this.CANTON = new HashSet<CANTON>();
            this.PROPIEDAD = new HashSet<PROPIEDAD>();
        }
    
        public int IDPROVINCIA { get; set; }
        public string NOMBREPROVINCIA { get; set; }
        public int ESTADOPROVINCIA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANTON> CANTON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPIEDAD> PROPIEDAD { get; set; }
    }
}

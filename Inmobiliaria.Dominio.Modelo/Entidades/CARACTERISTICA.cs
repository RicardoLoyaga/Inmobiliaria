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
    
    public partial class CARACTERISTICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARACTERISTICA()
        {
            this.PROPIEDAD = new HashSet<PROPIEDAD>();
        }
    
        public int IDCARACTERISTICA { get; set; }
        public double METROSCUADRADOS { get; set; }
        public Nullable<int> PLANTAS { get; set; }
        public Nullable<decimal> BANIOS { get; set; }
        public Nullable<decimal> HABITACIONES { get; set; }
        public Nullable<int> PARQUEADEROS { get; set; }
        public string SERVICIOS { get; set; }
        public string OTROS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPIEDAD> PROPIEDAD { get; set; }
    }
}
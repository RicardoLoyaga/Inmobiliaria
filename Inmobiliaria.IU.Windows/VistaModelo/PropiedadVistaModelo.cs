using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.VistaModelo
{
    public class PropiedadVistaModelo
    {
        public int IdPropiedad { get; set; }
        public Nullable<int> IdCaracteristica { get; set; }
        public Nullable<int> IdProvincia { get; set; }
        public Nullable<int> IdTipoPropiedad { get; set; }
        public Nullable<int> IdPropietario { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public decimal Precio { get; set; }
        public System.DateTime FechaRegistroPropiedad { get; set; }
        public string FotoPrincipal { get; set; }
        public string CallePrincipal { get; set; }
        public string CalleSecundaria { get; set; }
        public int EstadoPropiedad { get; set; }
       
    }
}

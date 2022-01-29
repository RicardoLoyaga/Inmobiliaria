using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.VistaModelo
{
    public class CantonVistaModelo
    {
        public int IdCanton { get; set; }
        public Nullable<int> IdProvincia { get; set; }
        public string CodCanton { get; set; }
        public string NombreCanton { get; set; }
        public int EstadoCanton { get; set; }

    }
}

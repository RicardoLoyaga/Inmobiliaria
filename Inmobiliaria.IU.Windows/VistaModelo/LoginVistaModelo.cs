using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.VistaModelo
{
    public class LoginVistaModelo
    {
        public int IdLogin { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Estado { get; set; }
    }
}

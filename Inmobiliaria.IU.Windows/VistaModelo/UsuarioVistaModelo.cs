using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.VistaModelo
{
    public class UsuarioVistaModelo
    {
        public int IdUsuario { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string NombreUsuario { get; set; }
        public string IdentificacionUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string Username { get; set; }
        public string Contrasena { get; set; }
        public int Estado { get; set; }

    }
}

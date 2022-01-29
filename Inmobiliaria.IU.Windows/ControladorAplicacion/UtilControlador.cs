using Inmobiliaria.Aplicacion.ClaseServicioEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.ControladorAplicacion
{
    public class UtilControlador
    {
        private UtilServicio utilServicio;

        public UtilControlador()
        {
            utilServicio = new UtilServicio();
        }
        public string Encriptar(string texto)
        {
            string resp = utilServicio.Encriptar(texto);
            return resp;
        }
    }
}

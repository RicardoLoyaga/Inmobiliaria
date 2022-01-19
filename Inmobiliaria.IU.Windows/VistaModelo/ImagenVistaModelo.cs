using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.VistaModelo
{
    public class ImagenVistaModelo
    {
        public int IdImagen { get; set; }
        public Nullable<int> IdPropiedad { get; set; }
        public string Path { get; set; }
        public int EstadoImagen { get; set; }
    }
}

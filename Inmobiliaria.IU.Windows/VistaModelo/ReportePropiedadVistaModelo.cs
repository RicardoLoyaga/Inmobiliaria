using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.VistaModelo
{
    public class ReportePropiedadVistaModelo
    {
        public string NombreProvincia { get; set; }
        public string NombrePropietario { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaRegistroPropiedad { get; set; }
        public string Path { get; set; }
        public string CallePrincipal { get; set; }
        public string CalleSecundaria { get; set; }
        public double MetrosCuadrados { get; set; }
        public Nullable<int> Plantas { get; set; }
        public Nullable<decimal> Banios { get; set; }
        public Nullable<decimal> Habitaciones { get; set; }
        public Nullable<int> Parqueaderos { get; set; }
        public string Servicios { get; set; }
        public string Otros { get; set; }
    }
}

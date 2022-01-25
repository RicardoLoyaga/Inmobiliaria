using Inmobiliaria.Aplicacion.ClaseServicioEntidades;
using Inmobiliaria.Dominio.Modelo.Entidades;
using Inmobiliaria.IU.Windows.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.ControladorAplicacion
{
    public class TipoPropiedadControlador
    {
        private TipoPropiedadServicio tipoPropiedadServicio;

        public TipoPropiedadControlador()
        {
            tipoPropiedadServicio = new TipoPropiedadServicio();
        }

        public bool InsertarTipoPropiedad(TipoPropiedadVistaModelo tipoPropiedadVistaModelo)
        {
            TIPO_PROPIEDAD tipoPropiedad = new TIPO_PROPIEDAD();
            try
            {
                tipoPropiedad.TIPOPROPIEDAD = tipoPropiedadVistaModelo.TipoPropiedad;
                tipoPropiedad.ESTADOTIPOPROPIEDAD = tipoPropiedadVistaModelo.EstadoTipoPropiedad;
                tipoPropiedadServicio.InsertarTipoPropiedad(tipoPropiedad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarTipoPropiedad(TipoPropiedadVistaModelo tipoPropiedadVistaModelo)
        {
            TIPO_PROPIEDAD tipoPropiedad = new TIPO_PROPIEDAD();
            try
            {
                tipoPropiedad.TIPOPROPIEDAD = tipoPropiedadVistaModelo.TipoPropiedad;
                tipoPropiedad.ESTADOTIPOPROPIEDAD = tipoPropiedadVistaModelo.EstadoTipoPropiedad;
                tipoPropiedadServicio.ModificarTipoPropiedad(tipoPropiedad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<TipoPropiedadVistaModelo> GetTipoPropiedadAll()
        {
            var tipoPropiedadList = tipoPropiedadServicio.ListarTipoPropiedad();
            List<TipoPropiedadVistaModelo> vistaModelos = new List<TipoPropiedadVistaModelo>();

            foreach (TIPO_PROPIEDAD item in tipoPropiedadList)
            {
                vistaModelos.Add(new TipoPropiedadVistaModelo
                {
                    IdTipoPropiedad = item.IDTIPOPROPIEDAD,
                    TipoPropiedad = item.TIPOPROPIEDAD,
                    EstadoTipoPropiedad = item.ESTADOTIPOPROPIEDAD
                });
            }
            return vistaModelos;
        }
    }
}

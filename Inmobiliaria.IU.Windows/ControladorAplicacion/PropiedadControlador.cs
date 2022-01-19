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
    public class PropiedadControlador
    {
        private PropiedadServicio propiedadServicio;

        public PropiedadControlador()
        {
            propiedadServicio = new PropiedadServicio();
        }

        public bool InsertarPropiedad(PropiedadVistaModelo propiedadVistaModelo)
        {
            PROPIEDAD propiedad = new PROPIEDAD();
            try
            {
                propiedad.PRECIO = propiedadVistaModelo.Precio;
                propiedad.ESTADOPROPIEDAD = propiedadVistaModelo.EstadoPropiedad;
                propiedadServicio.InsertarPropiedad(propiedad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarPropiedad(PropiedadVistaModelo propiedadVistaModelo)
        {
            PROPIEDAD propiedad = new PROPIEDAD();
            try
            {
                propiedad.PRECIO = propiedadVistaModelo.Precio;
                propiedad.ESTADOPROPIEDAD = propiedadVistaModelo.EstadoPropiedad;
                propiedadServicio.ModificarPropiedad(propiedad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<PropiedadVistaModelo> GetPropiedadAll()
        {
            var propiedadList = propiedadServicio.ListarPropiedad();
            List<PropiedadVistaModelo> vistaModelos = new List<PropiedadVistaModelo>();

            foreach (PROPIEDAD item in propiedadList)
            {
                vistaModelos.Add(new PropiedadVistaModelo
                {
                    IdPropiedad = item.IDPROPIEDAD,
                    IdCaracteristica = item.IDCARACTERISTICA,
                    IdProvincia = item.IDPROVINCIA,
                    IdTipoPropiedad = item.IDTIPOPROPIEDAD,
                    IdPropietario = item.IDPROPIETARIO,
                    IdUsuario = item.IDUSUARIO,
                    Precio = item.PRECIO,
                    EstadoPropiedad = item.ESTADOPROPIEDAD
                });
            }
            return vistaModelos;
        }
    }
}

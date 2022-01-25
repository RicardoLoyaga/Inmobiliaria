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
    public class PropietarioControlador
    {
        private PropietarioServicio propietarioServicio;

        public PropietarioControlador()
        {
            propietarioServicio = new PropietarioServicio();
        }

        public bool InsertarPropietario(PropietarioVistaModelo propietarioVistaModelo)
        {
            PROPIETARIO propietario = new PROPIETARIO();
            try
            {
                propietario.NOMBREPROPIETARIO = propietarioVistaModelo.NombrePropietario;
                propietario.DIRECCIONPROPIETARIO = propietarioVistaModelo.DireccionPropietario;
                propietario.CELULARPROPIETARIO = propietarioVistaModelo.CelularPropietario;
                propietario.CORRREOPROPIETARIO = propietarioVistaModelo.CorreoPropietario;
                propietario.ESTADOPROPIETARIO = propietarioVistaModelo.EstadoPropietario;
                propietarioServicio.InsertarPropietario(propietario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarPropietario(PropietarioVistaModelo propietarioVistaModelo)
        {
            PROPIETARIO propietario = new PROPIETARIO();
            try
            {
                propietario.NOMBREPROPIETARIO = propietarioVistaModelo.NombrePropietario;
                propietario.DIRECCIONPROPIETARIO = propietarioVistaModelo.DireccionPropietario;
                propietario.CELULARPROPIETARIO = propietarioVistaModelo.CelularPropietario;
                propietario.CORRREOPROPIETARIO = propietarioVistaModelo.CorreoPropietario;
                propietario.ESTADOPROPIETARIO = propietarioVistaModelo.EstadoPropietario;
                propietarioServicio.ModificarPropietario(propietario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<PropietarioVistaModelo> GetPropietarioAll()
        {
            var propietarioList = propietarioServicio.ListarPropietario();
            List<PropietarioVistaModelo> vistaModelos = new List<PropietarioVistaModelo>();

            foreach (PROPIETARIO item in propietarioList)
            {
                vistaModelos.Add(new PropietarioVistaModelo
                {
                    IdPropietario = item.IDPROPIETARIO,
                    NombrePropietario = item.NOMBREPROPIETARIO,
                    DireccionPropietario = item.DIRECCIONPROPIETARIO,
                    CelularPropietario = item.CELULARPROPIETARIO,
                    CorreoPropietario = item.CORRREOPROPIETARIO,
                    EstadoPropietario = item.ESTADOPROPIETARIO
                });
            }
            return vistaModelos;
        }
    }
}

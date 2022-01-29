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
    public class CantonControlador
    {
        private CantonServicio cantonServicio;

        public CantonControlador()
        {
            cantonServicio = new CantonServicio();
        }

        public bool InsertarCanton(CantonVistaModelo cantonVistaModelo)
        {
            CANTON canton = new CANTON();
            try
            {
                canton.NOMBRECANTON = cantonVistaModelo.NombreCanton;
                canton.ESTADOCANTON = cantonVistaModelo.EstadoCanton;
                cantonServicio.InsertarCanton(canton);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarCanton(CantonVistaModelo cantonVistaModelo)
        {
            CANTON canton = new CANTON();
            try
            {
                canton.NOMBRECANTON = cantonVistaModelo.NombreCanton;
                canton.ESTADOCANTON = cantonVistaModelo.EstadoCanton;
                cantonServicio.ModificarCanton(canton);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<CantonVistaModelo> GetCantonAll()
        {
            var cantonList = cantonServicio.ListarCanton();
            List<CantonVistaModelo> vistaModelos = new List<CantonVistaModelo>();

            foreach (CANTON item in cantonList)
            {
                vistaModelos.Add(new CantonVistaModelo
                {
                    IdCanton = item.IDCANTON,
                    IdProvincia = item.IDPROVINCIA,
                    NombreCanton = item.NOMBRECANTON,
                    EstadoCanton = item.ESTADOCANTON
                });
            }
            return vistaModelos;
        }
    }
}

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
    public class ParroquiaControlador
    {
        private ParroquiaServicio parroquiaServicio;

        public ParroquiaControlador()
        {
            parroquiaServicio = new ParroquiaServicio();
        }

        public bool InsertarParroquia(ParroquiaVistaModelo parroquiaVistaModelo)
        {
            PARROQUIA parroquia = new PARROQUIA();
            try
            {
                parroquia.PARROQUIA1 = parroquiaVistaModelo.Parroquia1;
                parroquia.ESTADOPARROQUIA = parroquiaVistaModelo.EstadoParroquia;
                parroquiaServicio.InsertarParroquia(parroquia);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarParroquia(ParroquiaVistaModelo parroquiaVistaModelo)
        {
            PARROQUIA parroquia = new PARROQUIA();
            try
            {
                parroquia.PARROQUIA1 = parroquiaVistaModelo.Parroquia1;
                parroquia.ESTADOPARROQUIA = parroquiaVistaModelo.EstadoParroquia;
                parroquiaServicio.ModificarParroquia(parroquia);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<ParroquiaVistaModelo> GetParroquiaAll()
        {
            var parroquiaList = parroquiaServicio.ListarParroquia();
            List<ParroquiaVistaModelo> vistaModelos = new List<ParroquiaVistaModelo>();

            foreach (PARROQUIA item in parroquiaList)
            {
                vistaModelos.Add(new ParroquiaVistaModelo
                {
                    IdParroquia = item.IDPARROQUIA,
                    IdCanton = item.IDCANTON,
                    Parroquia1 = item.PARROQUIA1,
                    EstadoParroquia = item.ESTADOPARROQUIA
                });
            }
            return vistaModelos;
        }
    }
}

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
    public class BarrioControlador
    {
        private BarrioServicio barrioServicio;

        public BarrioControlador()
        {
            barrioServicio = new BarrioServicio();
        }

        public bool InsertarBarrio(BarrioVistaModelo barrioVistaModelo)
        {
            BARRIO barrio = new BARRIO();
            try
            {
                barrio.NOMBREBARRIO = barrioVistaModelo.Barrio1;
                barrio.ESTADOBARRIO = barrioVistaModelo.EstadoBarrio;
                barrioServicio.InsertarBarrio(barrio);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarBarrio(BarrioVistaModelo barrioVistaModelo)
        {
            BARRIO barrio = new BARRIO();
            try
            {
                barrio.NOMBREBARRIO = barrioVistaModelo.Barrio1;
                barrio.ESTADOBARRIO = barrioVistaModelo.EstadoBarrio;
                barrioServicio.ModificarBarrio(barrio);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<BarrioVistaModelo> GetBarrioAll()
        {
            var barrioList = barrioServicio.ListarBarrio();
            List<BarrioVistaModelo> vistaModelos = new List<BarrioVistaModelo>();

            foreach (BARRIO item in barrioList)
            {
                vistaModelos.Add(new BarrioVistaModelo
                {
                    IdBarrio = item.IDBARRIO,
                    IdParroquia = item.IDPARROQUIA,
                    Barrio1 = item.NOMBREBARRIO,
                    EstadoBarrio = item.ESTADOBARRIO
                });
            }
            return vistaModelos;
        }
    }
}

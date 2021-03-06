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
    public class RolControlador
    {
        private RolServicio rolServicio;

        public RolControlador()
        {
            rolServicio = new RolServicio();
        }

        public bool InsertarRol(RolVistaModelo rolVistaModelo)
        {
            ROL rol = new ROL();
            try
            {
                rol.NOMBREROL = rolVistaModelo.NombreRol;
                rol.ESTADOROL = rolVistaModelo.EstadoRol;
                rolServicio.InsertarRol(rol);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarRol(RolVistaModelo rolVistaModelo)
        {
            ROL rol = new ROL();
            try
            {
                rol.NOMBREROL = rolVistaModelo.NombreRol;
                rol.ESTADOROL = rolVistaModelo.EstadoRol;
                rolServicio.ModificarRol(rol);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<RolVistaModelo> GetRolAll()
        {
            var rolList = rolServicio.ListarRol();
            List<RolVistaModelo> vistaModelos = new List<RolVistaModelo>();

            foreach (ROL item in rolList)
            {
                vistaModelos.Add(new RolVistaModelo
                {
                    IdRol = item.IDROL,
                    NombreRol = item.NOMBREROL,
                    EstadoRol = item.ESTADOROL
                });
            }
            return vistaModelos;
        }

        /*public List<ROL> poblarCboRol()
        {
            var listRol = rolServicio.poblarCboRol();
            List<RolVistaModelo> vistaModelos = new List<RolVistaModelo>();

            foreach (ROL item in listRol)
            {
                vistaModelos.Add(new RolVistaModelo
                {
                    IdRol = item.IDROL,
                    Rol1 = item.NOMBREROL
                });
            }
            return vistaModelos;
        }*/
    }
}

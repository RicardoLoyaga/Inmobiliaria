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
    public class ProvinciaControlador
    {
        private ProvinciaServicio provinciaServicio;

        public ProvinciaControlador()
        {
            provinciaServicio = new ProvinciaServicio();
        }

        public bool InsertarProvincia(ProvinciaVistaModelo provinciaVistaModelo)
        {
            PROVINCIA provincia = new PROVINCIA();
            try
            {
                provincia.NOMBREPROVINCIA = provinciaVistaModelo.NombreProvincia;
                provincia.ESTADOPROVINCIA = provinciaVistaModelo.EstadoProvincia;
                provinciaServicio.InsertarProvincia(provincia);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarProvincia(ProvinciaVistaModelo provinciaVistaModelo)
        {
            PROVINCIA provincia = new PROVINCIA();
            try
            {
                provincia.NOMBREPROVINCIA = provinciaVistaModelo.NombreProvincia;
                provincia.ESTADOPROVINCIA = provinciaVistaModelo.EstadoProvincia;
                provinciaServicio.ModificarProvincia(provincia);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<ProvinciaVistaModelo> GetProvinciaAll()
        {
            var provinciaList = provinciaServicio.ListarProvincia();
            List<ProvinciaVistaModelo> vistaModelos = new List<ProvinciaVistaModelo>();

            foreach (PROVINCIA item in provinciaList)
            {
                vistaModelos.Add(new ProvinciaVistaModelo
                {
                    IdProvincia = item.IDPROVINCIA,
                    CodProvincia = item.CODPROVINCIA,
                    NombreProvincia = item.NOMBREPROVINCIA,
                    EstadoProvincia = item.ESTADOPROVINCIA
                });
            }
            return vistaModelos;
        }
    }
}

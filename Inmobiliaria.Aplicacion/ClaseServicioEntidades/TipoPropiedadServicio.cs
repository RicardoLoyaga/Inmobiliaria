using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using Inmobiliaria.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Aplicacion.ClaseServicioEntidades
{
    public class TipoPropiedadServicio
    {
        readonly ITipoPropiedadRepositorio tipoPropiedadRepositorio;

        public TipoPropiedadServicio()
        {
            tipoPropiedadRepositorio = new TipoPropiedadRepositorio();
        }

        public void InsertarTipoPropiedad(TIPO_PROPIEDAD tipoPropiedad)
        {
            try
            {
                tipoPropiedadRepositorio.Add(tipoPropiedad);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarTipoPropiedad(TIPO_PROPIEDAD tipoPropiedad)
        {
            tipoPropiedadRepositorio.Modify(tipoPropiedad);
        }

        public IEnumerable<TIPO_PROPIEDAD> ListarTipoPropiedad()
        {
            return tipoPropiedadRepositorio.GetAll();
        }

        public void EliminarTipoPropiedad(int id)
        {
            tipoPropiedadRepositorio.Delete(id);
        }
    }
}

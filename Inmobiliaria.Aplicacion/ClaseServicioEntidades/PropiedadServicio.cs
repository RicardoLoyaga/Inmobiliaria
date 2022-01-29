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
    public class PropiedadServicio
    {
        readonly IPropiedadRepositorio propiedadRepositorio;

        public PropiedadServicio()
        {
            propiedadRepositorio = new PropiedadRepositorio();
        }

        public void InsertarPropiedad(PROPIEDAD propiedad)
        {
            try
            {
                propiedadRepositorio.Add(propiedad);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarPropiedad(PROPIEDAD propiedad)
        {
            propiedadRepositorio.Modify(propiedad);
        }

        public IEnumerable<PROPIEDAD> ListarPropiedad()
        {
            return propiedadRepositorio.GetAll();
        }

        public void EliminarPropiedad(int id)
        {
            propiedadRepositorio.Delete(id);
        }

        public List<PROVINCIA> poblarCboProvincia()
        {
            return propiedadRepositorio.poblarCboProvincia();
        }

        public List<CANTON> poblarCboCanton(int id)
        {
            return propiedadRepositorio.poblarCboCanton(id);
        }

        public List<PARROQUIA> poblarCboParroquia(int idCa)
        {
            return propiedadRepositorio.poblarCboParroquia(idCa);
        }

        public List<BARRIO> poblarCboBarrio(int idPar)
        {
            return propiedadRepositorio.poblarCboBarrio(idPar);
        }

        public List<TIPO_PROPIEDAD> poblarCboTipoPropiedad()
        {
            return propiedadRepositorio.poblarCboTipoPropiedad();
        }

    }
}

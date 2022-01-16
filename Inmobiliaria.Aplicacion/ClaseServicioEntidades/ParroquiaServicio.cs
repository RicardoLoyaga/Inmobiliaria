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
    public class ParroquiaServicio
    {
        readonly IParroquiaRepositorio parroquiaRepositorio;

        public ParroquiaServicio()
        {
            parroquiaRepositorio = new ParroquiaRepositorio();
        }

        public void InsertarParroquia(PARROQUIA parroquia)
        {
            try
            {
                parroquiaRepositorio.Add(parroquia);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarParroquia(PARROQUIA parroquia)
        {
            parroquiaRepositorio.Modify(parroquia);
        }

        public IEnumerable<PARROQUIA> ListarParroquia()
        {
            return parroquiaRepositorio.GetAll();
        }

        public void EliminarParroquia(int id)
        {
            parroquiaRepositorio.Delete(id);
        }
    }
}

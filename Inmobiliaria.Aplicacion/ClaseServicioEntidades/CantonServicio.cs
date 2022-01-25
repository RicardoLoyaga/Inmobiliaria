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
    public class CantonServicio
    {
        readonly ICantonRepositorio cantonRepositorio;

        public CantonServicio()
        {
            cantonRepositorio = new CantonRepositorio();
        }

        public void InsertarCanton(CANTON canton)
        {
            try
            {
                cantonRepositorio.Add(canton);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarCanton(CANTON canton)
        {
            cantonRepositorio.Modify(canton);
        }

        public IEnumerable<CANTON> ListarCanton()
        {
            return cantonRepositorio.GetAll();
        }

        public void EliminarCanton(int id)
        {
            cantonRepositorio.Delete(id);
        }
    }
}

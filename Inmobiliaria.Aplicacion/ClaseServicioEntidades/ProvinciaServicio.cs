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
    public class ProvinciaServicio
    {
        readonly IProvinciaRepositorio provinciaRepositorio;

        public ProvinciaServicio()
        {
            provinciaRepositorio = new ProvinciaRepositorio();
        }

        public void InsertarProvincia(PROVINCIA provincia)
        {
            try
            {
                provinciaRepositorio.Add(provincia);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarProvincia(PROVINCIA provincia)
        {
            provinciaRepositorio.Modify(provincia);
        }

        public IEnumerable<PROVINCIA> ListarProvincia()
        {
            return provinciaRepositorio.GetAll();
        }

        public void EliminarProvincia(int id)
        {
            provinciaRepositorio.Delete(id);
        }
    }
}

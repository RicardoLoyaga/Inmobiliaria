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
    public class RolServicio
    {
        readonly IRolRepositorio rolRepositorio;

        public RolServicio()
        {
            rolRepositorio = new RolRepositorio();
        }

        public void InsertarRol(ROL rol)
        {
            try
            {
                rolRepositorio.Add(rol);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarRol(ROL rol)
        {
            rolRepositorio.Modify(rol);
        }

        public IEnumerable<ROL> ListarRol()
        {
            return rolRepositorio.GetAll();
        }

        public void EliminarRol(int id)
        {
            rolRepositorio.Delete(id);
        }
    }
}

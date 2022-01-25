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
    public class PropietarioServicio
    {
        readonly IPropietarioRepositorio propietarioRepositorio;

        public PropietarioServicio()
        {
            propietarioRepositorio = new PropietarioRepositorio();
        }

        public void InsertarPropietario(PROPIETARIO propietario)
        {
            try
            {
                propietarioRepositorio.Add(propietario);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarPropietario(PROPIETARIO propietario)
        {
            propietarioRepositorio.Modify(propietario);
        }

        public IEnumerable<PROPIETARIO> ListarPropietario()
        {
            return propietarioRepositorio.GetAll();
        }

        public void EliminarPropietario(int id)
        {
            propietarioRepositorio.Delete(id);
        }
    }
}

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
    public class UsuarioServicio
    {
        readonly IUsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public void InsertarUsuario(USUARIO usuario)
        {
            try
            {
                usuarioRepositorio.Add(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarUsuario(USUARIO usuario)
        {
            usuarioRepositorio.Modify(usuario);
        }

        public IEnumerable<USUARIO> ListarUsuario()
        {
            return usuarioRepositorio.GetAll();
        }

        public void EliminarUsuario(int id)
        {
            usuarioRepositorio.Delete(id);
        }
    }
}

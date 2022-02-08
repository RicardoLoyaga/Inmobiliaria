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
        readonly IUtilRepositorio utilRepositorio;

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

        public List<ROL> poblarCboRol()
        {
            return usuarioRepositorio.poblarCboRol();
        }

        public USUARIO username(string user)
        {
            return usuarioRepositorio.username(user);
        }

        public bool validaUsuario(string mail)
        {
            return usuarioRepositorio.validaUsuario(mail);
        }

        public string Encriptar(string texto)
        {
            return usuarioRepositorio.Encriptar(texto);
        }
    }
}

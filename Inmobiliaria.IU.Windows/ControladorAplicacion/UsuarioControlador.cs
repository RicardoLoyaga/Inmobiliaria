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
    public class UsuarioControlador
    {
        private UsuarioServicio usuarioServicio;

        public UsuarioControlador()
        {
            usuarioServicio = new UsuarioServicio();
        }

        public bool InsertarUsuario(UsuarioVistaModelo usuarioVistaModelo)
        {
            USUARIO usuario = new USUARIO();
            try
            {
                usuario.NOMBREUSUARIO = usuarioVistaModelo.NombreUsuario;
                usuario.IDROL = usuarioVistaModelo.IdRol;
                usuario.IDENTIFICACIONUSUARIO = usuarioVistaModelo.IdentificacionUsuario;
                usuario.CORREOUSUARIO = usuarioVistaModelo.CorreoUsuario;
                usuario.USERNAME = usuarioVistaModelo.Username;
                usuario.CONTRASENA = usuarioVistaModelo.Contrasena;
                usuario.ESTADO = usuarioVistaModelo.Estado;
                usuarioServicio.InsertarUsuario(usuario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarUsuario(UsuarioVistaModelo usuarioVistaModelo)
        {
            USUARIO usuario = new USUARIO();
            try
            {
                usuario.NOMBREUSUARIO = usuarioVistaModelo.NombreUsuario;
                usuario.IDUSUARIO = usuarioVistaModelo.IdUsuario;
                usuario.IDROL = usuarioVistaModelo.IdRol;
                usuario.IDENTIFICACIONUSUARIO = usuarioVistaModelo.IdentificacionUsuario;
                usuario.CORREOUSUARIO = usuarioVistaModelo.CorreoUsuario;
                usuario.USERNAME = usuarioVistaModelo.Username;
                usuario.CONTRASENA = usuarioVistaModelo.Contrasena;
                usuario.ESTADO = usuarioVistaModelo.Estado;
                usuarioServicio.ModificarUsuario(usuario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<UsuarioVistaModelo> GetUsuarioAll()
        {
            var usuarioList = usuarioServicio.ListarUsuario();
            List<UsuarioVistaModelo> vistaModelos = new List<UsuarioVistaModelo>();

            foreach (USUARIO item in usuarioList)
            {
                vistaModelos.Add(new UsuarioVistaModelo
                {
                    IdUsuario = item.IDUSUARIO,
                    IdRol = item.IDROL,
                    NombreUsuario = item.NOMBREUSUARIO,
                    IdentificacionUsuario = item.IDENTIFICACIONUSUARIO,
                    CorreoUsuario = item.CORREOUSUARIO,
                    Username = item.USERNAME,
                    Contrasena = item.CONTRASENA,
                    Estado = item.ESTADO
                });
            }
            return vistaModelos;
        }

        public List<RolVistaModelo> poblarCboRol()
        {
            var loginListRol = usuarioServicio.poblarCboRol();
            List<RolVistaModelo> vistaModelos = new List<RolVistaModelo>();

            foreach (ROL item in loginListRol)
            {
                vistaModelos.Add(new RolVistaModelo
                {
                    IdRol = item.IDROL,
                    NombreRol = item.NOMBREROL
                });
            }
            return vistaModelos;
        }

        public USUARIO username(string user)
        {
            USUARIO logi = new USUARIO();
            logi = usuarioServicio.username(user);

            return logi;
        }

        public string Encriptar(string texto)
        {
            string resp = usuarioServicio.Encriptar(texto);
            return resp;
        }
    }
}

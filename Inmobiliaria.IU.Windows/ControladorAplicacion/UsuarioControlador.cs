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
                usuario.IDENTIFICACIONUSUARIO = usuarioVistaModelo.IdentificacionUsuario;
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
                usuario.IDENTIFICACIONUSUARIO = usuarioVistaModelo.IdentificacionUsuario;
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
                    IdLogin = item.IDLOGIN,
                    NombreUsuario = item.NOMBREUSUARIO,
                    IdentificacionUsuario = item.IDENTIFICACIONUSUARIO,
                    Estado = item.ESTADO
                });
            }
            return vistaModelos;
        }
    }
}

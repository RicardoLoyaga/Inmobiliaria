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
    public class LoginControlador
    {
        private LoginServicio loginServicio;

        public LoginControlador()
        {
            loginServicio = new LoginServicio();
        }

        public bool InsertarLogin(LoginVistaModelo loginVistaModelo)
        {
            LOGIN login = new LOGIN();
            try
            {
                login.USUARIO = loginVistaModelo.Usuario;
                login.IDROL = loginVistaModelo.IdRol;
                login.CONTRASENA = loginVistaModelo.Contrasena;
                login.ESTADO = loginVistaModelo.Estado;
                loginServicio.InsertarLogin(login);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarLogin(LoginVistaModelo loginVistaModelo)
        {
            LOGIN login = new LOGIN();
            try
            {
                login.USUARIO = loginVistaModelo.Usuario;
                login.CONTRASENA = loginVistaModelo.Contrasena;
                login.ESTADO = loginVistaModelo.Estado;
                loginServicio.ModificarLogin(login);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<LoginVistaModelo> GetLoginAll()
        {
            var loginList =  loginServicio.ListarLogin();
            List<LoginVistaModelo> vistaModelos = new List<LoginVistaModelo>();

            foreach (LOGIN item in loginList)
            {
                vistaModelos.Add(new LoginVistaModelo
                {
                    IdLogin = item.IDLOGIN,
                    IdRol = item.IDROL,
                    Usuario = item.USUARIO,
                    Contrasena = item.CONTRASENA,
                    Estado = item.ESTADO
                });
            }
            return vistaModelos;
        }

        public List<RolVistaModelo> poblarCboRol()
        {
            var loginListRol = loginServicio.poblarCboRol();
            List<RolVistaModelo> vistaModelos = new List<RolVistaModelo>();

            foreach (ROL item in loginListRol)
            {
                vistaModelos.Add(new RolVistaModelo
                {
                    IdRol = item.IDROL,
                    Rol1 = item.NOMBREROL
                });
            }
            return vistaModelos;
        }

        public LOGIN username(string user)
        {
            LOGIN logi = new LOGIN();
            logi = loginServicio.username(user);

            return logi;
        }

    }
}

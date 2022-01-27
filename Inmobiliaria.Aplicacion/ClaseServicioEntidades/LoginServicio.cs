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
    public class LoginServicio
    {
        readonly ILoginRepositorio loginRepositorio;

        public LoginServicio()
        {
            loginRepositorio = new LoginRepositorio();
        }

        public void InsertarLogin(LOGIN login)
        {
            try
            {
                loginRepositorio.Add(login);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarLogin(LOGIN login)
        {
            loginRepositorio.Modify(login);
        }

        public IEnumerable<LOGIN> ListarLogin()
        {
            return loginRepositorio.GetAll();
        }

        public void EliminarLogin(int id)
        {
            loginRepositorio.Delete(id);
        }

        public List<ROL> poblarCboRol()
        {
            return loginRepositorio.poblarCboRol();
        }

        public LOGIN username(string user)
        {
            return loginRepositorio.username(user);
        }
    }
}

using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<USUARIO>, IUsuarioRepositorio
    {
        public List<ROL> poblarCboRol()
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from rol in context.ROL
                                where rol.ESTADOROL == 1
                                select rol;
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }

        public USUARIO username(string user)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from login in context.USUARIO
                                where login.USERNAME == user && login.ESTADO == 1
                                select login;
                    return query.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }

        public bool validaUsuario(string mail)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from user in context.USUARIO
                                where user.CORREOUSUARIO == mail && user.ESTADO == 1
                                select user;
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }

        public string Encriptar(string texto)
        {
            //sha 256
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(texto));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }

    
}

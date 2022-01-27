using Inmobiliaria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class UtilRepositorio : IUtilRepositorio
    {
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

        public bool ValidarCondicionesPassword(string password, out string errorMensaje)
        {
            errorMensaje = string.Empty;
            var label = password;
            if (string.IsNullOrWhiteSpace(label))
            {
                errorMensaje = "Clave no puede estar vacia";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasMiniMaxChars.IsMatch(label))
            {
                errorMensaje = "La clave debe tener entre 8 y 15 caracteres";
                return false;
            }
            else if (!hasUpperChar.IsMatch(label))
            {
                errorMensaje = "La clave debe contener al menos una letra mayúscula";
                return false;
            }
            else if (!hasLowerChar.IsMatch(label))
            {
                errorMensaje = "La clave debe contener al menos una letra minúscula";
                return false;
            }
            else if (!hasNumber.IsMatch(label))
            {
                errorMensaje = "La clave debe contener al menos un número";
                return false;
            }
            else if (!hasSymbols.IsMatch(label))
            {
                errorMensaje = "La clave debe contener al menos un carácter especial";
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

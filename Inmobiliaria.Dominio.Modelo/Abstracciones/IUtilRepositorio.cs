using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio.Modelo.Abstracciones
{
    public interface IUtilRepositorio
    {
        string Encriptar(string texto);

        bool ValidarCondicionesPassword(string password, out string error);
    }
}

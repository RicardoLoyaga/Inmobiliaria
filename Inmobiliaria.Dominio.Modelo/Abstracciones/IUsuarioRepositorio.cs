using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio.Modelo.Abstracciones
{
    public interface IUsuarioRepositorio : IBaseRepositorio<USUARIO>
    {
        List<ROL> poblarCboRol();

        USUARIO username(string user);

        bool validaUsuario(string mail);

        string Encriptar(string texto);
    }
}

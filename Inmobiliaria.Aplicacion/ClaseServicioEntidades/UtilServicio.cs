using Inmobiliaria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Aplicacion.ClaseServicioEntidades
{
    public class UtilServicio
    {
        readonly IUtilRepositorio utilRepositorio;
        public string Encriptar(string texto)
        {
            return utilRepositorio.Encriptar(texto);
        }
    }
}

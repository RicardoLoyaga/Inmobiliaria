using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio.Modelo.Abstracciones
{
    public interface IPoblarRepositorio<TEntity> where TEntity : class
    {
        List<TEntity> ObtenerTodos();

        List<TEntity> ObtenerDepentientes(int id);
    }
}

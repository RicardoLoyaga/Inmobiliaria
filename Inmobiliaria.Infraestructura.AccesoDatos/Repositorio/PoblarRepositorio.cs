using Inmobiliaria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class PoblarRepositorio<TEntity> : IDisposable, IPoblarRepositorio<TEntity> where TEntity : class
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        

        public List<TEntity> ObtenerDepentientes(int id)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se puede recuperar el registro" + ex.Message);
            }
        }

        public List<TEntity> ObtenerTodos()
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se puede recuperar los registros" + ex.Message);
            }
        }
    }
}

using Inmobiliaria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class BaseRepositorio<TEntity> : IDisposable, IBaseRepositorio<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se puede guardar el registro" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se puede eliminar el registro" + ex.Message);
            }
        }

        public IEnumerable<TEntity> GetAll()
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

        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se puede recuperar el registro" + ex.Message);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    context.Entry(entity).State = EntityState.Modified; ;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se puede actualizar el registro" + ex.Message);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

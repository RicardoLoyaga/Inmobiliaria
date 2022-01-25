using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class LoginRepositorio : BaseRepositorio<LOGIN>, ILoginRepositorio
    {
        public List<ROL> poblarCboRol()
        {
            try
            {
                using (var context = new INMOBILIARIAEntities1())
                {
                    var query = from rol in context.ROL
                                select rol;
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception ("Error al consultar la BDD" +ex);
            }
        }
    }
}

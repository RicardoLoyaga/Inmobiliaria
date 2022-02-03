using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class CantonRepositorio:BaseRepositorio<CANTON>,ICantonRepositorio
    {
        public List<PROVINCIA> poblarCboProvincia()
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from prov in context.PROVINCIA
                                where prov.ESTADOPROVINCIA == 1
                                select prov;
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }
    }
}

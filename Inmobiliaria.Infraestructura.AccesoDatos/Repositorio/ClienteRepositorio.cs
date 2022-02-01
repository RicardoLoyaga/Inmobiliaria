using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class ClienteRepositorio:BaseRepositorio<CLIENTE>,IClienteRepositorio
    {
        public List<USUARIO> poblarCboAsesores()
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from asesor in context.USUARIO
                                where asesor.IDROL == 2
                                && asesor.ESTADO == 1
                                select asesor;
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

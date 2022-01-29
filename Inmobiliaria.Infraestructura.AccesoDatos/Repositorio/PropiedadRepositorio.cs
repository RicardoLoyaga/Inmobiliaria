using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Infraestructura.AccesoDatos.Repositorio
{
    public class PropiedadRepositorio:BaseRepositorio<PROPIEDAD>,IPropiedadRepositorio
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

        public List<CANTON> poblarCboCanton(int id)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from can in context.CANTON
                                where can.ESTADOCANTON == 1 
                                && can.IDPROVINCIA == id
                                select can;
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }

        public List<PARROQUIA> poblarCboParroquia(int idCa)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = (from par in context.PARROQUIA
                                where par.ESTADOPARROQUIA == 1
                                && par.IDCANTON == idCa
                                select par).GroupBy(p=>p.NOMBREPARROQUIA).Select(g=>g.FirstOrDefault()).ToList();
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }

        public List<BARRIO> poblarCboBarrio(int idPar)
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = (from bar in context.BARRIO
                                 where bar.ESTADOBARRIO == 1
                                 && bar.IDPARROQUIA == idPar
                                 select bar).GroupBy(p => p.NOMBREBARRIO).Select(g => g.FirstOrDefault()).ToList();
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar la BDD" + ex);
            }
        }

        public List<TIPO_PROPIEDAD> poblarCboTipoPropiedad()
        {
            try
            {
                using (var context = new INMOBILIARIAEntities())
                {
                    var query = from tprop in context.TIPO_PROPIEDAD
                                where tprop.ESTADOTIPOPROPIEDAD == 1
                                select tprop;
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

using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio.Modelo.Abstracciones
{
    public interface IPropiedadRepositorio:IBaseRepositorio<PROPIEDAD>
    {
        List<PROVINCIA> poblarCboProvincia();
        List<CANTON> poblarCboCanton(int id);
        List<PARROQUIA> poblarCboParroquia(int idCa);
        List<BARRIO> poblarCboBarrio(int idPar);
        List<TIPO_PROPIEDAD> poblarCboTipoPropiedad();
        List<ReportePropiedad> listadoPropiedades();
    }
}

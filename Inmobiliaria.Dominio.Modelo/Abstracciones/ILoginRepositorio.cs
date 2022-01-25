using Inmobiliaria.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio.Modelo.Abstracciones
{
    public interface ILoginRepositorio:IBaseRepositorio<LOGIN>
    {
        List<ROL> poblarCboRol();
    }
}

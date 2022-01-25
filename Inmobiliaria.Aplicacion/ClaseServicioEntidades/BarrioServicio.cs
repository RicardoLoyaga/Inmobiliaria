using Inmobiliaria.Dominio.Modelo.Abstracciones;
using Inmobiliaria.Dominio.Modelo.Entidades;
using Inmobiliaria.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Aplicacion.ClaseServicioEntidades
{
    public class BarrioServicio
    {
        readonly IBarrioRepositorio barrioRepositorio;

        public BarrioServicio()
        {
            barrioRepositorio = new BarrioRepositorio();
        }

        public void InsertarBarrio(BARRIO barrio)
        {
            try
            {
                barrioRepositorio.Add(barrio);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarBarrio(BARRIO barrio)
        {
            barrioRepositorio.Modify(barrio);
        }

        public IEnumerable<BARRIO> ListarBarrio()
        {
            return barrioRepositorio.GetAll();
        }

        public void EliminarBarrio(int id)
        {
            barrioRepositorio.Delete(id);
        }
    }
}

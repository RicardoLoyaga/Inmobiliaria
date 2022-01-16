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
    public class CaracteristicaServicio
    {
        readonly ICaracteristicaRepositorio caracteristicaRepositorio;

        public CaracteristicaServicio()
        {
            caracteristicaRepositorio = new CaracteristicaRepositorio();
        }

        public void InsertarCaracteristica(CARACTERISTICA caracteristica)
        {
            try
            {
                caracteristicaRepositorio.Add(caracteristica);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarCaracteristica(CARACTERISTICA caracteristica)
        {
            caracteristicaRepositorio.Modify(caracteristica);
        }

        public IEnumerable<CARACTERISTICA> ListarCaracteristica()
        {
            return caracteristicaRepositorio.GetAll();
        }

        public void EliminarCaracteristica(int id)
        {
            caracteristicaRepositorio.Delete(id);
        }
    }
}

using Inmobiliaria.Aplicacion.ClaseServicioEntidades;
using Inmobiliaria.Dominio.Modelo.Entidades;
using Inmobiliaria.IU.Windows.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.IU.Windows.ControladorAplicacion
{
    public class CaracteristicaControlador
    {
        private CaracteristicaServicio caracteristicaServicio;

        public CaracteristicaControlador()
        {
            caracteristicaServicio = new CaracteristicaServicio();
        }

        public bool InsertarCaracteristica(CaracteristicaVistaModelo caracteristicaVistaModelo)
        {
            CARACTERISTICA caracteristica = new CARACTERISTICA();
            try
            {
                caracteristica.METROSCUADRADOS = caracteristicaVistaModelo.MetrosCuadrados;
                caracteristica.PLANTAS = caracteristicaVistaModelo.Plantas;
                caracteristica.BANIOS = caracteristicaVistaModelo.Banios;
                caracteristica.HABITACIONES = caracteristicaVistaModelo.Habitaciones;
                caracteristica.PARQUEADEROS = caracteristicaVistaModelo.Parqueaderos;
                caracteristica.SERVICIOS = caracteristicaVistaModelo.Servicios;
                caracteristica.OTROS = caracteristicaVistaModelo.Otros;
                caracteristicaServicio.InsertarCaracteristica(caracteristica);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarCaracteristica(CaracteristicaVistaModelo caracteristicaVistaModelo)
        {
            CARACTERISTICA caracteristica = new CARACTERISTICA();
            try
            {
                caracteristica.METROSCUADRADOS = caracteristicaVistaModelo.MetrosCuadrados;
                caracteristica.PLANTAS = caracteristicaVistaModelo.Plantas;
                caracteristica.BANIOS = caracteristicaVistaModelo.Banios;
                caracteristica.HABITACIONES = caracteristicaVistaModelo.Habitaciones;
                caracteristica.PARQUEADEROS = caracteristicaVistaModelo.Parqueaderos;
                caracteristica.SERVICIOS = caracteristicaVistaModelo.Servicios;
                caracteristica.OTROS = caracteristicaVistaModelo.Otros;
                caracteristicaServicio.ModificarCaracteristica(caracteristica);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<CaracteristicaVistaModelo> GetCaracteristicaAll()
        {
            var caracteristicaList = caracteristicaServicio.ListarCaracteristica();
            List<CaracteristicaVistaModelo> vistaModelos = new List<CaracteristicaVistaModelo>();

            foreach (CARACTERISTICA item in caracteristicaList)
            {
                vistaModelos.Add(new CaracteristicaVistaModelo
                {
                    IdCaracteristica = item.IDCARACTERISTICA,
                    MetrosCuadrados = item.METROSCUADRADOS,
                    Plantas = item.PLANTAS,
                    Banios = item.BANIOS,
                    Habitaciones = item.HABITACIONES,
                    Parqueaderos = item.PARQUEADEROS,
                    Servicios = item.SERVICIOS,
                    Otros = item.OTROS
                });
            }
            return vistaModelos;
        }
    }
}

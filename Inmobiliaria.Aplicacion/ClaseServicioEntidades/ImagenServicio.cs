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
    public class ImagenServicio
    {
        readonly IImagenRepositorio imagenRepositorio;

        public ImagenServicio()
        {
            imagenRepositorio = new ImagenRepositorio();
        }

        public void InsertarImagen(IMAGEN imagen)
        {
            try
            {
                imagenRepositorio.Add(imagen);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarImagen(IMAGEN imagen)
        {
            imagenRepositorio.Modify(imagen);
        }

        public IEnumerable<IMAGEN> ListarImagen()
        {
            return imagenRepositorio.GetAll();
        }

        public void EliminarImagen(int id)
        {
            imagenRepositorio.Delete(id);
        }
    }
}

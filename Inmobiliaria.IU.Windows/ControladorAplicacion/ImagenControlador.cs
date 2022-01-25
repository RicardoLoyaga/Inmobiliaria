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
    public class ImagenControlador
    {
        private ImagenServicio imagenServicio;

        public ImagenControlador()
        {
            imagenServicio = new ImagenServicio();
        }

        public bool InsertarImagen(ImagenVistaModelo imagenVistaModelo)
        {
            IMAGEN imagen = new IMAGEN();
            try
            {
                imagen.PATH = imagenVistaModelo.Path;
                imagen.ESTADOIMAGEN = imagenVistaModelo.EstadoImagen;
                imagenServicio.InsertarImagen(imagen);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarImagen(ImagenVistaModelo imagenVistaModelo)
        {
            IMAGEN imagen = new IMAGEN();
            try
            {
                imagen.PATH = imagenVistaModelo.Path;
                imagen.ESTADOIMAGEN = imagenVistaModelo.EstadoImagen;
                imagenServicio.ModificarImagen(imagen);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<ImagenVistaModelo> GetImagenAll()
        {
            var imagenList = imagenServicio.ListarImagen();
            List<ImagenVistaModelo> vistaModelos = new List<ImagenVistaModelo>();

            foreach (IMAGEN item in imagenList)
            {
                vistaModelos.Add(new ImagenVistaModelo
                {
                    IdImagen = item.IDIMAGEN,
                    IdPropiedad = item.IDPROPIEDAD,
                    Path = item.PATH,
                    EstadoImagen = item.ESTADOIMAGEN
                });
            }
            return vistaModelos;
        }
    }
}

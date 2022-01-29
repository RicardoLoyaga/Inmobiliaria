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
    public class PropiedadControlador
    {
        private PropiedadServicio propiedadServicio;

        public PropiedadControlador()
        {
            propiedadServicio = new PropiedadServicio();
        }

        public bool InsertarPropiedad(PropiedadVistaModelo propiedadVistaModelo)
        {
            PROPIEDAD propiedad = new PROPIEDAD();
            try
            {
                propiedad.IDPROVINCIA = propiedadVistaModelo.IdProvincia;
                propiedad.IDTIPOPROPIEDAD = propiedadVistaModelo.IdTipoPropiedad;
                propiedad.CALLEPRINCIPAL = propiedadVistaModelo.CallePrincipal;
                propiedad.CALLESECUNDARIA = propiedadVistaModelo.CalleSecundaria;
                propiedad.PRECIO = propiedadVistaModelo.Precio;
                propiedad.ESTADOPROPIEDAD = propiedadVistaModelo.EstadoPropiedad;
                propiedad.FECHAREGISTROPROPIEDAD = propiedadVistaModelo.FechaRegistroPropiedad;
                propiedad.FOTOPRINCIPAL = propiedadVistaModelo.FotoPrincipal;
                propiedadServicio.InsertarPropiedad(propiedad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarPropiedad(PropiedadVistaModelo propiedadVistaModelo)
        {
            PROPIEDAD propiedad = new PROPIEDAD();
            try
            {
                propiedad.IDPROVINCIA = propiedadVistaModelo.IdProvincia;
                propiedad.IDTIPOPROPIEDAD = propiedadVistaModelo.IdTipoPropiedad;
                propiedad.CALLEPRINCIPAL = propiedadVistaModelo.CallePrincipal;
                propiedad.CALLESECUNDARIA = propiedadVistaModelo.CalleSecundaria;
                propiedad.PRECIO = propiedadVistaModelo.Precio;
                propiedad.ESTADOPROPIEDAD = propiedadVistaModelo.EstadoPropiedad;
                propiedad.FECHAREGISTROPROPIEDAD = propiedadVistaModelo.FechaRegistroPropiedad;
                propiedad.FOTOPRINCIPAL = propiedadVistaModelo.FotoPrincipal;
                propiedadServicio.ModificarPropiedad(propiedad);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<PropiedadVistaModelo> GetPropiedadAll()
        {
            var propiedadList = propiedadServicio.ListarPropiedad();
            List<PropiedadVistaModelo> vistaModelos = new List<PropiedadVistaModelo>();

            foreach (PROPIEDAD item in propiedadList)
            {
                vistaModelos.Add(new PropiedadVistaModelo
                {
                    IdPropiedad = item.IDPROPIEDAD,
                    IdCaracteristica = item.IDCARACTERISTICA,
                    IdProvincia = item.IDPROVINCIA,
                    IdTipoPropiedad = item.IDTIPOPROPIEDAD,
                    IdPropietario = item.IDPROPIETARIO,
                    IdUsuario = item.IDUSUARIO,
                    Precio = item.PRECIO,
                    EstadoPropiedad = item.ESTADOPROPIEDAD
                });
            }
            return vistaModelos;
        }

        public List<ProvinciaVistaModelo> poblarCboProvincia()
        {
            var proListProvincia = propiedadServicio.poblarCboProvincia();
            List<ProvinciaVistaModelo> vistaModelos = new List<ProvinciaVistaModelo>();

            foreach (PROVINCIA item in proListProvincia)
            {
                vistaModelos.Add(new ProvinciaVistaModelo
                {
                    IdProvincia = item.IDPROVINCIA,
                    NombreProvincia = item.NOMBREPROVINCIA
                });
            }
            return vistaModelos;
        }

        public List<CantonVistaModelo> poblarCboCanton(int id)
        {
            var proListCanton = propiedadServicio.poblarCboCanton(id);
            List<CantonVistaModelo> vistaModelos = new List<CantonVistaModelo>();

            foreach (CANTON item in proListCanton)
            {
                vistaModelos.Add(new CantonVistaModelo
                {
                    IdCanton = item.IDCANTON,
                    NombreCanton = item.NOMBRECANTON
                });
            }
            return vistaModelos;
        }

        public List<ParroquiaVistaModelo> poblarCboParroquia(int idCa)
        {
            var proListParroquia = propiedadServicio.poblarCboParroquia(idCa);
            List<ParroquiaVistaModelo> vistaModelos = new List<ParroquiaVistaModelo>();

            foreach (PARROQUIA item in proListParroquia)
            {
                vistaModelos.Add(new ParroquiaVistaModelo
                {
                    IdParroquia = item.IDPARROQUIA,
                    NombreParroquia = item.NOMBREPARROQUIA
                });
            }
            return vistaModelos;
        }

        public List<BarrioVistaModelo> poblarCboBarrio(int idPar)
        {
            var proListBarrio = propiedadServicio.poblarCboBarrio(idPar);
            List<BarrioVistaModelo> vistaModelos = new List<BarrioVistaModelo>();

            foreach (BARRIO item in proListBarrio)
            {
                vistaModelos.Add(new BarrioVistaModelo
                {
                    IdBarrio = item.IDBARRIO,
                    Barrio1 = item.NOMBREBARRIO
                });
            }
            return vistaModelos;
        }

        public List<TipoPropiedadVistaModelo> poblarCboTipoPropiedad()
        {
            var proListTipoPropiedad = propiedadServicio.poblarCboTipoPropiedad();
            List<TipoPropiedadVistaModelo> vistaModelos = new List<TipoPropiedadVistaModelo>();

            foreach (TIPO_PROPIEDAD item in proListTipoPropiedad)
            {
                vistaModelos.Add(new TipoPropiedadVistaModelo
                {
                    IdTipoPropiedad = item.IDTIPOPROPIEDAD,
                    NombreTipoPropiedad = item.NOMBRETIPOPROPIEDAD
                });
            }
            return vistaModelos;
        }
    }
}

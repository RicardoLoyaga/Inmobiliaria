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
    public class ClienteControlador
    {
        private ClienteServicio clienteServicio;

        public ClienteControlador()
        {
            clienteServicio = new ClienteServicio();
        }

        public bool InsertarCliente(ClienteVistaModelo clienteVistaModelo)
        {
            CLIENTE cliente = new CLIENTE();
            try
            {
                cliente.NOMBRECLIENTE = clienteVistaModelo.NombreCliente;
                cliente.IDENTIFICACIONCLIENTE = clienteVistaModelo.IdentificacionCliente;
                cliente.DIRECCIONCLIENTE = clienteVistaModelo.DireccionCliente;
                cliente.CELULARCLIENTE = clienteVistaModelo.CelularCliente;
                cliente.CORREOCLIENTE = clienteVistaModelo.CorreoCliente;
                cliente.ASESOR = clienteVistaModelo.Asesor;
                cliente.ESTADOCLIENTE = clienteVistaModelo.EstadoCliente;
                clienteServicio.InsertarCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarCliente(ClienteVistaModelo clienteVistaModelo)
        {
            CLIENTE cliente = new CLIENTE();
            try
            {
                cliente.IDCLIENTE = clienteVistaModelo.IdCliente;
                cliente.NOMBRECLIENTE = clienteVistaModelo.NombreCliente;
                cliente.DIRECCIONCLIENTE = clienteVistaModelo.DireccionCliente;
                cliente.CELULARCLIENTE = clienteVistaModelo.CelularCliente;
                cliente.CORREOCLIENTE = clienteVistaModelo.CorreoCliente;
                cliente.ESTADOCLIENTE = clienteVistaModelo.EstadoCliente;
                clienteServicio.ModificarCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<ClienteVistaModelo> GetClienteAll()
        {
            var clienteList = clienteServicio.ListarCliente();
            List<ClienteVistaModelo> vistaModelos = new List<ClienteVistaModelo>();

            foreach (CLIENTE item in clienteList)
            {
                vistaModelos.Add(new ClienteVistaModelo
                {
                    IdCliente = item.IDCLIENTE,
                    IdentificacionCliente = item.IDENTIFICACIONCLIENTE,
                    NombreCliente = item.NOMBRECLIENTE,
                    DireccionCliente = item.DIRECCIONCLIENTE,
                    CelularCliente = item.CELULARCLIENTE,
                    CorreoCliente = item.CORREOCLIENTE,
                    Asesor = item.ASESOR,
                    EstadoCliente = item.ESTADOCLIENTE
                });
            }
            return vistaModelos;
        }

        public List<UsuarioVistaModelo> poblarCboAsesores()
        {
            var cliListAsesores = clienteServicio.poblarCboAsesores();
            List<UsuarioVistaModelo> usuarioVistaModelos = new List<UsuarioVistaModelo>();

            foreach (USUARIO item in cliListAsesores)
            {
                usuarioVistaModelos.Add(new UsuarioVistaModelo
                {
                    IdUsuario = item.IDUSUARIO,
                    NombreUsuario = item.NOMBREUSUARIO
                });

            }
            return usuarioVistaModelos;
        }
    }
}

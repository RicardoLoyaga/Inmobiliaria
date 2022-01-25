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
                cliente.DIRECCIONCLIENTE = clienteVistaModelo.DireccionCliente;
                cliente.CELULARCLIENTE = clienteVistaModelo.CelularCliente;
                cliente.CORREOCLIENTE = clienteVistaModelo.CorreoCliente;
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
                    NombreCliente = item.NOMBRECLIENTE,
                    DireccionCliente = item.DIRECCIONCLIENTE,
                    CelularCliente = item.CELULARCLIENTE,
                    CorreoCliente = item.CORREOCLIENTE,
                    EstadoCliente = item.ESTADOCLIENTE
                });
            }
            return vistaModelos;
        }
    }
}

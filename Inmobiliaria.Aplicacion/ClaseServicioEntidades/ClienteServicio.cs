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
    public class ClienteServicio
    {
        readonly IClienteRepositorio clienteRepositorio;

        public ClienteServicio()
        {
            clienteRepositorio = new ClienteRepositorio();
        }

        public void InsertarCliente(CLIENTE cliente)
        {
            try
            {
                clienteRepositorio.Add(cliente);
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public void ModificarCliente(CLIENTE cliente)
        {
            clienteRepositorio.Modify(cliente);
        }

        public IEnumerable<CLIENTE> ListarCliente()
        {
            return clienteRepositorio.GetAll();
        }

        public void EliminarCliente(int id)
        {
            clienteRepositorio.Delete(id);
        }
    }
}

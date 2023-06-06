using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class ClienteServicio
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public bool Actualizar(Cliente cliente, out string mensaje)
        {
            return clienteRepositorio.Actualizar(cliente, out mensaje);
        }

        public bool Crear(Cliente cliente, out string mensaje)
        {
            return clienteRepositorio.Crear(cliente, out mensaje);
        }

        public bool Eliminar(int id, out string mensaje)
        {
            return clienteRepositorio.Eliminar(id, out mensaje);
        }

        public List<Cliente> Listar()
        {
            return clienteRepositorio.Listar();
        }
    }
}

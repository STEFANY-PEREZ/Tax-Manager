using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class VehiculoServicio
    {
        private VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();

        public bool Actualizar(Vehiculo vehiculo, out string mensaje)
        {
            return vehiculoRepositorio.Actualizar(vehiculo, out mensaje);
        }

        public bool Crear(Vehiculo vehiculo, out string mensaje)
        {
            return vehiculoRepositorio.Crear(vehiculo, out mensaje);
        }

        public bool Eliminar(int id, out string mensaje)
        {
            return vehiculoRepositorio.Eliminar(id, out mensaje);
        }

        public List<Vehiculo> Listar()
        {
            return vehiculoRepositorio.Listar();
        }
    }
}

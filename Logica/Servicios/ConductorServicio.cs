using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class ServicioServicio
    {
        private ConductorRepositorio conductorRepositorio = new ConductorRepositorio();

        public bool Actualizar(Conductor conductor, out string mensaje)
        {
            return conductorRepositorio.Actualizar(conductor, out mensaje);
        }

        public bool Crear(Conductor conductor, out string mensaje)
        {
            return conductorRepositorio.Crear(conductor, out mensaje);
        }

        public bool Eliminar(int id, out string mensaje)
        {
            return conductorRepositorio.Eliminar(id, out mensaje);
        }

        public List<Conductor> Listar()
        {
            return conductorRepositorio.Listar();
        }
    }
}
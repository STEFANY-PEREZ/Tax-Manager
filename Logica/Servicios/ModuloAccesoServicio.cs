using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;
namespace Logica.Servicios
{
    public class ModuloAccesoServicio
    {
        private readonly ModulosAccesoRepositorio repositorio = new ModulosAccesoRepositorio();

        public List<ModuloAcceso> ListarModulosActivosPorIdUsuario(int id)
        {
            return repositorio.ListarModulosActivosPorIdUsuario(id);
        }
    }
}

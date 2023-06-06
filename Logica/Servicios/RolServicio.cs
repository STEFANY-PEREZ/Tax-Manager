using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class RolServicio
    {
        private RolRepositorio rolRepositorio = new RolRepositorio();

        public List<Rol> Listar()
        {
            return rolRepositorio.Listar();
        }
    }
}

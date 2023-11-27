using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Servicios
{
    public class EncomiendaServicio
    {
        private EncomiendaRepositorio viajesRepositorio = new EncomiendaRepositorio();
        public bool Crear(Encomienda viajes, out string mensaje)
        {
            return viajesRepositorio.Crear(viajes, out mensaje);
        }

        public bool Actualizar(Encomienda viajes, out string mensaje)
        {
            return viajesRepositorio.Actualizar(viajes, out mensaje);
        }

        public bool Eliminar(int id, out string mensaje)
        {
            return viajesRepositorio.Eliminar(id, out mensaje);
        }

        public List<Encomienda> Listar()
        {
            return viajesRepositorio.Listar();
        }
    }
}

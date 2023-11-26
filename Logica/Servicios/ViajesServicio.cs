using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Servicios
{
    public class ViajesServicio
    {
        private ViajesRepositorio viajesRepositorio = new ViajesRepositorio();
        public bool Crear(PedidoEncomienda viajes, out string mensaje)
        {
            return viajesRepositorio.Crear(viajes, out mensaje);
        }

        public bool Actualizar(PedidoEncomienda viajes, out string mensaje)
        {
            return viajesRepositorio.Actualizar(viajes, out mensaje);
        }

        public bool Eliminar(int id, out string mensaje)
        {
            return viajesRepositorio.Eliminar(id, out mensaje);
        }

        public List<PedidoEncomienda> Listar()
        {
            return viajesRepositorio.Listar();
        }
    }
}

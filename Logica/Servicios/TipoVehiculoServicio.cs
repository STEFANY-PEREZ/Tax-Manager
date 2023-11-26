
using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Servicios
{
    public class TipoVehiculoServicio
    {
        private TipoVehiculoRepositorio tipoVehiculoRepositorio = new TipoVehiculoRepositorio();

        public List<TipoVehiculo> Listar()
        {
            return tipoVehiculoRepositorio.Listar();
        }
    }
}

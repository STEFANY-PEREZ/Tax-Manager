using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class TipoEncomiendaServicio
    {
        private TipoEncomiendaRepositorio tipoEncomiendaRepositorio = new TipoEncomiendaRepositorio();

        public List<TipoEncomiendas> Listar()
        {
            return tipoEncomiendaRepositorio.Listar();
        }
    }
}

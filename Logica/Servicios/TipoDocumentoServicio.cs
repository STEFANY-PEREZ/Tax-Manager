using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class TipoDocumentoServicio
    {
        private TipoDocumentoRepositorio tipoDocumentoRepositorio = new TipoDocumentoRepositorio();

        public List<TipoDocumento> Listar()
        {
            return tipoDocumentoRepositorio.Listar();
        }
    }
}

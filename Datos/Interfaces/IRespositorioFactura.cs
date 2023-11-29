using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IRespositorioFactura <T> where T : class
    {
        bool Crear(T servicio);

        void GenerarFacturaPdf(Servicio servicioSeleccionado);

        List<T> Listar();

        bool Eliminar(int id, out string mensaje);
    }
}

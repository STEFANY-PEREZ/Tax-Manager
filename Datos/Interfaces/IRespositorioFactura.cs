using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IRespositorioFactura <T> where T : class
    {
        bool Crear(T entidad);
    }
}

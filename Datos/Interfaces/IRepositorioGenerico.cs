using System.Collections.Generic;

namespace Datos.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        bool Crear(T entidad, out string mensaje);

        bool Actualizar(T entidad, out string mensaje);

        bool Eliminar(int id, out string mensaje);

        List<T> Listar();
    }
}

using System.Collections.Generic;

namespace Datos.Interfaces
{
    public interface IRepositorioListar<T> where T : class
    {
        List<T> Listar();
    }
}

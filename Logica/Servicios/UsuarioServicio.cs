using Datos.Repositorios;
using Entidad;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class UsuarioServicio
    {
        private readonly UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public bool Actualizar(Usuario usuario, out string mensaje)
        {
            return usuarioRepositorio.Actualizar(usuario, out mensaje);
        }

        public bool Crear(Usuario usuario, out string mensaje)
        {
            return usuarioRepositorio.Crear(usuario, out mensaje);
        }

        public bool Eliminar(int id, out string mensaje)
        {
            return usuarioRepositorio.Eliminar(id, out mensaje);
        }

        public List<Usuario> Listar()
        {
            return usuarioRepositorio.Listar();
        }
    }
}

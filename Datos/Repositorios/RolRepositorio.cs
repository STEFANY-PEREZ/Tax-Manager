using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class RolRepositorio : IRepositorioListar<Rol>
    {
        public List<Rol> Listar()
        {
            List<Rol> roles = new List<Rol>();

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                connection.Open();

                string query = "SELECT IdRol, Nombre, Estado FROM VistaRolesActivos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rol rol = new Rol
                            {
                                Id = (int)reader["IdRol"],
                                Nombre = (string)reader["Nombre"],
                                Estado = (bool)reader["Estado"]
                            };

                            roles.Add(rol);
                        }
                    }
                }
            }

            return roles;
        }
    }
}

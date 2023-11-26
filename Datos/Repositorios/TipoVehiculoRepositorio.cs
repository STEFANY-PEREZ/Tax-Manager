using Datos.Interfaces;
using Entidad;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class TipoVehiculoRepositorio : IRepositorioListar<TipoVehiculo>
    {
        public List<TipoVehiculo> Listar()
        {
            List<TipoVehiculo> vehiculos = new List<TipoVehiculo>();

            using (SqlConnection connection = new SqlConnection(Conexiones.Conexion.CadenaConexionMaestra))
            {
                connection.Open();

                string query = "SELECT Id, Nmbre, Estado FROM VistaTipoVehiculo";

                using (SqlCommand command = new SqlCommand(query, connection)) 
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoVehiculo tipoVehiculo = new TipoVehiculo()
                            {
                                Id = (int)reader["Id"],
                                Nombre = (string)reader["Nmbre"],
                                Estado = (bool)reader["Estado"]
                            };
                            vehiculos.Add(tipoVehiculo);
                        }
                    }
                }
            }
            return vehiculos;
        }
    }
}

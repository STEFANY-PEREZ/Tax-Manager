using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class TipoDocumentoRepositorio : IRepositorioListar<TipoDocumento>
    {
        public List<TipoDocumento> Listar()
        {
            List<TipoDocumento> listaTiposDocumento = new List<TipoDocumento>();

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                connection.Open();

                string query = "SELECT IdTipoDocumento, Nombre, Estado FROM VistaTiposDocumentoActivos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoDocumento tipoDocumento = new TipoDocumento
                            {
                                Id = (int)reader["IdTipoDocumento"],
                                Nombre = (string)reader["Nombre"],
                                Estado = (bool)reader["Estado"]
                            };

                            listaTiposDocumento.Add(tipoDocumento);
                        }
                    }
                }
            }

            return listaTiposDocumento;
        }
    }
}

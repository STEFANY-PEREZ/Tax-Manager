using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class TipoEncomiendaRepositorio : IRepositorioListar<TipoEncomiendas>
    {
        public List<TipoEncomiendas> Listar()
        {
            List<TipoEncomiendas> listaTiposEncomiendas = new List<TipoEncomiendas>();

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                connection.Open();

                string query = "SELECT IdEncomienda, Nombre, Estado FROM VistaEncomiendasActivas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoEncomiendas encomiendas = new TipoEncomiendas
                            {
                                IdEncomienda = (int)reader["IdEncomienda"],
                                Nombre = (string)reader["Nombre"],
                                Estado = (bool)reader["Estado"]
                            };

                            listaTiposEncomiendas.Add(encomiendas);
                        }
                    }
                }
            }

            return listaTiposEncomiendas;
        }
    }
}

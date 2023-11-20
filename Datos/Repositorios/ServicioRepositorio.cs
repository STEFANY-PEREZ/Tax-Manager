using Datos.Conexiones;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class ServicioRepositorio
    {
        public bool Crear(Servicio servicio)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("CrearServicio", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    command.Parameters.AddWithValue("@IdCliente", servicio.Cliente.Id);
                    command.Parameters.AddWithValue("@IdConductor", servicio.Conductor.Id);
                    command.Parameters.AddWithValue("@DireccionOrigen", servicio.DireccionOrigen);
                    command.Parameters.AddWithValue("@DireccionDestino", servicio.DireccionDestino);
                    command.Parameters.AddWithValue("@Tarifa", servicio.Tarifa);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al crear el servicio: " + ex.Message);
                return false;
            }
        }

        public List<Servicio> Listar()
        {
            List<Servicio> servicios = new List<Servicio>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    string query = "SELECT * FROM VistaServicios";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Servicio servicio = new Servicio();
                            servicio.Id = Convert.ToInt32(reader["IdServicio"]);

                            Cliente cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(reader["IdCliente"]);

                            Conductor conductor = new Conductor();
                            conductor.Id = Convert.ToInt32(reader["IdConductor"]);

                            servicio.DireccionOrigen = reader["DireccionOrigen"].ToString();
                            servicio.DireccionDestino = reader["DireccionDestino"].ToString();
                            servicio.Tarifa = Convert.ToDecimal(reader["Tarifa"]);
                            servicio.Estado = Convert.ToBoolean(reader["Estado"]);
                            servicio.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);

                            servicio.Cliente = cliente;
                            servicio.Conductor = conductor;

                            servicios.Add(servicio);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                servicios = new List<Servicio>();
                throw ex;
            }

            return servicios;
        }
    }
}

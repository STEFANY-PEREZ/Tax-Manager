using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class VehiculoRepositorio : IRepositorioGenerico<Vehiculo>
    {
        public bool Actualizar(Vehiculo entidad, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    SqlCommand command = new SqlCommand("ActualizarVehiculo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdVehiculo", entidad.Id);
                    command.Parameters.AddWithValue("@Marca", entidad.Marca);
                    command.Parameters.AddWithValue("@Modelo", entidad.Modelo);
                    command.Parameters.AddWithValue("@Año", entidad.Año.ToString());
                    command.Parameters.AddWithValue("@Placa", entidad.Placa);

                    SqlParameter resultadoParameter = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultadoParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(resultadoParameter);

                    SqlParameter mensajeParameter = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    mensajeParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(mensajeParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    int resultadoSP = Convert.ToInt32(command.Parameters["@Resultado"].Value);
                    mensaje = command.Parameters["@Mensaje"].Value.ToString();

                    if (resultadoSP > 0)
                        resultado = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el vehículo. Por favor, inténtelo nuevamente.";
                throw ex;
            }

            return resultado;
        }

        public bool Crear(Vehiculo entidad, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    SqlCommand command = new SqlCommand("CrearVehiculo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdConductor", entidad.Conductor.Id);
                    command.Parameters.AddWithValue("@Marca", entidad.Marca);
                    command.Parameters.AddWithValue("@Modelo", entidad.Modelo);
                    command.Parameters.AddWithValue("@Año", entidad.Año.ToString());
                    command.Parameters.AddWithValue("@Placa", entidad.Placa);

                    SqlParameter resultadoParameter = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultadoParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(resultadoParameter);

                    SqlParameter mensajeParameter = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    mensajeParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(mensajeParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    int resultadoSP = Convert.ToInt32(command.Parameters["@Resultado"].Value);
                    mensaje = command.Parameters["@Mensaje"].Value.ToString();

                    if (resultadoSP > 0)
                        resultado = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al crear el vehículo. Por favor, inténtelo nuevamente.";
                throw ex;
            }

            return resultado;
        }

        public bool Eliminar(int id, out string mensaje)
        {
            bool exito = false;
            mensaje = "";

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                try
                {
                    connection.Open();

                    // Crear el comando para invocar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("EliminarVehiculo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.AddWithValue("@IdVehiculo", id);

                        // Parámetros de salida
                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int);
                        resultadoParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultadoParam);

                        SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                        mensajeParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(mensajeParam);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();

                        // Obtener los valores de los parámetros de salida
                        int resultado = Convert.ToInt32(resultadoParam.Value);
                        mensaje = Convert.ToString(mensajeParam.Value);

                        if (resultado == 1)
                        {
                            exito = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones si es necesario
                    mensaje = "Error al eliminar el vehiculo. " + ex.Message;
                }
            }

            return exito;
        }

        public List<Vehiculo> Listar()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    string query = "SELECT * FROM VistaVehiculosActivos";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vehiculo vehiculo = new Vehiculo();
                            vehiculo.Id = Convert.ToInt32(reader["IdVehiculo"]);
                            vehiculo.Marca = reader["Marca"].ToString();
                            vehiculo.Modelo = reader["Modelo"].ToString();
                            vehiculo.Placa = reader["Placa"].ToString();
                            vehiculo.Año = Convert.ToInt32(reader["Año"]);
                            vehiculo.Estado = Convert.ToBoolean(reader["Estado"]);
                            vehiculo.FechaCreacion = Convert.ToDateTime(reader["FechaCreacionVehiculo"]);

                            Conductor conductor = new Conductor();
                            conductor.Id = Convert.ToInt32(reader["IdConductor"]);
                            conductor.Estado = Convert.ToBoolean(reader["Estado"]);
                            //conductor.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);

                            Persona persona = new Persona();
                            persona.Id = Convert.ToInt32(reader["IdPersona"]);
                            persona.Nombre = reader["Nombre"].ToString();
                            persona.Apellido = reader["Apellido"].ToString();
                            persona.NumeroDocumento = reader["NumeroDocumento"].ToString();
                            persona.Telefono = reader["Telefono"].ToString();
                            persona.Direccion = reader["Direccion"].ToString();
                            persona.FechaCreacion = Convert.ToDateTime(reader["FechaCreacionPersona"]);

                            TipoDocumento tipoDocumento = new TipoDocumento();
                            tipoDocumento.Id = Convert.ToInt32(reader["IdTipoDocumento"]);
                            tipoDocumento.Nombre = reader["TipoDocumento"].ToString();

                            persona.TipoDocumento = tipoDocumento;
                            conductor.Persona = persona;
                            vehiculo.Conductor = conductor;

                            vehiculos.Add(vehiculo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                vehiculos = new List<Vehiculo>();
                throw ex;
            }

            return vehiculos;
        }
    }
}

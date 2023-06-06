using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Datos.Repositorios
{
    public class ConductorRepositorio : IRepositorioGenerico<Conductor>
    {
        public bool Actualizar(Conductor conductor, out string mensaje)
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
                    using (SqlCommand command = new SqlCommand("ActualizarConductor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@IdConductor", conductor.Id);
                        command.Parameters.AddWithValue("@Nombre", conductor.Persona.Nombre);
                        command.Parameters.AddWithValue("@Apellido", conductor.Persona.Apellido);
                        command.Parameters.AddWithValue("@NumeroDocumento", conductor.Persona.NumeroDocumento);
                        command.Parameters.AddWithValue("@Telefono", conductor.Persona.Telefono);
                        command.Parameters.AddWithValue("@Direccion", conductor.Persona.Direccion);
                        command.Parameters.AddWithValue("@IdTipoDocumento", conductor.Persona.TipoDocumento.Id);

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
                    mensaje = "Error al actualizar el conductor. " + ex.Message;
                }
            }

            return exito;
        }

        public bool Crear(Conductor conductor, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                try
                {
                    connection.Open();

                    // Crear el comando para invocar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("CrearConductor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@Nombre", conductor.Persona.Nombre);
                        command.Parameters.AddWithValue("@Apellido", conductor.Persona.Apellido);
                        command.Parameters.AddWithValue("@NumeroDocumento", conductor.Persona.NumeroDocumento);
                        command.Parameters.AddWithValue("@Telefono", conductor.Persona.Telefono);
                        command.Parameters.AddWithValue("@Direccion", conductor.Persona.Direccion);
                        command.Parameters.AddWithValue("@IdTipoDocumento", conductor.Persona.TipoDocumento.Id);

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
                        int exito = Convert.ToInt32(resultadoParam.Value);
                        mensaje = Convert.ToString(mensajeParam.Value);

                        if (exito != 0)
                        {
                            resultado = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones si es necesario
                    mensaje = "Error al crear el conductor. " + ex.Message;
                }
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
                    using (SqlCommand command = new SqlCommand("EliminarConductor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.AddWithValue("@IdConductor", id);

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
                    mensaje = "Error al eliminar el cliente. " + ex.Message;
                }
            }

            return exito;
        }

        public List<Conductor> Listar()
        {
            List<Conductor> listaConductores = new List<Conductor>();

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                try
                {
                    connection.Open();

                    // Crear el comando para obtener los datos de la vista
                    using (SqlCommand command = new SqlCommand("SELECT * FROM VistaConductoresActivos", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Conductor conductor = new Conductor();
                                Persona persona = new Persona();
                                conductor.Id = Convert.ToInt32(reader["IdConductor"]);
                                persona.Id = Convert.ToInt32(reader["IdPersona"]);
                                persona.Nombre = reader["Nombre"].ToString();
                                persona.Apellido = reader["Apellido"].ToString();
                                persona.NumeroDocumento = reader["NumeroDocumento"].ToString();
                                persona.Telefono = reader["Telefono"].ToString();
                                persona.Direccion = reader["Direccion"].ToString();
                                conductor.Estado = Convert.ToBoolean(reader["Estado"]);

                                TipoDocumento tipoDocumento = new TipoDocumento();
                                tipoDocumento.Id = Convert.ToInt32(reader["IdTipoDocumento"]);
                                tipoDocumento.Nombre = reader["TipoDocumento"].ToString();
                                conductor.Persona = persona;
                                conductor.Persona.TipoDocumento = tipoDocumento;
                                
                                listaConductores.Add(conductor);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones si es necesario
                    Console.WriteLine("Error al listar los clientes. " + ex.Message);
                }
            }

            return listaConductores;
        }
    }
}

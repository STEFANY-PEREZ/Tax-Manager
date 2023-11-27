using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class ClienteRepositorio : IRepositorioGenerico<Cliente>
    {
        public bool Actualizar(Cliente cliente, out string mensaje)
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
                    using (SqlCommand command = new SqlCommand("ActualizarCliente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@IdCliente", cliente.Id);
                        command.Parameters.AddWithValue("@Nombre", cliente.Persona.Nombre);
                        command.Parameters.AddWithValue("@Apellido", cliente.Persona.Apellido);
                        command.Parameters.AddWithValue("@NumeroDocumento", cliente.Persona.NumeroDocumento);
                        command.Parameters.AddWithValue("@Telefono", cliente.Persona.Telefono);
                        command.Parameters.AddWithValue("@Direccion", cliente.Persona.Direccion);
                        command.Parameters.AddWithValue("@IdTipoDocumento", cliente.Persona.TipoDocumento.Id);

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
                    mensaje = "Error al actualizar el cliente. " + ex.Message;
                }
            }

            return exito;
        }

        public bool Crear(Cliente cliente, out string mensaje)
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
                    using (SqlCommand command = new SqlCommand("CrearCliente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@Nombre", cliente.Persona.Nombre);
                        command.Parameters.AddWithValue("@Apellido", cliente.Persona.Apellido);
                        command.Parameters.AddWithValue("@NumeroDocumento", cliente.Persona.NumeroDocumento);
                        command.Parameters.AddWithValue("@Telefono", cliente.Persona.Telefono);
                        command.Parameters.AddWithValue("@Direccion", cliente.Persona.Direccion);
                        command.Parameters.AddWithValue("@IdTipoDocumento", cliente.Persona.TipoDocumento.Id);

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

                            //GenerarFactura(cliente);

                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones si es necesario
                    mensaje = "Error al crear el cliente. " + ex.Message;
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
                    using (SqlCommand command = new SqlCommand("EliminarCliente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.AddWithValue("@IdCliente", id);

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

        public List<Cliente> Listar()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                try
                {
                    connection.Open();

                    // Crear el comando para obtener los datos de la vista
                    using (SqlCommand command = new SqlCommand("SELECT * FROM VistaClientesActivos", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                Persona persona = new Persona();
                                cliente.Id = Convert.ToInt32(reader["IdCliente"]);
                                persona.Id = Convert.ToInt32(reader["IdPersona"]);
                                persona.Nombre = reader["Nombre"].ToString();
                                persona.Apellido = reader["Apellido"].ToString();
                                persona.NumeroDocumento = reader["NumeroDocumento"].ToString();
                                persona.Telefono = reader["Telefono"].ToString();
                                persona.Direccion = reader["Direccion"].ToString();
                                cliente.Estado = Convert.ToBoolean(reader["Estado"]);

                                TipoDocumento tipoDocumento = new TipoDocumento();
                                tipoDocumento.Id = Convert.ToInt32(reader["IdTipoDocumento"]);
                                tipoDocumento.Nombre = reader["TipoDocumento"].ToString();
                                cliente.Persona = persona;
                                cliente.Persona.TipoDocumento = tipoDocumento;
                                listaClientes.Add(cliente);
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

            return listaClientes;
        }
    }
}

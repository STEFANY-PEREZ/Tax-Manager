using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ViajesRepositorio : IRepositorioGenerico<PedidoEncomienda>
    {
        public bool Crear(PedidoEncomienda entidad, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("CrearPedidoEncomienda", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdEncomienda", entidad.IdViaje);
                    command.Parameters.AddWithValue("@DireccionOrigen", entidad.DireccionOrigen);
                    command.Parameters.AddWithValue("@DireccionDestino", entidad.DireccionDestino);
                    command.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                    command.Parameters.AddWithValue("@TipoEncomienda", entidad.Tipo);
                    command.Parameters.AddWithValue("@Valor", entidad.Valor);
                    command.Parameters.AddWithValue("@Contenido", entidad.Contenido);
                    command.Parameters.AddWithValue("@FechaCreacion", entidad.FechaCreacion);
                    command.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    int resultadoSP = Convert.ToInt32(command.Parameters["@Resultado"].Value);
                    mensaje = Convert.ToString(command.Parameters["@Mensaje"].Value);

                    resultado = resultadoSP > 0;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al crear el usuario.\nDetalles: " + ex.Message;
            }
            return resultado;
        }

        public bool Eliminar(int id, out string mensaje)
        {
            bool exito = false;
            mensaje = "";

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                try
                {
                    connection.Open();

                    // Crear el comando para invocar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("EliminarViajes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.AddWithValue("@IdViajes", id);

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
                    mensaje = "Error al intentar eliminar el viaje";
                }
            }
            return exito;
        }

        public List<PedidoEncomienda> Listar()
        {
            List<PedidoEncomienda > encomiendas = new List<PedidoEncomienda>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    string query = "SELECT * FROM VistaPedidoEncomiendasActivas";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoEncomienda encomienda = new PedidoEncomienda();
                            encomienda.IdViaje = Convert.ToInt32(reader["IdVehiculo"]);
                            encomienda.DireccionOrigen = reader["DireccionOrigen"].ToString();
                            encomienda.DireccionDestino = reader["DireccionDestino"].ToString();
                            encomienda.Telefono = reader["Telefono"].ToString();
                            encomienda.Tipo = reader["Tipo"].ToString();
                            encomienda.Valor = Convert.ToDecimal(reader["Valor"]);
                            encomienda.Estado = Convert.ToBoolean(reader["Estado"]);
                            encomienda.Contenido = reader["Contenido"].ToString();
                            encomienda.FechaCreacion = Convert.ToDateTime(reader["FechaCreacionVehiculo"]);

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
                            encomienda.Conductor = conductor;

                            encomiendas.Add(encomienda);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                encomiendas = new List<PedidoEncomienda>();
                throw ex;
            }

            return encomiendas;

        }
        public bool Actualizar(PedidoEncomienda entidad, out string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}

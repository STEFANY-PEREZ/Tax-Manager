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
    public class EncomiendaRepositorio : IRepositorioGenerico<Encomienda>
    {
        public bool Crear(Encomienda entidad, out string mensaje)
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

                    // Ajustar parámetros
                    command.Parameters.AddWithValue("@Identificacion",entidad.Identificacion);
                    command.Parameters.AddWithValue("@DireccionOrigen", entidad.DireccionOrigen);
                    command.Parameters.AddWithValue("@DireccionDestino", entidad.DireccionDestino);
                    command.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                    command.Parameters.AddWithValue("@TipoEncomienda", entidad.Tipo);
                    command.Parameters.AddWithValue("@Valor", entidad.Valor);
                    command.Parameters.AddWithValue("@Contenido", entidad.Contenido);
                    command.Parameters.AddWithValue("@FechaCreacion", entidad.FechaCreacion);
                    command.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

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

        public List<Encomienda> Listar()
        {
            List<Encomienda > encomiendas = new List<Encomienda>();

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
                            Encomienda encomienda = new Encomienda();
                            encomienda.IdViaje = Convert.ToInt32(reader["IdEncomienda"]);
                            encomienda.Identificacion = Convert.ToInt32(reader["Identificacion"]);
                            encomienda.DireccionOrigen = reader["DireccionOrigen"].ToString();
                            encomienda.DireccionDestino = reader["DireccionDestino"].ToString();
                            encomienda.Telefono = reader["Telefono"].ToString();
                            encomienda.Valor = Convert.ToDecimal(reader["Valor"]);
                            encomienda.Tipo = reader["TipoEncomienda"].ToString();
                            encomienda.Contenido = reader["Contenido"].ToString();
                            encomienda.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);

                            encomiendas.Add(encomienda);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                encomiendas = new List<Encomienda>();
                throw ex;
            }

            return encomiendas;

        }
        public bool Actualizar(Encomienda entidad, out string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}

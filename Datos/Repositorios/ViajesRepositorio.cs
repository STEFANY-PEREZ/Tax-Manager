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
    public class ViajesRepositorio : IRepositorioGenerico<Viajes>
    {
        public bool Crear(Viajes entidad, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    SqlCommand command = new SqlCommand("CrearViajes", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdViajes", entidad.Id);
                    command.Parameters.AddWithValue("Conductor", entidad.Conductor);
                    command.Parameters.AddWithValue("@DirrecionOrigen", entidad.DireccionOrigen);
                    command.Parameters.AddWithValue("@DIreccionDestino", entidad.DireccionDestino);
                    command.Parameters.AddWithValue("@Telefono", entidad.Telefono.ToString());
                    command.Parameters.AddWithValue("@CupoSolicitado", entidad.CupoSolicitado.ToString());
                    command.Parameters.AddWithValue("@Encomienda", entidad.Encomienda);

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
                mensaje = "Error al Guardar el Viaje. Por favor, inténtelo nuevamente.";
                throw ex;
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

        public List<Viajes> Listar()
        {
            throw new NotImplementedException();
        }
        public bool Actualizar(Viajes entidad, out string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}

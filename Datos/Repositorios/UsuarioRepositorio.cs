using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        public bool Actualizar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ActualizarUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@IdUsuario", usuario.Id);
                        command.Parameters.AddWithValue("@Nombre", usuario.Persona.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.Persona.Apellido);
                        command.Parameters.AddWithValue("@NumeroDocumento", usuario.Persona.NumeroDocumento);
                        command.Parameters.AddWithValue("@Telefono", usuario.Persona.Telefono);
                        command.Parameters.AddWithValue("@Direccion", usuario.Persona.Direccion);
                        command.Parameters.AddWithValue("@IdTipoDocumento", usuario.Persona.TipoDocumento.Id);
                        command.Parameters.AddWithValue("@NombreUsuario", usuario.Nombre);
                        command.Parameters.AddWithValue("@Clave", usuario.Contraseña);
                        command.Parameters.AddWithValue("@IdRol", usuario.Rol.Id);

                        // Parámetros de salida
                        command.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();

                        int resultadoSP = Convert.ToInt32(command.Parameters["@Resultado"].Value);
                        mensaje = Convert.ToString(command.Parameters["@Mensaje"].Value);

                        resultado = resultadoSP > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el usuario.\nDetalles: " + ex.Message;
            }

            return resultado;
        }

        public bool Crear(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("CrearUsuario", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nombre", usuario.Persona.Nombre);
                    command.Parameters.AddWithValue("@Apellido", usuario.Persona.Apellido);
                    command.Parameters.AddWithValue("@NumeroDocumento", usuario.Persona.NumeroDocumento);
                    command.Parameters.AddWithValue("@Telefono", usuario.Persona.Telefono);
                    command.Parameters.AddWithValue("@Direccion", usuario.Persona.Direccion);
                    command.Parameters.AddWithValue("@IdRol", usuario.Rol.Id);
                    command.Parameters.AddWithValue("@IdTipoDocumento", usuario.Persona.TipoDocumento.Id);
                    command.Parameters.AddWithValue("@NombreUsuario", usuario.Nombre);
                    command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
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

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
            {
                try
                {
                    connection.Open();

                    // Crear el comando para invocar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("EliminarUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.AddWithValue("@IdUsuario", id);

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
                    mensaje = "Error al eliminar el usuario. " + ex.Message;
                }
            }

            return exito;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexionMaestra))
                {
                    string query = "SELECT * FROM VistaUsuariosActivos";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["IdUsuario"]);
                        usuario.Nombre = reader["NombreUsuario"].ToString();
                        usuario.Contraseña = reader["Contraseña"].ToString();
                        usuario.Estado = Convert.ToBoolean(reader["Estado"]);
                        usuario.FechaCreacion = Convert.ToDateTime(reader["FechaCreacionUsuario"]);

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

                        Rol rol = new Rol();
                        rol.Id = Convert.ToInt32(reader["IdRol"]);
                        rol.Nombre = reader["Rol"].ToString();

                        persona.TipoDocumento = tipoDocumento;
                        usuario.Persona = persona;
                        usuario.Rol = rol;

                        usuarios.Add(usuario);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                usuarios = new List<Usuario>();
                throw ex;
            }

            return usuarios;
        }
    }
}

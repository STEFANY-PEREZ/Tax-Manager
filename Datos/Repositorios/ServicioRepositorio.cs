﻿using Datos.Conexiones;
using Datos.Interfaces;
using Entidad;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos.Repositorios
{
    public class ServicioRepositorio : IRespositorioFactura<Servicio>
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

        public void GenerarFacturaPdf(Servicio servicioSeleccionado)
        {
            try
            {
                if (servicioSeleccionado != null)
                {
                    string pdfPath = $"C:/Users/NosRey/Documents/Visual Studio 2022/pdf/Factura_{servicioSeleccionado.Id}.pdf";

                    using (PdfDocument document = new PdfDocument())
                    {
                        PdfPage page = document.AddPage();

                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        XFont fontTitulo = new XFont("Arial", 16, XFontStyle.Bold);
                        XFont fontNormal = new XFont("Arial", 12, XFontStyle.Regular);

                        XPoint point = new XPoint(30, 30);

                        float columnWidth = 300;

                        DibujarCelda(gfx, "TAX-SERVICES", point, fontTitulo, XBrushes.Black, columnWidth);
                        point.Y += 30;

                        DibujarCelda(gfx, "TICKET DE SERVICIO", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"ID Servicio: {servicioSeleccionado.Id}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Cliente: {servicioSeleccionado.Cliente.Id}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Conductor: {servicioSeleccionado.Conductor.Id}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Dirección Origen: {servicioSeleccionado.DireccionOrigen}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Dirección Destino: {servicioSeleccionado.DireccionDestino}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Tarifa: {servicioSeleccionado.Tarifa:C}", point, fontNormal, XBrushes.Black, columnWidth);

                        document.Save(pdfPath);

                        MessageBox.Show($"Factura generada con éxito. Ruta: {pdfPath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún servicio para generar la factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        public void DibujarCelda(XGraphics gfx, string texto, XPoint point, XFont font, XBrush brush, float width)
        {
            gfx.DrawRectangle(XBrushes.Transparent, point.X, point.Y, width, 20);
            gfx.DrawString(texto, font, brush, new XRect(point.X, point.Y, width, 20), XStringFormats.TopLeft);

            point.X += width;
        }
    }
}

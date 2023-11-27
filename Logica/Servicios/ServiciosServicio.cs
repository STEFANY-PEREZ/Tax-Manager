using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Windows.Forms;

namespace Logica.Servicios
{
    public class ServiciosServicio
    {
        private readonly ServicioRepositorio servicioRepositorio = new ServicioRepositorio();
       

        public bool Crear(Servicio servicio)
        {
            return servicioRepositorio.Crear(servicio);
        }

    

        public List<Servicio> Listar()
        {
            return servicioRepositorio.Listar();
        }
    }
}

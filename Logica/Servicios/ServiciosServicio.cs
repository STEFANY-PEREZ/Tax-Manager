using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;

namespace Logica.Servicios
{
    public class ServiciosServicio
    {
        private readonly ServicioRepositorio servicioRepositorio = new ServicioRepositorio();

        public bool Crear(Servicio servicio)
        {
            return servicioRepositorio.Crear(servicio);
        }

        public void GenerarFacturaPDF(Servicio servicioSeleccionado)
        {
            throw new NotImplementedException();
        }

        public List<Servicio> Listar()
        {
            return servicioRepositorio.Listar();
        }
    }
}

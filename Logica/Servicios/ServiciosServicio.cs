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

        public void GenerarFacturaPdf(Servicio servicioSeleccionado)
        {
            servicioRepositorio.GenerarFacturaPdf(servicioSeleccionado);
        }

        public List<Servicio> Listar()
        {
            return servicioRepositorio.Listar();
        }
        public bool Eliminar(int id, out string mensaje)
        {
            return servicioRepositorio.Eliminar(id, out mensaje);
        }
        
    }
}

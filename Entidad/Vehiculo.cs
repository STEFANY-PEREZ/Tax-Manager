using System;

namespace Entidad
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public Conductor Conductor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public TipoVehiculo Tipo { get; set; }
        public int Cupo { get; set; }
        public int Año { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}

using System;

namespace Entidad
{
    public class Servicio
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Conductor Conductor { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public decimal Tarifa { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}

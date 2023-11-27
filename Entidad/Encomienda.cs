using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Encomienda
    {
        public int IdViaje { get; set; }
        public Conductor Conductor { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public TipoEncomiendas tipoEncomiendas { get; set; }
        public string Identificacion { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Estado { get; set; }
    }
}

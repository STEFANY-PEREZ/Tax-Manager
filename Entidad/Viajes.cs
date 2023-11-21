using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Viajes
    {
        public int Id { get; set; }
        public Conductor Conductor { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public int Telefono { get; set; }
        public int CupoSolicitado { get; set; }
        public Encomienda Encomienda { get; set; }
        public bool Estado { get; set; }
    }
}

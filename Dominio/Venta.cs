using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int Codigo { get; set; }
        public string Dni { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoDePago { get; set; }
        public decimal Precio { get; set; }
    }
}

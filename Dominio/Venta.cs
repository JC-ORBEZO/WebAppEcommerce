using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Venta
    {
        public int codigo { get; set; }
        public string dni { get; set; }
        public DateTime fecha { get; set; }
        public int tipoDePago { get; set; }
        public double precio { get; set; }
        Venta()
        {            
            precio = 0;
        }
    }
}

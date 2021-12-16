using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Detalle
    {
        public int CodigoVenta { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    }
}

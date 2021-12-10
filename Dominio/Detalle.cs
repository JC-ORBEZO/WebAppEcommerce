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
        public float Precio { get; set; }
    }
}

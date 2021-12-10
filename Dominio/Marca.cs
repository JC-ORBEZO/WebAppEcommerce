using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int id_Marca { get; set; }
        public string descripcion_Marca { get; set; }
        public override string ToString()
        {
            return descripcion_Marca;
        }
    }
}

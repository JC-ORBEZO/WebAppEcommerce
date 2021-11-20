using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        //public Marca marca { get; set; }
        //public string descripcionMarca { get; set; }
        //public Categoria categoria { get; set; }
        //public string descripcionCategoria { get; set; }
        public string Url { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public int limiteStock { get; set; }
        public string urlImagen { get; set; }
        public bool activo { get; set; }
    }
}

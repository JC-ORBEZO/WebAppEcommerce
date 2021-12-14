using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Ecommerce
{
    public partial class Ventas : System.Web.UI.Page
    {
        public List<Venta> listaVenta = new List<Venta>();
        public VentaNegocio extra = new VentaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            Venta Nuevo = new Venta();
            Nuevo.Dni = "111";
            Nuevo.TipoDePago = 1;
            Nuevo.Precio = 1750;
            extra.AgregarVenta(Nuevo);
            //TRAER LISTA
            listaVenta = extra.Listar();
        }
    }
}
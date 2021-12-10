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
    public partial class Articulos : System.Web.UI.Page
    {
        public int contenedor { get; set; }
        public List<Articulo> listaDeCarrito { get; set; }
        public List<Articulo> listaOficialCarrito { get; set; }
        public ArticuloNegocio listaBD = new ArticuloNegocio();
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            listaArticulos = listaBD.listar();
            listaOficialCarrito= (List<Articulo>)Session["carritoCompra"];
            if (listaOficialCarrito == null)
            {
                listaOficialCarrito = new List<Articulo>();
            }
            agregarAlCarrito();
        }

        protected void AgregarCarrito_Click(object sender, EventArgs e)
        {
                        
        }

        private void agregarAlCarrito()
        {
            int contenedor1;
            if (Request.QueryString["contador"] != null)
            { 
            contenedor1 = int.Parse(Request.QueryString["contador"].ToString());
            listaOficialCarrito.Add(listaArticulos[contenedor1 - 1]);
            Session.Add("carritoCompra", listaOficialCarrito);
            Response.Redirect("Articulos.aspx");
            }
        }
    }
}
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
    public partial class Default : System.Web.UI.Page
    {
        public int id { get; set; }
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio reg = new ArticuloNegocio();
            ListaArticulos = reg.listar();
        }

        protected void Detalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle.aspx?id=",false);
        }
    }
}
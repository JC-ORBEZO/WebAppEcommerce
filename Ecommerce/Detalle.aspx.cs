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
    public partial class Detalle : System.Web.UI.Page
    {
        public string recibi;
        public List<Articulo> nuevaLista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio extra = new ArticuloNegocio();
            nuevaLista = extra.listar();
            recibi= Request.QueryString["identificador"].ToString();
        }
    }
}
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
    public partial class Acceso : System.Web.UI.Page
    {
        public List<Cliente> listaClientes = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteNegocio listaBD = new ClienteNegocio();
            listaClientes = listaBD.Listar();
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            foreach (var item in listaClientes)
            {
                if (Usuario.Text == item.email && Password.Text == item.password)
                {
                    Session.Add("usuario", item.dni);
                    Session.Add("password", item.password);
                    Mensaje.InnerText = "Ingreso correcto";
                    Response.Redirect("Articulos.aspx");
                }
            }

        }
    }
}
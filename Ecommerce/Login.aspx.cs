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
    public partial class Login : System.Web.UI.Page
    {
        public List<Cliente> extra = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //Usuario.Text = "Usuario pa";
            //Password.Text = "Claaave";
            ClienteNegocio lista = new ClienteNegocio();
            extra = lista.Listar();
            Mensaje.InnerText = "Ingreso Incorrecto";
            foreach (var item in extra)
            {   
                if (Usuario.Text== item.dni && Password.Text==item.password)
                {
                    Mensaje.InnerText = "Ingreso correcto";
                }
            }
        }
    }
}
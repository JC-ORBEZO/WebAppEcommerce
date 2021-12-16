using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string usuar;
        protected void Page_Load(object sender, EventArgs e)
        {
            // RECEPCIÓN Y MUESTRA DEL NOMBRE DE USUARIO => DESDE LOGIN
            if (Session["usuario"] != null)
            {
                usuar = Session["correo"].ToString();
                if (usuar != null)
                {
                    Contenedor4.InnerText = "Bienvenido "+usuar;
                }
            }            
        }
    }
}
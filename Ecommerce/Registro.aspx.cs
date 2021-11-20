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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();
            ClienteNegocio extra = new ClienteNegocio();            
            try
            {
                nuevo.dni = Dni.Text;
                nuevo.nombre = Nombre.Text;
                nuevo.apellido = Apellido.Text;
                nuevo.telefono = Telefono.Text;
                nuevo.email = Correo.Text;
                nuevo.direccion = Direccion.Text;
                nuevo.password = Password1.Text;
                extra.Agregar(nuevo);
                Mensaje.InnerHtml = "Usuario Registrado";
            }
            catch (Exception)
            {
                Mensaje.InnerHtml = "El Usuario Ya Existe";
            }
        }
    }
}
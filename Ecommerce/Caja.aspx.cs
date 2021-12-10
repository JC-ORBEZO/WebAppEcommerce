﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Ecommerce
{
    public partial class Caja : System.Web.UI.Page
    {
        public string usuario;
        public string password;
        public List<Articulo> receptor { get; set; }
        //public Articulo Otroreceptor { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Otroreceptor= (Articulo)Session["carritoCompra"];
            receptor = (List<Articulo>)Session["carritoCompra"];
            receptor = (List<Articulo>)Session["carritoCompra"];
            Session.Add("carritoCompra", receptor);

            // RECEPCIÓN Y MUESTRA DEL NOMBRE DE USUARIO => DESDE LOGIN
            if (Session["usuario"]!=null)
            {
                usuario = Session["usuario"].ToString();
                if (usuario != null)
                {
                    Contenedor3.InnerText = usuario;
                }
            }            
        }
    }
}
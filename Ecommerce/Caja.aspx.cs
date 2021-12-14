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
    public partial class Caja : System.Web.UI.Page
    {
        public List<int> AiDis = new List<int>();
        public string usuario;
        public string password;
        public List<Articulo> receptor { get; set; }
        public List<Detalle> detalles = new List<Detalle>();
        public Venta nuevaVenta = new Venta();
        protected void Page_Load(object sender, EventArgs e)
        {
            receptor = (List<Articulo>)Session["carritoCompra"];            
            Session.Add("carritoCompra", receptor);
            if (receptor != null)
            {
                foreach (var item in receptor)
                {
                    Detalle extra = new Detalle();

                    if (NoRepetir(item.id) == 1)
                    {
                        extra.CodigoVenta = 5;
                        extra.IdArticulo = item.id;
                        extra.Cantidad = 0;
                        foreach (var itema in receptor)
                        {
                            if (extra.IdArticulo == itema.id)
                            {
                                extra.Cantidad++;
                            }
                        }
                        extra.Precio = item.precio;
                        detalles.Add(extra);
                    }
                }
            }           

        }  
        
        protected int NoRepetir(int id)
        {
            int cont = 0;
            
            AiDis.Add(id);
            foreach (var item in AiDis)
            {
                if (id == item)
                {
                    cont++;
                }                
            }
            if (cont == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            
        }

        protected void Comprar_Click(object sender, EventArgs e)
        {
            //usuario = Session["usuario"].ToString();
            if (Session["usuario"] == null)
            {
                contenedor.InnerText = "EMPIECE POR REGISTRARSE";
            }
            else
            {
                contenedor.InnerText = "USUARIO REGISTRADO";
                //TRAMITE DE COMPRA
                VentaNegocio registraVenta = new VentaNegocio();
                Venta NuevaVenta = new Venta();
                NuevaVenta.Dni = Session["usuario"].ToString();
                NuevaVenta.Precio = EmisorPrecioTotal(detalles);
                NuevaVenta.TipoDePago = 1;
                registraVenta.AgregarVenta(NuevaVenta);
                //TRAMITE DETALLES

            }
        }

        // OTORGA PRECIOS TOTALES PARA VENTAS
        protected decimal EmisorPrecioTotal(List<Detalle> DetaV)
        {
            decimal acumu=0;
            foreach (var item in DetaV)
            {
                acumu += (item.Precio * item.Cantidad);
            }
            return acumu;
        }

    }
}
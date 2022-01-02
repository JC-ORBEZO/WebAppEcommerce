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
        int receptorCantidad { get; set; }
        public int varUnive;
        public List<int> AiDis = new List<int>();
        public string usuario;
        public string password;
        public List<Articulo> receptor { get; set; }
        public List<Detalle> detalles = new List<Detalle>();
        public List<Detalle> receptorDetalles = new List<Detalle>();
        public Venta nuevaVenta = new Venta();
        protected void Page_Load(object sender, EventArgs e)
        {
            receptor = (List<Articulo>)Session["carritoCompra"];            
            
            Session.Add("carritoCompra", receptor);
            
            if (receptor != null && Request.QueryString["cantidad"] == null)
            {
                foreach (var item in receptor)
                {
                    Detalle extra = new Detalle();

                    if (NoRepetir(item.id) == 1)
                    {
                        extra.CodigoVenta = 5;
                        extra.IdArticulo = item.id;
                        extra.Cantidad = 0;
                        extra.Imagen = item.Url;
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
                Session.Add("detallesCompra", detalles);
                receptorDetalles = (List<Detalle>)Session["detallesCompra"];
            }
            //ARMADO PARA UN FUTURO BUTTON PARA AGREGAR O DISMINUIR PRODUCTOS EN CAJA
            /*if (Request.QueryString["cantidad"] != null)
            {
                receptorCantidad= int.Parse(Request.QueryString["cantidad"].ToString());
                foreach (var itemare in detalles)
                {
                    if (itemare.IdArticulo == receptorCantidad)
                    {
                        itemare.Cantidad++;
                    }
                }
                detalles[receptorCantidad - 1].Cantidad++;
                Session.Add("detallesCompra", detalles);
                receptorDetalles = (List<Detalle>)Session["detallesCompra"];
                Response.Redirect("Caja.aspx");
            }*/
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
                if (receptor !=null) {                 
                //TRAMITE DE COMPRA
                VentaNegocio registraVenta = new VentaNegocio();
                List<Venta> TraerID = new List<Venta>();
                Venta NuevaVenta = new Venta();
                NuevaVenta.Dni = Session["usuario"].ToString();
                NuevaVenta.Precio = EmisorPrecioTotal(detalles);
                NuevaVenta.TipoDePago = 1;
                registraVenta.AgregarVenta(NuevaVenta);
                //TRAER ID VENTA
                int receptorDeID = 0;
                TraerID = registraVenta.Listar();
                foreach (var item in TraerID)
                {
                    receptorDeID = item.Codigo;
                }
                //TRAMITE DETALLES
                DetalleNegocio ManipularDetalle = new DetalleNegocio();
                foreach (var item in detalles)
                {
                    //DA EL CODIGO DE VENTA A TODOS LOS DETALLES
                    item.CodigoVenta = receptorDeID;
                    ManipularDetalle.AgregarDetalle(item);
                }
                    contenedor.InnerText = "COMPRA REALIZADA";
                }
                else
                {
                    contenedor.InnerText = "CARRITO VACÍO ";
                }
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
        
        protected void Disminuir_Click(object sender, EventArgs e)
        {
        }

        protected void Aumentar_Click(object sender, EventArgs e)
        {

        }
    }
}
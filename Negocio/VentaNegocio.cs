using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> Listar()
        {
            List<Venta> listaDeVentas = new List<Venta>();
            AccesoDatos dato = new AccesoDatos();
            dato.setearConsulta("SELECT CODIGO_VENTA,DNI_CLIENTE_VENTA,TIPO_DE_PAGO_VENTA,PRECIO_TOTAL FROM VENTA");
            dato.ejecutarLectura();
            while (dato.Lector.Read())
            {
                Venta nuevo = new Venta();
                nuevo.Codigo = (int)dato.Lector["CODIGO_VENTA"];
                nuevo.Dni = (string)dato.Lector["DNI_CLIENTE_VENTA"];
                nuevo.TipoDePago = (int)dato.Lector["TIPO_DE_PAGO_VENTA"];
                nuevo.Precio = (decimal)dato.Lector["PRECIO_TOTAL"];
                listaDeVentas.Add(nuevo);
            }
            dato.cerrarConexion();
            return listaDeVentas;           
        }

        public void AgregarVenta(Venta nuevo)
        {
            AccesoDatos dato = new AccesoDatos();
            dato.setearConsulta("INSERT INTO VENTA (VENTA.DNI_CLIENTE_VENTA,VENTA.TIPO_DE_PAGO_VENTA,VENTA.PRECIO_TOTAL) SELECT '" + nuevo.Dni + "','"+ nuevo.TipoDePago +"','" + nuevo.Precio + "'");
            dato.ejecutarAccion();
            dato.cerrarConexion();
        }
    }
}

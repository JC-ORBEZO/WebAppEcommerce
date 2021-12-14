using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DetalleNegocio
    {
        public List<Detalle> ListarDetalle()
        {
            List<Detalle> nuevo = new List<Detalle>();

            return nuevo;
        }

        public void AgregarDetalle(Detalle nuevo)
        {
            AccesoDatos dato = new AccesoDatos();
            dato.setearConsulta("INSERT INTO DETALLEDEVENTA (COD_VENTA_DV,ID_ARTICULO_DV, CANTIDAD_DV, PRECIO_UNITARIO_DV) SELECT '" + nuevo.CodigoVenta + "','" + nuevo.IdArticulo + "','" + nuevo.Cantidad + "','"+ nuevo.Precio +"'");
            dato.ejecutarAccion();
            dato.cerrarConexion();
        }
    }
}

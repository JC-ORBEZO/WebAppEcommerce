using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> aux = new List<Articulo>();
            AccesoDatos dato = new AccesoDatos();
            dato.setearConsulta("SELECT ARTICULOS.ID_ART,ARTICULOS.CODIGO_ART,ARTICULOS.NOMBRE_ART,ARTICULOS.DESCRIPCION_ART,IMAGEN_ART,ARTICULOS.PRECIO_ART FROM ARTICULOS");
            dato.ejecutarLectura();
            while (dato.Lector.Read())
            {
                Articulo nuevo = new Articulo();
                nuevo.id = (int)dato.Lector["ID_ART"];
                nuevo.codigo = (string)dato.Lector["CODIGO_ART"];
                nuevo.nombre = (string)dato.Lector["NOMBRE_ART"];
                nuevo.descripcion = (string)dato.Lector["DESCRIPCION_ART"];
                nuevo.Url = (string)dato.Lector["IMAGEN_ART"];
                nuevo.precio = (decimal)dato.Lector["PRECIO_ART"];
                aux.Add(nuevo);
            }
            dato.cerrarConexion();
            return aux;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void Agregar(Cliente extra)
        {
            AccesoDatos dato = new AccesoDatos();
            dato.setearConsulta("INSERT INTO CLIENTES SELECT '" + extra.dni + "','" + extra.nombre + "','" + extra.apellido + "','" + extra.telefono + "','" + extra.email + "','" + extra.direccion + "','" + extra.password + "'");
            dato.ejecutarAccion();
            dato.cerrarConexion();
        }

        public List<Cliente> Listar()
        {
            AccesoDatos dato = new AccesoDatos();
            List<Cliente> extra = new List<Cliente>();
            dato.setearConsulta("SELECT CLIENTES.DNI_CLI, CLIENTES.NOMBRE_CLI, CLIENTES.APELLIDO_CLI, EMAIL_CLI,TELEFONO_CLI,CLIENTES.PASSWORD_CLI FROM CLIENTES");
            dato.ejecutarLectura();
            while (dato.Lector.Read())
            {
                Cliente proba = new Cliente();
                proba.dni = (string)dato.Lector["DNI_CLI"];
                proba.nombre = (string)dato.Lector["NOMBRE_CLI"];
                proba.apellido = (string)dato.Lector["APELLIDO_CLI"];
                proba.telefono = (string)dato.Lector["TELEFONO_CLI"];
                proba.email = (string)dato.Lector["EMAIL_CLI"];
                //proba.direccion = (string)dato.Lector["DIRECCION_CLI"];
                proba.password = (string)dato.Lector["PASSWORD_CLI"];
                extra.Add(proba);
            }
            dato.cerrarConexion();
            return extra;
        }
    }
}

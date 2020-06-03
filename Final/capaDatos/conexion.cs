using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class conexion
    {
        public OdbcConnection conexionbd()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=dbelbienestar");// creacion de la conexion via ODBC

            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo realizar la conexión");
            }
            return conn;
        }
    }
}

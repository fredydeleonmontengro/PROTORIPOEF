using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class sentencias
    {
        conexion cn = new conexion();
        OdbcCommand comm;

        public OdbcDataReader mostrarbodegas()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM bodegas;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        public OdbcDataReader Insertarbodega(string codigo, string nombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into bodegas values(" + codigo + ", '" + nombre + "' ,'1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader mostrarmarcas()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM marcas;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        public OdbcDataReader mostrarproductos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM productos;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        public OdbcDataReader Insertarcliente(string codigo, string nombre, string direccion, string nit, string telefono, string codigovendedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into clientes values(" + codigo + ", '" + nombre + "', '" + direccion + "' , '" + nit+ "' , '" + telefono  + "' , '" + codigovendedor+ "' ,'1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Insertarmarca(string codigo, string nombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into marcas values(" + codigo + ", '" + nombre + "','1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Insertarproveedor(string codigo, string nombre, string direccion, string telefono, string nit)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into proveedores values(" + codigo + ", '" + nombre + "', '" + direccion + "', '" +telefono + "', '" + nit+ "','1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Insertarvendedor(string codigo, string nombre, string direccion, string telefono, string nit)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into vendedores values(" + codigo + ", '" + nombre + "', '" + direccion + "', '" + telefono + "', '" + nit + "','1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Insertarproducto(string codigo, string nombre, string codmarca, string existencia)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into productos values(" + codigo + ", '" + nombre + "','1', '" + codmarca+ "', '" + existencia+ "','1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


    }
}

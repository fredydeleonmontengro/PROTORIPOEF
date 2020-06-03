using capaDatos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class logica
    {
        sentencias sn = new sentencias();
        public OdbcDataReader bodegas()
        {
            return sn.mostrarbodegas();
        }
        public OdbcDataReader bodegasadd(string codigo, string nombre)
        {
            return sn.Insertarbodega(codigo, nombre);
        }
        public OdbcDataReader productos()
        {
            return sn.mostrarproductos();
        }
        public OdbcDataReader marcas()
        {
            return sn.mostrarmarcas();
        }
        public OdbcDataReader clienteadd(string codigo, string nombre, string direccion, string nit, string telefono, string codigovendedor)

        {
            return sn.Insertarcliente(codigo, nombre, direccion, nit, telefono, codigovendedor);
        }
        public OdbcDataReader marcasadd(string codigo, string nombre)
        {
            return sn.Insertarmarca(codigo, nombre);
        }
        public OdbcDataReader proveedoradd(string codigo, string nombre, string direccion, string telefono, string nit)

        {
            return sn.Insertarproveedor(codigo, nombre, direccion, telefono, nit);

        }
        public OdbcDataReader vendedoradd(string codigo, string nombre, string direccion, string telefono, string nit)

        {
            return sn.Insertarvendedor(codigo, nombre, direccion, telefono, nit);

        }
        public OdbcDataReader productoadd(string codigo, string nombre, string codmarca, string existencia)

        {
            return sn.Insertarproducto(codigo, nombre, codmarca, existencia );

        }
    }
}

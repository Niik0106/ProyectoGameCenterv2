using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logOrdenCompra
    {
        private static readonly logOrdenCompra _instancia = new logOrdenCompra();

        public static logOrdenCompra Instancia
        {
            get { return logOrdenCompra._instancia; }
        }

        //Listado ordenes de compra
        public List<entOrdenCompra> ListarOrdenesCompra()
        {
            return AccesoDatos.datOrdenCompra.Instancia.ListarOrdenesCompra();
        }

        //Insertar orden de compra
        public Boolean InsertarOrdenCompra(entOrdenCompra OrdenCompra)
        {
            return AccesoDatos.datOrdenCompra.Instancia.InsertarOrdenCompra(OrdenCompra);
        }
    }
}

using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logDetalleOrdenCompra
    {
        private static readonly logDetalleOrdenCompra _instancia = new logDetalleOrdenCompra();
        public static logDetalleOrdenCompra Instancia
        {
            get { return logDetalleOrdenCompra._instancia; }
        }

        //Listado detalle orden de compra
        public List<entDetalleOrdenCompra> ListarDetalleOrdenCompra()
        {
            return datDetalleOrdenCompra.Instancia.ListarDetalleOrdenCompra();
        }

        //Insertar detalle orden de compra
        public Boolean InsertarDetalleOrdenCompra(entDetalleOrdenCompra DetalleOrdenCompra)
        {
            return datDetalleOrdenCompra.Instancia.InsertarDetalleOrdenCompra(DetalleOrdenCompra);
        }
    }
}

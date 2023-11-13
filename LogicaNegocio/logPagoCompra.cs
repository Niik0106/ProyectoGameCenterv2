using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logPagoCompra
    {

        private static readonly logPagoCompra _instancia = new logPagoCompra();

        public static logPagoCompra Instancia
        {
            get { return logPagoCompra._instancia; }
        }

        ///listado
        public List<entPagoCompra> ListarPagos()
        {
            return datPagoCompra.Instancia.ListarPagosCompras();
        }
        ///inserta
        public void InsertarPago(entPagoCompra Cat)
        {
            datPagoCompra.Instancia.InsertarPago(Cat);
        }

        public entPagoCompra ObtenerDetallePago(int NumVenta)
        {
            return datPagoCompra.Instancia.ObtenerDetallePago(NumVenta);
        }

    }
}

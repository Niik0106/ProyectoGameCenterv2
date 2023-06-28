using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class logOrdenVenta
    {
        private static readonly logOrdenVenta _instancia = new logOrdenVenta();

        public static logOrdenVenta Instancia
        {
            get { return logOrdenVenta._instancia; }
        }


        public List<entOrdenVenta> ListarVentas()
        {
            return datOrdenVenta.Instancia.ListarVentas();
        }

        public void InsertaOrdenVenta(entOrdenVenta OrdV)
        {
            datOrdenVenta.Instancia.InsertarOrdenVenta(OrdV);
        }

        public void AnulaOrdenVenta(entOrdenVenta OrdV)
        {
            datOrdenVenta.Instancia.AnularOrdenVenta(OrdV);
        }

        //POR FECHA DE VENTA
        public List<entOrdenVenta> BuscaFechaVenta(entOrdenVenta fechaVenta)
        {
            return datOrdenVenta.Instancia.BuscarOrdenVenta(fechaVenta);
        }

        //POR NUMERO DE VENTA
        public entOrdenVenta BuscarOrdenVentaIDCliente(int numVenta)
        {
            return datOrdenVenta.Instancia.BuscarOrdenVentaIDCliente(numVenta);
        }
    }
}

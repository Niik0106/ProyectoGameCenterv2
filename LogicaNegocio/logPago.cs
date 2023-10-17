using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logPago
    {
        private static readonly logPago _instancia = new logPago();

        public static logPago Instancia
        {
            get { return logPago._instancia; }
        }

        ///listado
        public List<entPago> ListarPagos()
        {
            return datPago.Instancia.ListarPagos();
        }
        ///inserta
        public void InsertarPago(entPago Cat)
        {
            datPago.Instancia.InsertarPago(Cat);
        }

        public entPago ObtenerDetallePago(string NumVenta)
        {
            return datPago.Instancia.ObtenerDetallePago(NumVenta);
        }


    }
}

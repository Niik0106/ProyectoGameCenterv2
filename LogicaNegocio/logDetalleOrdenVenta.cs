using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logDetalleOrdenVenta
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDetalleOrdenVenta _instancia = new logDetalleOrdenVenta();
        //privado para evitar la instanciación directa
        public static logDetalleOrdenVenta Instancia
        {
            get
            {
                return logDetalleOrdenVenta._instancia;
            }
        }
        #endregion singleton

        public List<entDetalleOrdenVenta> ListarDetalleOrdenVenta()
        {
            return datDetalleOrdenVenta.Instancia.ListarDetalleOrdenVenta();
        }

        public Boolean InsertaDetalleOrdenVenta(entDetalleOrdenVenta DetalleOV)
        {
            return datDetalleOrdenVenta.Instancia.InsertarDetalleOrdenVenta(DetalleOV);
        }
        public List<entDetalleOrdenVenta> OrdenaDetalleVenta(entDetalleOrdenVenta numOrd)
        {
            return datDetalleOrdenVenta.Instancia.OrdenarDetalleVenta(numOrd);
        }
    }
}

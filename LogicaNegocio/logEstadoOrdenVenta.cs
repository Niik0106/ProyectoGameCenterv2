using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class logEstadoOrdenVenta
    {

        private static readonly logEstadoOrdenVenta _instancia = new logEstadoOrdenVenta();

        public static logEstadoOrdenVenta Instancia
        {
            get { return logEstadoOrdenVenta._instancia; }
        }

        ///listado
        public List<entEstadoOrdenVenta> ListaEstadoOrdenVenta()
        {
            return datEstadoOrdenVenta.Instancia.ListarEstadoOrdenVenta();
        }

    }
}

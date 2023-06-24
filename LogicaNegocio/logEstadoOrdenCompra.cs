using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class logEstadoOrdenCompra
    {

        private static readonly logEstadoOrdenCompra _instancia = new logEstadoOrdenCompra();

        public static logEstadoOrdenCompra Instancia
        {
            get { return logEstadoOrdenCompra._instancia; }
        }

        ///listado
        public List<entEstadoOrdenCompra> ListaEstadoOrdenCompra()
        {
            return datEstadoOrdenCompra.Instancia.ListarEstadoOrdenCompra();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class logEstadoPago
    {

        private static readonly logEstadoPago _instancia = new logEstadoPago();

        public static logEstadoPago Instancia
        {
            get { return logEstadoPago._instancia; }
        }

        ///listado
        public List<entEstadoPago> ListaEstadoPago()
        {
            return datEstadoPago.Instancia.ListarEstadoPago();
        }

    }
}

using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logEstadoNotaSalida
    {
        private static readonly logEstadoNotaSalida _instancia = new logEstadoNotaSalida();

        public static logEstadoNotaSalida Instancia
        {
            get { return logEstadoNotaSalida._instancia; }
        }

        ///listado
        public List<entEstadoNotaSalida> ListaEstadoNotaSalida()
        {
            return datEstadoNotaSalida.Instancia.ListarEstadoNotaSalida();
        }
    }
}

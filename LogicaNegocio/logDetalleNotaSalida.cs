using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logDetalleNotaSalida
    {
        //Singleton
        private static readonly logDetalleNotaSalida _instancia = new logDetalleNotaSalida();
        public static logDetalleNotaSalida Instancia
        {
            get { return logDetalleNotaSalida._instancia; }
        }

        //Listado Detalle Nota Salida
        public List<entDetalleNotaSalida> ListarDetalleNotaSalida()
        {
            return datDetalleNotaSalida.Instancia.ListarDetalleNotaSalida();
        }

        //Insertar Detalle Nota Salida
        public Boolean InsertarDetalleNotaSalida(entDetalleNotaSalida detalleNotaSalida)
        {
            return datDetalleNotaSalida.Instancia.InsertarDetalleNotaSalida(detalleNotaSalida);
        }
    }
}

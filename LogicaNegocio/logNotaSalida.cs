using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logNotaSalida
    {
        //Singleton
        private static readonly logNotaSalida _instancia = new logNotaSalida();
        public static logNotaSalida Instancia
        {
            get { return logNotaSalida._instancia; }
        }

        //Lista Nota de Salida
        public List<entNotaSalida> ListarNotaSalida()
        {
            return datNotaSalida.Instancia.ListarNotaSalida();
        }

        //Insertar Nota de Salida
        public Boolean InsertarNotaSalida(entNotaSalida notaSalida)
        {
            return datNotaSalida.Instancia.InsertarNotaSalida(notaSalida);
        }

        //Deshabilitar Nota de Salida
        public void DeshabilitarNotaSalida(entNotaSalida notaSalida)
        {
            datNotaSalida.Instancia.DeshabilitarNotaSalida(notaSalida);
        }

        public List<entNotaSalida> BuscaFechaVenta(entNotaSalida fechaNota)
        {
            return datNotaSalida.Instancia.BuscarNotaSalida(fechaNota);
        }

        public int Verificar_Orden_Venta(string numVenta)
        {
            return datNotaSalida.Instancia.BuscarOrdenVenta(numVenta);
        }
    }
}

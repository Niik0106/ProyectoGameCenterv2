using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logNotaEntrada
    {
        //Singleton
        private static readonly logNotaEntrada _instancia = new logNotaEntrada();
        public static logNotaEntrada Instancia
        {
            get { return logNotaEntrada._instancia; }
        }

        //Lista Nota de Salida
        public List<entNotaEntrada> ListarNotaEntrada()
        {
            return datNotaEntrada.Instancia.ListarNotaEntrada();
        }

        //Insertar Nota de Salida
        public Boolean InsertarNotaEntrada(entNotaEntrada notaEntrada)
        {
            return datNotaEntrada.Instancia.InsertarNotaEntrada(notaEntrada);
        }

        //Deshabilitar Nota de Salida
        public Boolean DeshabilitarNotaEntrada(int notaEntrada)
        {
            return datNotaEntrada.Instancia.DeshabilitarNotaEntrada(notaEntrada);
        }

        public List<entNotaEntrada> BuscaFecha(entNotaEntrada fecha)
        {
            return datNotaEntrada.Instancia.BuscarNotaEntrada(fecha);
        }
    }
}

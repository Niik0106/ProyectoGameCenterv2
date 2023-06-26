using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class logMetodoPago
    {

        private static readonly logMetodoPago _instancia = new logMetodoPago();

        public static logMetodoPago Instancia
        {
            get { return logMetodoPago._instancia; }
        }

        ///listado
        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.ListarMetodoPago();
        }

        ///AGREGAR
        ///
        public void InsertaMetodoPago(entMetodoPago Metodo)
        {
            datMetodoPago.Instancia.InsertarMetodoPago(Metodo);
        }
        ////editar
        ///
        public void EditaMetodoPago(entMetodoPago Metodo)
        {
            datMetodoPago.Instancia.EditarMetodoPago(Metodo);
        }
        //inhabilitar

        public void DeshabilitaMetodoPago(entMetodoPago Metodo)
        {
            datMetodoPago.Instancia.DeshabilitarMetodoPago(Metodo);
        }
    }
}

using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logTipoPago
    {

        private static readonly logTipoPago _instancia = new logTipoPago();

        public static logTipoPago Instancia
        {
            get { return logTipoPago._instancia; }
        }

        ///listado
        public List<entTipoPago> ListarTipoPago()
        {
            return datTipoPago.Instancia.ListarTipoPago();
        }

        ///AGREGAR
        ///
        public void InsertaMetodoPago(entTipoPago Tipo)
        {
            datTipoPago.Instancia.InsertarTipoPago(Tipo);
        }
        ////editar
        ///
        public void EditaMetodoPago(entTipoPago Tipo)
        {
            datTipoPago.Instancia.EditarTipoPago(Tipo);
        }
        //inhabilitar

        public void DeshabilitaMetodoPago(entTipoPago Tipo)
        {
            datTipoPago.Instancia.DeshabilitarTipoPago(Tipo);
        }

    }
}

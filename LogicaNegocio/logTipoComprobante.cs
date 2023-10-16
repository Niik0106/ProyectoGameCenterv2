using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logTipoComprobante
    {
        private static readonly logTipoComprobante _instancia = new logTipoComprobante();

        public static logTipoComprobante Instancia
        {
            get { return logTipoComprobante._instancia; }
        }

        ///listado
        public List<entTipoComprobante> ListarTipoComprobante()
        {
            return datTipoComprobante.Instancia.ListarTipoComprobante();
        }

    }
}

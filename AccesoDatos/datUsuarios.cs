using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace AccesoDatos
{
     public class datUsuarios
    {

        #region sigleton
        private static readonly datUsuarios _instancia = new datUsuarios();
        public static datUsuarios Instancia
        {
            get
            {
                return datUsuarios._instancia;
            }
        }
        #endregion singleton





    }
}

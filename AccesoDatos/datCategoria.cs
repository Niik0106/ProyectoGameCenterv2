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
    public class datCategoria
    {
        private static readonly datCategoria _instancia = new datCategoria();
        
        public static datCategoria Instancia
        {
            get { return datCategoria._instancia; }
        }

        public List<entCategoria> ListarCiudad()
        {

        }

        public Boolean InsertarCiudad(entCategoria Cat)
        {
           
        }

        public Boolean EditarCiudad(entCategoria Cat)
        {

        }

        public Boolean DeshabilitarCiudad(entCategoria Cat)
        {

        }
    }
}

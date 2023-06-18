using System;
using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< HEAD
using System.Data;
=======
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4
=======
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    internal class Conexion
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======

        //patron de Diseño Singleton
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4
=======

        //patron de Diseño Singleton
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.; Initial Catalog = DBMoanso; Integrated Security=true";
            return cn;
        }
=======
=======
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=; Initial Catalog = MOANSO_GAMECENTER;" +//"User ID=sa; Password=123";
                                "Integrated Security=true";

            return cn;
        }

<<<<<<< HEAD
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4
=======
>>>>>>> 43f4fd24d0f640784a674bfba32e8930df4cf0f4
    }
}

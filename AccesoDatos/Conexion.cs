﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Conexion
    {
        public static string cn = "Data Source=DESKTOP-ACRSVPL\\SQLEXPRESS; Initial Catalog = DIARS_GAMECENTER; Integrated Security=true";

        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-ACRSVPL\\SQLEXPRESS; Initial Catalog = DIARS_GAMECENTER; Integrated Security=true";

            return cn;
        }
    }
}

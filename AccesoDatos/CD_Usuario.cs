using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using System.Xml;
using System.Xml.Linq;

namespace AccesoDatos
{
    public class CD_Usuario
    {
        public static int UsuarioIngresado = 0;
        public static int TipoUsuario = ObtenerRol(UsuarioIngresado);
        public static int loguear(string usuario, string clave)
        {
            int idUsuario = 0;
            UsuarioIngresado = idUsuario;
            using (SqlConnection cn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_LoginUsuario", cn);
                    cmd.Parameters.AddWithValue("Usuario", usuario);
                    cmd.Parameters.AddWithValue("Clave", clave);
                    cmd.Parameters.Add("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    idUsuario = Convert.ToInt32(cmd.Parameters["IdUsuario"].Value);
                }
                catch (Exception e)
                {

                    idUsuario = 0;
                }
            }

            return idUsuario;
        }

        public static int ObtenerRol(int P_IdUsuario)
        {
            int idUsuario = 0;
            using (SqlConnection cn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_ObtenerPermisos", cn);
                    cmd.Parameters.AddWithValue("IdUsuario", P_IdUsuario);
                    cmd.Parameters.Add("IdRol", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    idUsuario = Convert.ToInt32(cmd.Parameters["IdRol"].Value);

                }
                catch (Exception e)
                {

                    idUsuario = 0;
                }
            }

            return idUsuario;
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class datEstadoNotaSalida
    {
        private static readonly datEstadoNotaSalida _instancia = new datEstadoNotaSalida();
        public static datEstadoNotaSalida Instancia
        {
            get { return datEstadoNotaSalida._instancia; }
        }

        public List<entEstadoNotaSalida> ListarEstadoNotaSalida()
        {
            SqlCommand cmd = null;
            List<entEstadoNotaSalida> lista = new List<entEstadoNotaSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_ESTADO_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstadoNotaSalida EstadoOV = new entEstadoNotaSalida();
                    EstadoOV.ID_EST_NOTA_SALIDA = Convert.ToInt32(dr["ID_EST_NOTA_SALIDA"]);
                    EstadoOV.DES_ESTADO_NS = dr["DES_ESTADO_NS"].ToString();
                    lista.Add(EstadoOV);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}

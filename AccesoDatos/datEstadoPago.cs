using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class datEstadoPago
    {

        private static readonly datEstadoPago _instancia = new datEstadoPago();
        public static datEstadoPago Instancia
        {
            get { return datEstadoPago._instancia; }
        }

        public List<entEstadoPago> ListarEstadoPago()
        {
            SqlCommand cmd = null;
            List<entEstadoPago> lista = new List<entEstadoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_ESTADO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstadoPago MPago = new entEstadoPago();
                    MPago.ID_ESTADO_PAGO = Convert.ToInt32(dr["ID_ESTADO_PAGO"]);
                    MPago.DES_ESTADO_PAGO = dr["DES_ESTADO_PAGO"].ToString();
                    lista.Add(MPago);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }


    }
}

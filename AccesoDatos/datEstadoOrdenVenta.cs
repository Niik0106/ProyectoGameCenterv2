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
    public class datEstadoOrdenVenta
    {

        private static readonly datEstadoOrdenVenta _instancia = new datEstadoOrdenVenta();
        public static datEstadoOrdenVenta Instancia
        {
            get { return datEstadoOrdenVenta._instancia; }
        }

        public List<entEstadoOrdenVenta> ListarEstadoOrdenVenta()
        {
            SqlCommand cmd = null;
            List<entEstadoOrdenVenta> lista = new List<entEstadoOrdenVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_ESTADO_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstadoOrdenVenta EstadoOV = new entEstadoOrdenVenta();
                    EstadoOV.ID_EST_ORDEN_VENTA = Convert.ToInt32(dr["ID_EST_ORDEN_VENTA"]);
                    EstadoOV.DES_ESTADO_OV = dr["DES_ESTADO_OV"].ToString();
                    lista.Add(EstadoOV);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

    }
}

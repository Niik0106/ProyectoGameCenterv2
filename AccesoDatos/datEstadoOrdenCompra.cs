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
    public class datEstadoOrdenCompra
    {

        private static readonly datEstadoOrdenCompra _instancia = new datEstadoOrdenCompra();
        public static datEstadoOrdenCompra Instancia
        {
            get { return datEstadoOrdenCompra._instancia; }
        }

        public List<entEstadoOrdenCompra> ListarEstadoOrdenCompra()
        {
            SqlCommand cmd = null;
            List<entEstadoOrdenCompra> lista = new List<entEstadoOrdenCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_ESTADO_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstadoOrdenCompra EstadoOC = new entEstadoOrdenCompra();
                    EstadoOC.ID_EST_ORDEN_COMPRA = Convert.ToInt32(dr["ID_EST_ORDEN_COMPRA"]);
                    EstadoOC.DES_ESTADO_OC = dr["DES_ESTADO_OC"].ToString();
                    lista.Add(EstadoOC);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

    }
}

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
    public class datOrdenVenta
    {
        private static readonly datOrdenVenta _instancia = new datOrdenVenta();
        public static datOrdenVenta Instancia
        {
            get { return datOrdenVenta._instancia; }
        }

        public List<entOrdenVenta> ListarVentas()
        {
            SqlCommand cmd = null;
            List<entOrdenVenta> lista = new List<entOrdenVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenVenta OrdVenta = new entOrdenVenta();
                    OrdVenta.idOrdenVenta = Convert.ToInt32(dr["ID_ORDEN_VENTA"]);
                    OrdVenta.numOrdenVenta = Convert.ToInt32(dr["NUM_ORDEN_VENTA"]);
                    OrdVenta.fechaOrden = Convert.ToDateTime(dr["FEC_ORDEN"]);
                    OrdVenta.idCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    OrdVenta.estOrdenVenta = Convert.ToInt32(dr["ID_EST_ORDEN_VENTA"]);
                    OrdVenta.idUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                    lista.Add(OrdVenta);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarOrdenVenta(entOrdenVenta OrdV)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_ORDEN_VENTA", OrdV.numOrdenVenta);
                cmd.Parameters.AddWithValue("@FECHA", OrdV.fechaOrden);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", OrdV.idCliente);
                cmd.Parameters.AddWithValue("@ID_EST_ORDEN_VENTA", OrdV.estOrdenVenta);
                cmd.Parameters.AddWithValue("@ID_USUARIO", OrdV.idUsuario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean AnularOrdenVenta(entOrdenVenta OrdV)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_ORDEN_VENTA", OrdV.idOrdenVenta);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { delete = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return delete;
        }

    }
}

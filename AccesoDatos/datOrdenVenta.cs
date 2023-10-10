using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Collections;

namespace AccesoDatos
{
    public class datOrdenVenta
    {
        private static readonly datOrdenVenta _instancia = new datOrdenVenta();
        public static datOrdenVenta Instancia
        {
            get { return datOrdenVenta._instancia; }
        }
        public entOrdenVenta BuscarOrdenVentaIDCliente(int numOrdenV)
        {
            SqlCommand cmd = null;
            entOrdenVenta OrdVenta = new entOrdenVenta();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_ORDEN_VENTA_NUM", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_ORDEN_VENTA", numOrdenV);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    OrdVenta.idOrdenVenta = Convert.ToInt32(dr["ID_ORDEN_VENTA"]);
                    //OrdVenta.numOrdenVenta = Convert.ToInt32(dr["NUM_ORDEN_VENTA"]);
                    OrdVenta.fechaOrden = Convert.ToDateTime(dr["FEC_ORDEN"]);
                    OrdVenta.idCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    OrdVenta.estOrdenVenta = Convert.ToInt32(dr["ID_EST_ORDEN_VENTA"]);
                   
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return OrdVenta;
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
                    OrdVenta.numOrdenVenta = dr["NUM_ORDEN_VENTA"].ToString();
                    OrdVenta.fechaOrden = Convert.ToDateTime(dr["FEC_ORDEN"]);
                    OrdVenta.idCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    OrdVenta.num_documento = dr["NUM_DOCUMENTO"].ToString();
                    OrdVenta.estOrdenVenta = Convert.ToInt32(dr["ID_EST_ORDEN_VENTA"]);
                    OrdVenta.idMetodoPago = Convert.ToInt32(dr["ID_METODO_PAGO"]);
                    OrdVenta.des_metodo = dr["DES_METODO_PAGO"].ToString();
                    OrdVenta.idTipoComprobante = Convert.ToInt32(dr["ID_TIPO_COMPROBANTE"]);
                    OrdVenta.des_comprobante = dr["DES_COMPROBANTE"].ToString();
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
        public List<entOrdenVenta> BuscarOrdenVenta(entOrdenVenta fechaVenta)
        {
            SqlCommand cmd = null;
            List<entOrdenVenta> lista = new List<entOrdenVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_ORDENVENTA_FECHA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaOrden", fechaVenta.fechaOrden);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenVenta OrdVenta = new entOrdenVenta();
                    OrdVenta.idOrdenVenta = Convert.ToInt32(dr["ID_ORDEN_VENTA"]);
                    //OrdVenta.numOrdenVenta = Convert.ToInt32(dr["NUM_ORDEN_VENTA"]);
                    //OrdVenta.fechaOrden = Convert.ToDateTime(dr["FEC_ORDEN"]);
                    OrdVenta.idCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    OrdVenta.estOrdenVenta = Convert.ToInt32(dr["ID_EST_ORDEN_VENTA"]);
                   
                    lista.Add(OrdVenta);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        
        
    }
}

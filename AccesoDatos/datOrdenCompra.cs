using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class datOrdenCompra
    {
        private static readonly datOrdenCompra _instancia = new datOrdenCompra();
        public static datOrdenCompra Instancia
        {
            get { return datOrdenCompra._instancia; }
        }
        
        //Buscar 


        //Listado ordenes de venta
        public List<entOrdenCompra> ListarOrdenesCompra()
        {
            SqlCommand cmd = null;
            List<entOrdenCompra> lista = new List<entOrdenCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenCompra OrdenCompra = new entOrdenCompra();
                    OrdenCompra.idOrdenCompra = Convert.ToInt32(dr["ID_ORDEN_COMPRA"]);
                    OrdenCompra.numeroOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    OrdenCompra.fechaOrdenCompra = Convert.ToDateTime(dr["FEC_ORDEN_COMPRA"]);
                    OrdenCompra.RUC = dr["RUC"].ToString();
                    OrdenCompra.razonSocial = dr["RAZON_SOCIAL"].ToString();
                    OrdenCompra.idEstadoOrdenCompra = Convert.ToInt32(dr["ID_EST_ORDEN_COMPRA"]);
                    lista.Add(OrdenCompra);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        //Insertar orden de compra
        public Boolean InsertarOrdenCompra(entOrdenCompra OrdenCompra)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_ORDEN_COMPRA", OrdenCompra.numeroOrdenCompra);
                cmd.Parameters.AddWithValue("@FEC_ORDEN_COMPRA", OrdenCompra.fechaOrdenCompra);
                cmd.Parameters.AddWithValue("@RAZON_SOCIAL", OrdenCompra.razonSocial);
                cmd.Parameters.AddWithValue("@ID_EST_ORDEN_COMPRA", OrdenCompra.idEstadoOrdenCompra);
                cmd.Parameters.AddWithValue("@RUC", OrdenCompra.RUC);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserto = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserto;
        }

        public Boolean AnularOrdenCompra(entOrdenCompra OrdC)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_ORDEN_COMPRA", OrdC.idOrdenCompra);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { delete = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public List<entOrdenCompra> BuscarOrdenCompra(entOrdenCompra fechaCompra)
        {
            SqlCommand cmd = null;
            List<entOrdenCompra> lista = new List<entOrdenCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_ORDENCOMPRA_FECHA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaOrden", fechaCompra.fechaOrdenCompra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenCompra OrdC = new entOrdenCompra();
                    OrdC.idOrdenCompra = Convert.ToInt32(dr["ID_ORDEN_COMPRA"]);
                    OrdC.numeroOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    OrdC.fechaOrdenCompra = Convert.ToDateTime(dr["FEC_ORDEN_COMPRA"]);
                    //OrdC.idProveedor = Convert.ToInt32(dr["ID_PROVEEDOR"]);
                    OrdC.idEstadoOrdenCompra = Convert.ToInt32(dr["ID_EST_ORDEN_COMPRA"]);
                    OrdC.fechaAtendida = Convert.ToDateTime(dr["FEC_ATENDIDA"]);
                    lista.Add(OrdC);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

    }
}

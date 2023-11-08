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
    public class datDetalleOrdenVenta
    {
        private static readonly datDetalleOrdenVenta _instancia = new datDetalleOrdenVenta();
        public static datDetalleOrdenVenta Instancia
        {
            get { return datDetalleOrdenVenta._instancia; }
        }

        public List<entDetalleOrdenVenta> ListarDetalleOrdenVenta()
        {
            SqlCommand cmd = null;
            List<entDetalleOrdenVenta> lista = new List<entDetalleOrdenVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("SP_LISTAR_DETALLE_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleOrdenVenta DetalleOV = new entDetalleOrdenVenta();
                    DetalleOV.NUM_ORDEN_VENTA = dr["NUM_ORDEN_VENTA"].ToString();
                    DetalleOV.ID_PRODUCTO = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    DetalleOV.DESCRIPCION_PROD = dr["DESCRIPCION_PROD"].ToString();
                    DetalleOV.CANTIDAD = Convert.ToInt32(dr["CANTIDAD"]);
                    DetalleOV.PRECIO = Convert.ToDecimal(dr["PRECIO"]);
                    DetalleOV.PRECIO_TOTAL = Convert.ToDecimal(dr["PRECIO_TOTAL"]);
                    lista.Add(DetalleOV);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        public Boolean InsertarDetalleOrdenVenta(entDetalleOrdenVenta DetalleOV)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_DETALLE_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_VENTA", DetalleOV.NUM_ORDEN_VENTA);
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", DetalleOV.ID_PRODUCTO);
                cmd.Parameters.AddWithValue("@DESCRIPCION", DetalleOV.DESCRIPCION_PROD);
                cmd.Parameters.AddWithValue("@CANTIDAD", DetalleOV.CANTIDAD);
                cmd.Parameters.AddWithValue("@PRECIO", DetalleOV.PRECIO);             
                cmd.Parameters.AddWithValue("@PRECIO_TOTAL", DetalleOV.PRECIO_TOTAL);

                // Parámetro de salida @resultado
                SqlParameter resultadoParam = new SqlParameter("@RESULTADO", SqlDbType.Bit);
                resultadoParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultadoParam);

                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor de @resultado
                int resultado = Convert.ToInt32(resultadoParam.Value);
                if (resultado == 1)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }

        public List<entDetalleOrdenVenta> OrdenarDetalleVenta(entDetalleOrdenVenta numOrd)
        {
            SqlCommand cmd = null;
            List<entDetalleOrdenVenta> lista = new List<entDetalleOrdenVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_OBTENER_DETALLES_ORDEN_VENTA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumVenta", numOrd.NUM_ORDEN_VENTA);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleOrdenVenta DetalleOV = new entDetalleOrdenVenta();
                    DetalleOV.NUM_ORDEN_VENTA = dr["NUM_ORDEN_VENTA"].ToString();
                    DetalleOV.ID_PRODUCTO = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    DetalleOV.DESCRIPCION_PROD = dr["DESCRIPCION_PROD"].ToString();
                    DetalleOV.CANTIDAD = Convert.ToInt32(dr["CANTIDAD"]);
                    DetalleOV.PRECIO = Convert.ToDecimal(dr["PRECIO"]);
                    DetalleOV.PRECIO_TOTAL = Convert.ToDecimal(dr["PRECIO_TOTAL"]);
                    lista.Add(DetalleOV);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}

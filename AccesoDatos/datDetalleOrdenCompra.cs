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
    public class datDetalleOrdenCompra
    {
        private static readonly datDetalleOrdenCompra _instancia = new datDetalleOrdenCompra();
        public static datDetalleOrdenCompra Instancia
        {
            get { return datDetalleOrdenCompra._instancia; }
        }

        //Listado detalle orden de compra
        public List<entDetalleOrdenCompra> ListarDetalleOrdenCompra()
        {
            SqlCommand cmd = null;
            List<entDetalleOrdenCompra> lista = new List<entDetalleOrdenCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_DETALLE_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleOrdenCompra detalleOrdenCompra = new entDetalleOrdenCompra();
                    detalleOrdenCompra.NumOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    detalleOrdenCompra.IDProducto = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    detalleOrdenCompra.Descripcion = dr["DESCRIPCION_PROD"].ToString();
                    detalleOrdenCompra.cantidad = Convert.ToInt32(dr["CANTIDAD"]);
                    detalleOrdenCompra.PrecioCompra = Convert.ToDecimal(dr["PRECIO_COMPRA"]);
                    detalleOrdenCompra.Total = Convert.ToDecimal(dr["TOTAL"]);
                    lista.Add(detalleOrdenCompra);
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

        //Insertar detalle orden de compra
        public Boolean InsertarDetalleOrdenCompra(entDetalleOrdenCompra detalleOrdenCompra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_DETALLE_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_ORDEN_COMPRA", detalleOrdenCompra.NumOrdenCompra);
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", detalleOrdenCompra.IDProducto);
                cmd.Parameters.AddWithValue("@DESCRIPCION", detalleOrdenCompra.Descripcion);
                cmd.Parameters.AddWithValue("@CANTIDAD", detalleOrdenCompra.cantidad);
                cmd.Parameters.AddWithValue("@PRECIO_COMPRA", detalleOrdenCompra.PrecioCompra);
                cmd.Parameters.AddWithValue("@TOTAL", detalleOrdenCompra.Total);
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

        public List<entDetalleOrdenCompra> OrdenarDetalleCompra(entDetalleOrdenCompra numOrd)
        {
            SqlCommand cmd = null;
            List<entDetalleOrdenCompra> lista = new List<entDetalleOrdenCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_OBTENER_DETALLES_ORDEN_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOrdenCompra", numOrd.NumOrdenCompra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleOrdenCompra DetalleOC = new entDetalleOrdenCompra();
                    DetalleOC.NumOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    DetalleOC.IDProducto = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    DetalleOC.Descripcion = dr["DESCRIPCION_PROD"].ToString();
                    DetalleOC.cantidad = Convert.ToInt32(dr["CANTIDAD"]);
                    DetalleOC.PrecioCompra = Convert.ToDecimal(dr["PRECIO_COMPRA"]);
                    DetalleOC.Total = Convert.ToDecimal(dr["TOTAL"]);
                    lista.Add(DetalleOC);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}

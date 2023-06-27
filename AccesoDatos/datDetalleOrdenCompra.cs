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
                    detalleOrdenCompra.numeroOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    detalleOrdenCompra.idProducto = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    detalleOrdenCompra.cantidadProducto = Convert.ToInt32(dr["CANTIDAD"]);
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
                cmd.Parameters.AddWithValue("@NUM_ORDEN_COMPRA", detalleOrdenCompra.numeroOrdenCompra);
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", detalleOrdenCompra.idProducto);
                cmd.Parameters.AddWithValue("@CANTIDAD", detalleOrdenCompra.cantidadProducto);
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
    }
}

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
    public class datProducto
    {
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia
        {
            get { return datProducto._instancia; }
        }

       
        public entProducto BuscarProducto(string desProducto)
        {
            SqlCommand cmd = null;
            entProducto Producto = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_PRODUCTO_DESC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DES_PRODUCTO", desProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Producto = new entProducto();
                    Producto.ID_PRODUCTO = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    Producto.DES_PRODUCTO = dr["DES_PRODUCTO"].ToString();
                    Producto.ID_CATEGORIA = Convert.ToInt32(dr["ID_CATEGORIA"]);
                    Producto.ID_MARCA = Convert.ToInt32(dr["ID_MARCA"]);
                    Producto.PRECIO_VENTA = Convert.ToDecimal(dr["PRECIO_VENTA"]);
                    Producto.PRECIO_COMPRA = Convert.ToDecimal(dr["PRECIO_COMPRA"]);
                    Producto.STOCK = Convert.ToInt32(dr["STOCK"]);
                    Producto.ESTADO_PRODUCTO = Convert.ToBoolean(dr["ESTADO_PRODUCTO"]);
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
            return Producto;
        }

        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Prod = new entProducto();
                    Prod.ID_PRODUCTO = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    Prod.DES_PRODUCTO = dr["DES_PRODUCTO"].ToString();
                    Prod.ID_CATEGORIA = Convert.ToInt32(dr["ID_CATEGORIA"]);
                    Prod.ID_MARCA = Convert.ToInt32(dr["ID_MARCA"]);
                    Prod.PRECIO_VENTA = Convert.ToDecimal(dr["PRECIO_VENTA"]);
                    Prod.PRECIO_COMPRA = Convert.ToDecimal(dr["PRECIO_COMPRA"]);
                    Prod.STOCK = Convert.ToInt32(dr["STOCK"]);
                    Prod.ESTADO_PRODUCTO = Convert.ToBoolean(dr["ESTADO_PRODUCTO"]);
                    lista.Add(Prod);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarProducto(entProducto Prod)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desProd ", Prod.DES_PRODUCTO);
                cmd.Parameters.AddWithValue("@idCat ", Prod.ID_CATEGORIA);
                cmd.Parameters.AddWithValue("@idMarca", Prod.ID_MARCA);
                cmd.Parameters.AddWithValue("@precio_venta", Prod.PRECIO_VENTA);
                cmd.Parameters.AddWithValue("@precio_compra", Prod.PRECIO_COMPRA);
                cmd.Parameters.AddWithValue("@stock", Prod.STOCK);
                cmd.Parameters.AddWithValue("@estProd", Prod.ESTADO_PRODUCTO);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarProducto(entProducto Prod)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProd", Prod.ID_PRODUCTO);
                cmd.Parameters.AddWithValue("@desProd", Prod.DES_PRODUCTO);
                cmd.Parameters.AddWithValue("@idCat", Prod.ID_CATEGORIA);
                cmd.Parameters.AddWithValue("@idMarca", Prod.ID_MARCA);
                cmd.Parameters.AddWithValue("@precio_venta", Prod.PRECIO_VENTA);
                cmd.Parameters.AddWithValue("@precio_compra", Prod.PRECIO_COMPRA);
                cmd.Parameters.AddWithValue("@stock", Prod.STOCK);
                cmd.Parameters.AddWithValue("@estProd", Prod.ESTADO_PRODUCTO);
                cn.Open(); int i = cmd.ExecuteNonQuery();
                if (i > 0) { edita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarProducto(entProducto Prod)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProd", Prod.ID_PRODUCTO);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { delete = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public List<entProducto> BuscarDescProducto(entProducto filtroProducto)
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_PRODUCTO_DESC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DES_PRODUCTO", filtroProducto.DES_PRODUCTO);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto Prod = new entProducto();
                    Prod.ID_PRODUCTO = Convert.ToInt32(reader["ID_PRODUCTO"]);
                    Prod.DES_PRODUCTO = reader["DES_PRODUCTO"].ToString();
                    Prod.ID_CATEGORIA = Convert.ToInt32(reader["ID_CATEGORIA"]);
                    Prod.ID_MARCA = Convert.ToInt32(reader["ID_MARCA"]);
                    Prod.PRECIO_VENTA = Convert.ToDecimal(reader["PRECIO_VENTA"]);
                    Prod.PRECIO_COMPRA = Convert.ToDecimal(reader["PRECIO_COMPRA"]);
                    Prod.STOCK = Convert.ToInt32(reader["STOCK"]);
                    Prod.ESTADO_PRODUCTO = Convert.ToBoolean(reader["ESTADO_PRODUCTO"]);
                    lista.Add(Prod);
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




    }
}

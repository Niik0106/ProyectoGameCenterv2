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

        //Buscar Producto
        public entProducto BuscarIDProducto(int idProducto)
        {
            SqlCommand cmd = null;
            entProducto Producto = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_PRODUCTO_ID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", idProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Producto = new entProducto();
                    Producto.idProducto = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    Producto.desProducto = dr["DES_PRODUCTO"].ToString();
                    Producto.idCategoria = Convert.ToInt32(dr["ID_CATEGORIA"]);
                    Producto.idMarca = Convert.ToInt32(dr["ID_MARCA"]);
                    Producto.precioProd = Convert.ToDecimal(dr["PRECIO_PRODUCTO"]);
                    Producto.stockProd = Convert.ToInt32(dr["STOCK"]);
                    Producto.estProducto = Convert.ToBoolean(dr["ESTADO_PRODUCTO"]);
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
                    Prod.idProducto = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    Prod.desProducto = dr["DES_PRODUCTO"].ToString();
                    Prod.idCategoria = Convert.ToInt32(dr["ID_CATEGORIA"]);
                    Prod.idMarca = Convert.ToInt32(dr["ID_MARCA"]);
                    Prod.precioProd = Convert.ToDecimal(dr["PRECIO_PRODUCTO"]);
                    Prod.stockProd = Convert.ToInt32(dr["STOCK"]);
                    Prod.estProducto = Convert.ToBoolean(dr["ESTADO_PRODUCTO"]);
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
                cmd.Parameters.AddWithValue("@desProd ", Prod.desProducto);
                cmd.Parameters.AddWithValue("@idCat ", Prod.idCategoria);
                cmd.Parameters.AddWithValue("@idMarca", Prod.idMarca);
                cmd.Parameters.AddWithValue("@precio", Prod.precioProd);
                cmd.Parameters.AddWithValue("@stock", Prod.stockProd);
                cmd.Parameters.AddWithValue("@estProd", Prod.estProducto);
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
                cmd.Parameters.AddWithValue("@idProd", Prod.idProducto);
                cmd.Parameters.AddWithValue("@desProd", Prod.desProducto);
                cmd.Parameters.AddWithValue("@idCat", Prod.idCategoria);
                cmd.Parameters.AddWithValue("@idMarca", Prod.idMarca);
                cmd.Parameters.AddWithValue("@precio", Prod.precioProd);
                cmd.Parameters.AddWithValue("@stock", Prod.stockProd);
                cmd.Parameters.AddWithValue("@estProd", Prod.estProducto);
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
                cmd.Parameters.AddWithValue("@idProd", Prod.idProducto);
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
                cmd.Parameters.AddWithValue("@DES_PRODUCTO", filtroProducto.desProducto);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto Prod = new entProducto();
                    Prod.idProducto = Convert.ToInt32(reader["ID_PRODUCTO"]);
                    Prod.desProducto = reader["DES_PRODUCTO"].ToString();
                    Prod.idCategoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
                    Prod.idMarca = Convert.ToInt32(reader["ID_MARCA"]);
                    Prod.precioProd = Convert.ToDecimal(reader["PRECIO_PRODUCTO"]);
                    Prod.stockProd = Convert.ToInt32(reader["STOCK"]);
                    Prod.estProducto = Convert.ToBoolean(reader["ESTADO_PRODUCTO"]);
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

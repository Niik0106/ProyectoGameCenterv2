using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace AccesoDatos
{
     public class datUsuarios
    {

        #region sigleton
        private static readonly datUsuarios _instancia = new datUsuarios();
        public static datUsuarios Instancia
        {
            get
            {
                return datUsuarios._instancia;
            }
        }
        #endregion singleton

        public List<entUsuarios> ListarUsuarios()
        {
            SqlCommand cmd = null;
            List<entUsuarios> lista = new List<entUsuarios>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_USUARIOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuarios user = new entUsuarios();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.Nombres = dr["Nombres"].ToString();
                    user.Usuario = dr["Usuario"].ToString();
                    user.Clave = dr["Clave"].ToString();
                    user.IdRol = Convert.ToInt32(dr["IdRol"]);
                    user.NombreRol = dr["Nombre"].ToString();
                    user.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(user);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        ///INSERTAR
        ///
        public Boolean InsertarUsuario(entUsuarios usuario)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_USUARIO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", usuario.Nombres);
                cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@idrol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@estado", usuario.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarUsuario(entUsuarios usuario)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_USUARIO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@nombres", usuario.Nombres);
                cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@idrol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@estado", usuario.estado);
                cn.Open(); int i = cmd.ExecuteNonQuery();
                if (i > 0) { edita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }


        public Boolean DeshabilitarUsuario(entUsuarios usuario)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_USUARIO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", usuario.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deshabilitar;
        }
        /*
        public entUsuarios BuscarProducto(string usuario)
        {
            SqlCommand cmd = null;
            entUsuarios Usuario = null;
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
        */
        public List<entUsuarios> ListarRoles()
        {
            SqlCommand cmd = null;
            List<entUsuarios> lista = new List<entUsuarios>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRoles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuarios User = new entUsuarios();
                    User.IdRol = Convert.ToInt32(dr["IdRol"]);
                    User.NombreRol = dr["Nombre"].ToString();
                    lista.Add(User);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

    }
}

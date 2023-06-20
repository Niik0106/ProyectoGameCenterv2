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
    public class datCategoria
    {
        private static readonly datCategoria _instancia = new datCategoria();
        public static datCategoria Instancia
        {
            get { return datCategoria._instancia; }
        }

        public List<entCategoria> ListarCategoria()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spListarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria Cat = new entCategoria();
                    Cat.idCategoria = Convert.ToInt32(dr["ID_CATEGORIA"]);
                    Cat.desCategoria = dr["DES_CATEGORIA"].ToString();
                    Cat.estCategoria = Convert.ToBoolean(dr["ESTADO_CATEGORIA"]);
                    lista.Add(Cat);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desCat ", Cat.desCategoria);
                cmd.Parameters.AddWithValue("@estCat", Cat.estCategoria);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCat", Cat.idCategoria);
                cmd.Parameters.AddWithValue("@desCat", Cat.desCategoria);
                cmd.Parameters.AddWithValue("@estCat", Cat.estCategoria);
                cn.Open(); int i = cmd.ExecuteNonQuery();
                if (i > 0) { edita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCat", Cat.idCategoria);
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

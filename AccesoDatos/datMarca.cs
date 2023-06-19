using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class datMarca
    {
        private static readonly datMarca _instancia = new datMarca();
        public static datMarca Instancia
        {
            get { return datMarca._instancia; }
        }

        public List<entMarca> ListarCategoria()
        {
            SqlCommand cmd = null;
            List<entMarca> lista = new List<entMarca>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria Mar = new entCategoria();
                    Mar.idCategoria = Convert.ToInt32(dr["ID_CATEGORIA"]);
                    Mar.desCategoria = dr["DES_CATEGORIA"].ToString();
                    Mar.estCategoria = Convert.ToBoolean(dr["ESTADO_CATEGORIA"]);
                    lista.Add(Mar);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}

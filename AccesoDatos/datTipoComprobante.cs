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
    public class datTipoComprobante
    {

        private static readonly datTipoComprobante _instancia = new datTipoComprobante();
        public static datTipoComprobante Instancia
        {
            get { return datTipoComprobante._instancia; }
        }

        public List<entTipoComprobante> ListarTipoComprobante()
        {
            SqlCommand cmd = null;
            List<entTipoComprobante> lista = new List<entTipoComprobante>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_TIPO_COMPROBANTE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoComprobante Tipo = new entTipoComprobante();
                    Tipo.ID_TIPO_COMPROBANTE = Convert.ToInt32(dr["ID_TIPO_COMPROBANTE"]);
                    Tipo.DES_TIPO_COMPROBANTE = dr["DES_TIPO_COMPROBANTE"].ToString();
                    Tipo.ESTADO = Convert.ToBoolean(dr["ESTADO"]);
                    lista.Add(Tipo);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

    }
}

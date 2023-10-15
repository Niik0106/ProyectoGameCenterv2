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
    public class datTipoPago
    {

        private static readonly datTipoPago _instancia = new datTipoPago();
        public static datTipoPago Instancia
        {
            get { return datTipoPago._instancia; }
        }


        public List<entTipoPago> ListarTipoPago()
        {
            SqlCommand cmd = null;
            List<entTipoPago> lista = new List<entTipoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_TIPO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoPago Tipo = new entTipoPago();
                    Tipo.ID_TIPO_PAGO = Convert.ToInt32(dr["ID_TIPO_PAGO"]);
                    Tipo.DES_TIPO_PAGO = dr["DES_TIPO_PAGO"].ToString();
                    Tipo.ID_METODO_PAGO = Convert.ToInt32(dr["ID_METODO_PAGO"]);
                    Tipo.ESTADO_TIPO_PAGO = Convert.ToBoolean(dr["ESTADO_TIPO_PAGO"]);
                    lista.Add(Tipo);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        ///INSERTAR
        ///
        public Boolean InsertarTipoPago(entTipoPago Tipo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_TIPO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DES_TIPO", Tipo.DES_TIPO_PAGO);
                cmd.Parameters.AddWithValue("@ID_METODO", Tipo.ID_METODO_PAGO);
                cmd.Parameters.AddWithValue("@ESTADO_TIPO", Tipo.ESTADO_TIPO_PAGO);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarTipoPago(entTipoPago Tipo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_TIPOO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_TIPO_PAGO", Tipo.ID_TIPO_PAGO);
                cmd.Parameters.AddWithValue("@DES_TIPO_PAGO", Tipo.DES_TIPO_PAGO);
                cmd.Parameters.AddWithValue("@ID_METODO", Tipo.ID_METODO_PAGO);
                cmd.Parameters.AddWithValue("@ESTADO_TIPO_PAGO", Tipo.ESTADO_TIPO_PAGO);
                cn.Open(); int i = cmd.ExecuteNonQuery();
                if (i > 0) { edita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }


        public Boolean DeshabilitarTipoPago(entTipoPago Tipo)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_TIPO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_TIPO", Tipo.ESTADO_TIPO_PAGO);
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


    }
}

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
    public class datMetodoPago
    {
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        public static datMetodoPago Instancia
        {
            get { return datMetodoPago._instancia; }
        }


        public List<entMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_METODO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago Metodo = new entMetodoPago();
                    Metodo.ID_METODO_PAGO = Convert.ToInt32(dr["ID_METODO_PAGO"]);
                    Metodo.DES_METODO_PAGO = dr["DES_METODO_PAGO"].ToString();
                    Metodo.ESTADO_METODO_PAGO = Convert.ToBoolean(dr["ESTADO_METODO_PAGO"]);
                    lista.Add(Metodo);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        ///INSERTAR
        ///
        public Boolean InsertarMetodoPago(entMetodoPago Metodo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_METODO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DES_METODO", Metodo.DES_METODO_PAGO);
                cmd.Parameters.AddWithValue("@ESTADO_METODO", Metodo.ESTADO_METODO_PAGO);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarMetodoPago(entMetodoPago Metodo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_METODO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_METODO_PAGO", Metodo.ID_METODO_PAGO);
                cmd.Parameters.AddWithValue("@DES_METODO_PAGO", Metodo.DES_METODO_PAGO);
                cmd.Parameters.AddWithValue("@ESTADO_METODO_PAGO", Metodo.ESTADO_METODO_PAGO);
                cn.Open(); int i = cmd.ExecuteNonQuery();
                if (i > 0) { edita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }


        public Boolean DeshabilitarMetodoPago(entMetodoPago Metodo)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_METODO_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@@ID_METODO", Metodo.ESTADO_METODO_PAGO);
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

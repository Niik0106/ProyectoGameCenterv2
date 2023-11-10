using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class datNotaSalida
    {
        //Singleton
        private static readonly datNotaSalida _instancia = new datNotaSalida();
        public static datNotaSalida Instancia
        {
            get { return datNotaSalida._instancia; }
        }

        //Listar Nota de Salida
        public List<entNotaSalida> ListarNotaSalida()
        {
            SqlCommand cmd = null;
            List<entNotaSalida> lista = new List<entNotaSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotaSalida notaSalida = new entNotaSalida();
                    notaSalida.idNotaSalida = Convert.ToInt32(dr["ID_NOTA_SALIDA"]);
                    notaSalida.numNotaSalida = Convert.ToInt32(dr["NUM_NOTA_SALIDA"]);
                    notaSalida.fechaEmision = Convert.ToDateTime(dr["FEC_EMISION"]);
                    notaSalida.numOrdenVenta = dr["NUM_ORDEN_VENTA"].ToString();
                    notaSalida.estado = Convert.ToBoolean(dr["ESTADO_NOTA_SALIDA"]);
                    lista.Add(notaSalida);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        //Insertar Nota de Salida
        public Boolean InsertarNotaSalida(entNotaSalida notaSalida)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;          
                cmd.Parameters.AddWithValue("@FEC_EMISION", notaSalida.fechaEmision);
                cmd.Parameters.AddWithValue("@NUM_ORDEN_VENTA", notaSalida.numOrdenVenta);
                cmd.Parameters.AddWithValue("@ESTADO_NOTA_SALIDA", notaSalida.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //Deshabilitar Nota de Salida
        public Boolean DeshabilitarNotaSalida(int idNotaSalida)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_NOTA_SALIDA", idNotaSalida);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { deshabilita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return deshabilita;
        }
    }
}

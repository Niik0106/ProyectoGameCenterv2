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
    public class datCronograma
    {
        private static readonly datCronograma _instancia = new datCronograma();
        public static datCronograma Instancia
        {
            get { return datCronograma._instancia; }
        }

        public List<entCronograma> ListarCronograma()
        {
            SqlCommand cmd = null;
            List<entCronograma> lista = new List<entCronograma>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_CRONOGRAMA_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCronograma Crono = new entCronograma();
                    Crono.ID_CRONOGRAMA_PAGO = Convert.ToInt32(dr["ID_CRONOGRAMA_PAGO"]);
                    Crono.FECHA_VENTA = Convert.ToDateTime(dr["FECHA_VENTA"]);
                    Crono.NUM_ORDEN_VENTA = Convert.ToInt32(dr["NUM_ORDEN_VENTA"]);
                    Crono.ID_CLIENTE = Convert.ToInt32(dr["ID_CLIENTE"]);
                    Crono.TOTAL = Convert.ToDecimal(dr["TOTAL"]);
                    Crono.NUM_CUOTAS = Convert.ToInt32(dr["NUM_CUOTAS"]);
                    Crono.ID_METODO_PAGO = Convert.ToInt32(dr["ID_METODO_PAGO"]);
                    Crono.FEC_PLAZO_PAGO = Convert.ToDateTime(dr["FEC_PLAZO_PAGO"]);
                    Crono.ID_ESTADO_PAGO = Convert.ToInt32(dr["ID_ESTADO_PAGO"]);
                    Crono.OBSERVACIONES = Convert.ToString(dr["OBSERVACIONES"]);
                    lista.Add(Crono);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean InsertarCronograma(entCronograma Crono)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_CRONOGRAMA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECHA", Crono.FECHA_VENTA);
                cmd.Parameters.AddWithValue("@NUM_VENTA", Crono.NUM_ORDEN_VENTA);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", Crono.ID_CLIENTE);
                cmd.Parameters.AddWithValue("@TOTAL", Crono.TOTAL);
                cmd.Parameters.AddWithValue("@NUM_CUOTAS", Crono.NUM_CUOTAS);
                cmd.Parameters.AddWithValue("@ID_METODO_PAGO", Crono.ID_METODO_PAGO);
                cmd.Parameters.AddWithValue("@ID_ESTADO_PAGO", Crono.ID_ESTADO_PAGO);
                cmd.Parameters.AddWithValue("@OBSERVACIONES", Crono.OBSERVACIONES);
                
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }
}

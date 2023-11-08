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
    public class datPago
    {

        private static readonly datPago _instancia = new datPago();
        public static datPago Instancia
        {
            get { return datPago._instancia; }
        }

        public List<entPago> ListarPagos()
        {
            SqlCommand cmd = null;
            List<entPago> lista = new List<entPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_PAGOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPago Pago = new entPago();
                    Pago.ID_PAGO = Convert.ToInt32(dr["ID_PAGO"]);
                    Pago.NUM_ORDEN_VENTA = dr["NUM_ORDEN_VENTA"].ToString();
                    Pago.SUBTOTAL = Convert.ToDecimal(dr["SUBTOTAL"]);                 
                    Pago.IGV = Convert.ToDecimal(dr["IGV"]);
                    Pago.TOTAL = Convert.ToDecimal(dr["TOTAL"]);
                    Pago.ID_METODO_PAGO = Convert.ToInt32(dr["ID_METODO_PAGO"]);
                    Pago.ID_TIPO_PAGO = Convert.ToInt32(dr["ID_TIPO_PAGO"]);

                    entMetodoPago metodoPago = new entMetodoPago();
                    metodoPago.DES_METODO_PAGO = dr["DES_METODO_PAGO"].ToString();
                    Pago.metodoPago = metodoPago;
                    lista.Add(Pago);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarPago(entPago Pago)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;         
                cmd.Parameters.AddWithValue("@NUM_ORDEN_VENTA ", Pago.NUM_ORDEN_VENTA);
                cmd.Parameters.AddWithValue("@SUBTOTAL ", Pago.SUBTOTAL);
                cmd.Parameters.AddWithValue("@IGV", Pago.IGV);
                cmd.Parameters.AddWithValue("@TOTAL", Pago.TOTAL);
                cmd.Parameters.AddWithValue("@ID_METODO_PAGO", Pago.ID_METODO_PAGO);
                cmd.Parameters.AddWithValue("@ID_TIPO_PAGO", Pago.ID_TIPO_PAGO);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        public entPago ObtenerDetallePago(string NumVenta)
        {
            SqlCommand cmd = null;
            entPago Pago = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_OBTENER_DETALLE_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_VENTA", NumVenta);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Pago = new entPago();
                    Pago.ID_PAGO = Convert.ToInt32(dr["ID_PAGO"]);
                    Pago.NUM_ORDEN_VENTA = dr["NUM_ORDEN_VENTA"].ToString();
                    Pago.SUBTOTAL = Convert.ToDecimal(dr["SUBTOTAL"]);
                    Pago.IGV = Convert.ToDecimal(dr["IGV"]);
                    Pago.TOTAL = Convert.ToDecimal(dr["TOTAL"]);
                    Pago.ID_METODO_PAGO = Convert.ToInt32(dr["ID_METODO_PAGO"]);
                    Pago.ID_TIPO_PAGO = Convert.ToInt32(dr["ID_TIPO_PAGO"]);
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
            return Pago;
        }

    }
}

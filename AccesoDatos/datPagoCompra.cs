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
    public class datPagoCompra
    {

        private static readonly datPagoCompra _instancia = new datPagoCompra();
        public static datPagoCompra Instancia
        {
            get { return datPagoCompra._instancia; }
        }

        public List<entPagoCompra> ListarPagosCompras()
        {
            SqlCommand cmd = null;
            List<entPagoCompra> lista = new List<entPagoCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_PAGO_COMPRAS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPagoCompra Pago = new entPagoCompra();
                    Pago.ID_PAGO = Convert.ToInt32(dr["ID_PAGO"]);
                    Pago.NUM_ORDEN_COMPRA = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    Pago.TOTAL = Convert.ToDecimal(dr["TOTAL"]);                  
                    lista.Add(Pago);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarPago(entPagoCompra PagoCompra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_PAGO_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_ORDEN_COMPRA", PagoCompra.NUM_ORDEN_COMPRA);
                cmd.Parameters.AddWithValue("@TOTAL", PagoCompra.TOTAL);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        public entPagoCompra ObtenerDetallePago(int NumCompra)
        {
            SqlCommand cmd = null;
            entPagoCompra PagoCompra = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_OBTENER_DETALLE_PAGO_COMPRA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_COMPRA", NumCompra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    PagoCompra = new entPagoCompra();
                    PagoCompra.ID_PAGO = Convert.ToInt32(dr["ID_PAGO"]);
                    PagoCompra.NUM_ORDEN_COMPRA = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    PagoCompra.TOTAL = Convert.ToDecimal(dr["TOTAL"]);
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
            return PagoCompra;
        }

    }
}
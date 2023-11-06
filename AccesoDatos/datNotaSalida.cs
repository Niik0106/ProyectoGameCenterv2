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

        public int BuscarOrdenVenta(string numOrdenV)
        {
            int resultado = 0; // Inicializamos el resultado a 0 por defecto

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("[dbo].[SP_VERIFICAR_ORDEN_VENTA]", cn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NUM_ORDEN_VENTA", numOrdenV);

                    cn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        resultado = (int)result;
                    }

                }
            }

            // El valor 0 o 1 ya está almacenado en la variable resultado
            return resultado;
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
                    notaSalida.numOrdenVenta = (string)(dr["NUM_ORDEN_VENTA"]);
                    notaSalida.estado = Convert.ToInt32(dr["ID_EST_NOTA_SALIDA"]);
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
                cmd.Parameters.AddWithValue("@NUM_NOTA_SALIDA", notaSalida.numNotaSalida);
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
        public Boolean DeshabilitarNotaSalida(entNotaSalida idNotaSalida)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_NOTA_SALIDA", idNotaSalida.idNotaSalida);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { deshabilita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return deshabilita;
        }


        public List<entNotaSalida> BuscarNotaSalida(entNotaSalida fechaNota)
        {
            SqlCommand cmd = null;
            List<entNotaSalida> lista = new List<entNotaSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_NOTASALIDA_FECHA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FEC_EMISION", fechaNota.fechaEmision);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotaSalida OrdVenta = new entNotaSalida();
                    OrdVenta.idNotaSalida = Convert.ToInt32(dr["ID_NOTA_SALIDA"]);
                    //OrdVenta.numOrdenVenta = Convert.ToInt32(dr["NUM_ORDEN_VENTA"]);
                    //OrdVenta.fechaOrden = Convert.ToDateTime(dr["FEC_ORDEN"]);
                    OrdVenta.estado = Convert.ToInt32(dr["ID_EST_NOTA_SALIDA"]);

                    lista.Add(OrdVenta);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }



    }


   

}

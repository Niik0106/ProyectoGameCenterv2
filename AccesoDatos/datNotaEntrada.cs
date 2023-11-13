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
    public class datNotaEntrada
    {

        //Singleton
        private static readonly datNotaEntrada _instancia = new datNotaEntrada();
        public static datNotaEntrada Instancia
        {
            get { return datNotaEntrada._instancia; }
        }

        //Listar Nota de Salida
        public List<entNotaEntrada> ListarNotaEntrada()
        {
            SqlCommand cmd = null;
            List<entNotaEntrada> lista = new List<entNotaEntrada>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_NOTA_ENTRADA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotaEntrada notaEntrada = new entNotaEntrada();
                    notaEntrada.idNotaEntrada = Convert.ToInt32(dr["ID_NOTA_ENTRADA"]);
                    notaEntrada.numNotaEntrada = Convert.ToInt32(dr["NUM_NOTA_ENTRADA"]);
                    notaEntrada.fechaEmision = Convert.ToDateTime(dr["FECHA"]);
                    notaEntrada.numOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    notaEntrada.estado = Convert.ToBoolean(dr["ESTADO_NOTA_ENTRADA"]);
                    lista.Add(notaEntrada);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        //Insertar Nota de Salida
        public Boolean InsertarNotaEntrada(entNotaEntrada notaEntrada)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_NOTA_ENTRADA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECHA", notaEntrada.fechaEmision);
                cmd.Parameters.AddWithValue("@NUM_ORDEN_COMPRA", notaEntrada.numOrdenCompra);
                cmd.Parameters.AddWithValue("@ESTADO_NOTA_ENTRADA", notaEntrada.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //Deshabilitar Nota de Salida
        public Boolean DeshabilitarNotaEntrada(int idNotaEntrada)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_NOTA_ENTRADA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_NOTA_ENTRADA", idNotaEntrada);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { deshabilita = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return deshabilita;
        }


        public List<entNotaEntrada> BuscarNotaEntrada(entNotaEntrada fecha)
        {
            SqlCommand cmd = null;
            List<entNotaEntrada> lista = new List<entNotaEntrada>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_NOTA_ENTRADA_FECHA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECHA", fecha.fechaEmision);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotaEntrada Entrada = new entNotaEntrada();
                    Entrada.idNotaEntrada = Convert.ToInt32(dr["ID_NOTA_ENTRADA"]);
                    Entrada.numNotaEntrada = Convert.ToInt32(dr["NUM_NOTA_ENTRADA"]);
                    Entrada.fechaEmision = Convert.ToDateTime(dr["FECHA"]);
                    Entrada.numOrdenCompra = Convert.ToInt32(dr["NUM_ORDEN_COMPRA"]);
                    Entrada.estado = Convert.ToBoolean(dr["ESTADO_NOTA_ENTRADA"]);
                    lista.Add(Entrada);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}

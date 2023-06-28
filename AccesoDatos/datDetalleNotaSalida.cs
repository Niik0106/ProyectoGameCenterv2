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
    public class datDetalleNotaSalida
    {
        //Singleton
        private static readonly datDetalleNotaSalida _instancia = new datDetalleNotaSalida();
        public static datDetalleNotaSalida Instancia
        {
            get { return datDetalleNotaSalida._instancia; }
        }

        //Listado Detalle Nota Salida
        public List<entDetalleNotaSalida> ListarDetalleNotaSalida()
        {
            SqlCommand cmd = null;
            List<entDetalleNotaSalida> lista = new List<entDetalleNotaSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_DETALLE_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleNotaSalida detalleNotaSalida = new entDetalleNotaSalida();
                    detalleNotaSalida.numNotaSalida = Convert.ToInt32(dr["NUM_NOTA_SALIDA"]);
                    detalleNotaSalida.idProducto = Convert.ToInt32(dr["ID_PRODUCTO"]);
                    detalleNotaSalida.cantidad = Convert.ToInt32(dr["CANTIDAD"]);
                    lista.Add(detalleNotaSalida);
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
            return lista;

        }

        //Insertar Detalle Nota Salida
        public Boolean InsertarDetalleNotaSalida(entDetalleNotaSalida detalleNotaSalida)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_DETALLE_NOTA_SALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUM_NOTA_SALIDA", detalleNotaSalida.numNotaSalida);
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", detalleNotaSalida.idProducto);
                cmd.Parameters.AddWithValue("@CANTIDAD", detalleNotaSalida.cantidad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
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
            return inserta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class datProveedor
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //Buscar proveedor
        public entProveedor BuscarIDProveedor(int idProveedor)
        {
            SqlCommand cmd = null;
            entProveedor Prov = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_ID_PROVEEDOR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", idProveedor);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Prov = new entProveedor();
                    Prov.RUC_PROV = dr["RUC_PROV"].ToString();
                    Prov.RAZON_SOCIAL_PROV = dr["RAZON_SOCIAL_PROV"].ToString();
                    Prov.TEL_PROVEEDOR = dr["TEL_PROVEEDOR"].ToString();
                    Prov.COD_UBIGEO = Convert.ToInt32(dr["COD_UBIGEO"]);
                    Prov.DIR_PROVEEDOR = dr["DIR_PROVEEDOR"].ToString();
                    Prov.NUM_CUENTA = dr["NUM_CUENTA"].ToString();
                    Prov.ESTADO_PROVEEDOR = Convert.ToBoolean(dr["ESTADO_PROVEEDOR"]);
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
            return Prov;
        }














        ////////////////////listado de Clientes
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("SP_LISTAR_PROVEEDOR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Prov = new entProveedor();
                    Prov.ID_PROVEEDOR = Convert.ToInt32(dr["ID_PROVEEDOR"]);
                    Prov.RUC_PROV = dr["RUC_PROV"].ToString();
                    Prov.RAZON_SOCIAL_PROV = dr["RAZON_SOCIAL_PROV"].ToString();
                    Prov.TEL_PROVEEDOR = dr["TEL_PROVEEDOR"].ToString();
                    Prov.COD_UBIGEO = Convert.ToInt32(dr["COD_UBIGEO"]);
                    Prov.DIR_PROVEEDOR = dr["DIR_PROVEEDOR"].ToString();
                    Prov.NUM_CUENTA = dr["NUM_CUENTA"].ToString();
                    Prov.ESTADO_PROVEEDOR = Convert.ToBoolean(dr["ESTADO_PROVEEDOR"]);
                    lista.Add(Prov);
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

        /////////////////////////InsertaProveedor
        public Boolean InsertarProveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_PROVEEDOR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC_PROV", Prov.RUC_PROV);
                cmd.Parameters.AddWithValue("@RAZON_SOCIAL_PROV", Prov.RAZON_SOCIAL_PROV);
                cmd.Parameters.AddWithValue("@TEL_PROVEEDOR", Prov.TEL_PROVEEDOR);
                cmd.Parameters.AddWithValue("@COD_UBIGEO", Prov.COD_UBIGEO);
                cmd.Parameters.AddWithValue("@DIR_PROVEEDOR", Prov.DIR_PROVEEDOR);
                cmd.Parameters.AddWithValue("@NUM_CUENTA", Prov.NUM_CUENTA);
                cmd.Parameters.AddWithValue("@ESTADO_PROVEEDOR",Prov.ESTADO_PROVEEDOR );

                // Parámetro de salida @resultado
                SqlParameter resultadoParam = new SqlParameter("@RESULTADO", SqlDbType.Bit);
                resultadoParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultadoParam);

                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor de @resultado
                int resultado = Convert.ToInt32(resultadoParam.Value);
                if (resultado == 0)
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
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }

        ////MODIFICAR
        ///
        public Boolean EditarProveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_PROVEEDOR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Prov.ID_PROVEEDOR);
                cmd.Parameters.AddWithValue("@RUC_PROV", Prov.RUC_PROV);
                cmd.Parameters.AddWithValue("@RAZON_SOCIAL_PROV", Prov.RAZON_SOCIAL_PROV);
                cmd.Parameters.AddWithValue("@TEL_PROVEEDOR", Prov.TEL_PROVEEDOR);
                cmd.Parameters.AddWithValue("@COD_UBIGEO", Prov.COD_UBIGEO);
                cmd.Parameters.AddWithValue("@DIR_PROVEEDOR", Prov.DIR_PROVEEDOR);
                cmd.Parameters.AddWithValue("@NUM_CUENTA", Prov.NUM_CUENTA);
                cmd.Parameters.AddWithValue("@ESTADO_PROVEEDOR", Prov.ESTADO_PROVEEDOR);

                // Parámetro de salida @resultado
                SqlParameter resultadoParam = new SqlParameter("@RESULTADO", SqlDbType.Bit);
                resultadoParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultadoParam);

                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor de @resultado
                int resultado = Convert.ToInt32(resultadoParam.Value);
                if (resultado == 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return edita;
        }

        ///DESHBAILITAR
        ///
        public Boolean InhabilitarProveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INHABILITAR_PROVEEDOR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Prov.ID_PROVEEDOR);
                cmd.Parameters.AddWithValue("@ESTADO_PROVEEDOR", Prov.ESTADO_PROVEEDOR);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inhabilitar;
        }

        #endregion

    }
}

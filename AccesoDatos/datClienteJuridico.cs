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
    public class datClienteJuridico
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datClienteJuridico _instancia = new datClienteJuridico();
        //privado para evitar la instanciación directa
        public static datClienteJuridico Instancia
        {
            get
            {
                return datClienteJuridico._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entClienteJuridico> ListarClienteJuridico()
        {
            SqlCommand cmd = null;
            List<entClienteJuridico> lista = new List<entClienteJuridico>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarClienteJuridico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entClienteJuridico CliJ = new entClienteJuridico();
                    CliJ.ID_CLIENTE = Convert.ToInt32(dr["ID_CLIENTE"]);
                    CliJ.RUC_CLIENTE_J = dr["RUC_CLIENTE"].ToString();
                    CliJ.RAZON_SOCIAL_CLIENTE_J = dr["RAZON_SOCIAL_CLIENTE_J"].ToString();
                    CliJ.TEL_CLIENTE_J = dr["TEL_CLIENTE"].ToString();
                    CliJ.COD_UBIGEO = Convert.ToInt32(dr["COD_UBIGEO"]);
                    CliJ.DIR_CLIENTE_J = dr["DIR_CLIENTE"].ToString();
                    CliJ.ESTADO_CLIENTE_J = Convert.ToBoolean(dr["ESTADO_CLIENTE"]);
                    lista.Add(CliJ);
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
        public Boolean InsertarClienteJuridico(entClienteJuridico CliJ)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarClienteJuridico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", CliJ.RUC_CLIENTE_J);
                cmd.Parameters.AddWithValue("@RAZON_SOCIAL", CliJ.RAZON_SOCIAL_CLIENTE_J);
                cmd.Parameters.AddWithValue("@TEL_CLIENTE", CliJ.TEL_CLIENTE_J);
                cmd.Parameters.AddWithValue("@COD_UBIGEO", CliJ.COD_UBIGEO);
                cmd.Parameters.AddWithValue("@DIR_CLIENTE", CliJ.DIR_CLIENTE_J);
                cmd.Parameters.AddWithValue("@ESTADO_CLIENTE", CliJ.ESTADO_CLIENTE_J);

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
        public Boolean EditarClienteJuridico(entClienteJuridico CliJ)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarClienteJuridico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", CliJ.ID_CLIENTE);
                cmd.Parameters.AddWithValue("@RUC_CLIENTE", CliJ.RUC_CLIENTE_J);
                cmd.Parameters.AddWithValue("@RAZON_SOCIAL", CliJ.RAZON_SOCIAL_CLIENTE_J);
                cmd.Parameters.AddWithValue("@TEL_SOCIAL", CliJ.TEL_CLIENTE_J);
                cmd.Parameters.AddWithValue("@COD_UBIGEO", CliJ.COD_UBIGEO);
                cmd.Parameters.AddWithValue("@DIR_CLIENTE", CliJ.DIR_CLIENTE_J);
                cmd.Parameters.AddWithValue("@ESTADO_CLIENTE", CliJ.ESTADO_CLIENTE_J);

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
        public Boolean DeshabilitarClienteJuridico(entClienteJuridico CliJ)
        {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarClienteJuridico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", CliJ.ID_CLIENTE);
                cmd.Parameters.AddWithValue("@ESTADO_PROVEEDOR", CliJ.ESTADO_CLIENTE_J);
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

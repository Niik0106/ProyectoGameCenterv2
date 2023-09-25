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
    public class datClienteNatural
    {
        private static readonly datClienteNatural _instancia = new datClienteNatural();
        public static datClienteNatural Instancia
        {
            get { return datClienteNatural._instancia; }
        }


        //Busqueda de Cliente Natural por DNI
        public List<entClienteNatural> BuscarDniClienteNatural(entClienteNatural filtroCliente)
        {
            SqlCommand cmd = null;
            List<entClienteNatural> lista = new List<entClienteNatural>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BUSCAR_DNI_CLIENTE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", filtroCliente.DNI);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.ID_CLIENTE = (int)reader["ID_CLIENTE"];
                    cliente.DNI = (string)reader["DNI"];
                    cliente.NOMBRE_CLI = (string)reader["NOMBRE_CLI"];
                    cliente.APELLIDO_PATERNO = (string)reader["APELLIDO_PATERNO"];
                    cliente.APELLIDO_MATERNO = (string)reader["APELLIDO_MATERNO"];
                    cliente.TEL_CLIENTE = (string)reader["TEL_CLIENTE"];
                    cliente.ESTADO_CLIENTE = (Boolean)reader["ESTADO_CLIENTE"];
                    lista.Add(cliente);
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

        //LISTAR CLIENTE NATURAL
        public List<entClienteNatural> ListarClienteNatural()
        {
            SqlCommand cmd = null;
            List<entClienteNatural> lista = new List<entClienteNatural>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("SP_LISTAR_CLIENTE_NATURAL", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.ID_CLIENTE = (int)reader["ID_CLIENTE"];
                    cliente.DNI = (string)reader["DNI"];
                    cliente.NOMBRE_CLI = (string)reader["NOMBRE_CLI"];
                    cliente.APELLIDO_PATERNO = (string)reader["APELLIDO_PATERNO"];
                    cliente.APELLIDO_MATERNO = (string)reader["APELLIDO_MATERNO"];
                    cliente.TEL_CLIENTE = (string)reader["TEL_CLIENTE"];
                    cliente.ESTADO_CLIENTE = (Boolean)reader["ESTADO_CLIENTE"];
                    lista.Add(cliente);
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

        //INSERTAR CLIENTE NATURAL
        public Boolean InsertarClienteNatural(entClienteNatural cliente)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("SP_INSERTAR_CLIENTE_NATURAL", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", cliente.DNI);
                cmd.Parameters.AddWithValue("@NOMBRE_CLI", cliente.NOMBRE_CLI);
                cmd.Parameters.AddWithValue("@APELLIDO_PATERNO", cliente.APELLIDO_PATERNO);
                cmd.Parameters.AddWithValue("@APELLIDO_MATERNO", cliente.APELLIDO_MATERNO);
                cmd.Parameters.AddWithValue("@TEL_CLIENTE", cliente.TEL_CLIENTE);
                cmd.Parameters.AddWithValue("@ESTADO_CLIENTE", cliente.ESTADO_CLIENTE);
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

        //EDITAR CLIENTE NATURAL
        public Boolean EditarClienteNatural(entClienteNatural cliente)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_CLIENTE_NATURAL", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", cliente.ID_CLIENTE);
                cmd.Parameters.AddWithValue("@DNI", cliente.DNI);
                cmd.Parameters.AddWithValue("@NOMBRE_CLI", cliente.NOMBRE_CLI);
                cmd.Parameters.AddWithValue("@APELLIDO_PATERNO", cliente.APELLIDO_PATERNO);
                cmd.Parameters.AddWithValue("@APELLIDO_MATERNO", cliente.APELLIDO_MATERNO);
                cmd.Parameters.AddWithValue("@TEL_CLIENTE", cliente.TEL_CLIENTE);
                cmd.Parameters.AddWithValue("@ESTADO_CLIENTE", cliente.ESTADO_CLIENTE);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
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
                cmd.Connection.Close();
            }
            return edita;
        }

        //DEHABILITAR CLIENTE NATURAL
        public Boolean DeshabilitarClienteNatural(entClienteNatural cliente)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_CLIENTE_NATURAL", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", cliente.ID_CLIENTE);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
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
            return deshabilita;
        }
    }
}

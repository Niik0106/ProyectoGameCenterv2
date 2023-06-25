using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class datCliente
    {
        public List<entCliente> BuscarClientePorID(int idCliente)
        {
            List<entCliente> clientes = new List<entCliente>();
            SqlConnection cn = Conexion.Instancia.Conectar();
            {
                cn.Open();

                SqlCommand command = new SqlCommand("BuscarClientePorID", cn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDCliente", idCliente);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    entCliente cliente = new entCliente();
                    cliente.ID_CLIENTE = reader.GetInt32(0);
                    cliente.Identificacion = reader.GetString(1);
                    clientes.Add(cliente);
                }

                reader.Close();
            }

            return clientes;
        }
    }
}

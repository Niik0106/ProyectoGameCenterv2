using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class logCliente
    {
        private datCliente clienteData;

        public logCliente()
        {
            clienteData = new datCliente();
        }
        public string ObtenerIdentificacionClientePorID(int idCliente)
        {
            List<entCliente> clientes = clienteData.BuscarClientePorID(idCliente);

            if (clientes.Count > 0)
            {
                return clientes[0].Identificacion;
            }
            else
            {
                return null;
            }
        }
    }
}

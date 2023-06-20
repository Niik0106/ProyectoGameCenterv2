using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logClienteJuridico
    {
        private static readonly logClienteJuridico _instancia = new logClienteJuridico();

        public static logClienteJuridico Instancia
        {
            get { return logClienteJuridico._instancia; }
        }

        ///listado
        public List<entClienteJuridico> ListaClienteJuridico()
        {
            return datClienteJuridico.Instancia.ListarClienteJuridico();
        }
        ///inserta
        public Boolean InsertaClienteJuridico(entClienteJuridico ClienteJ)
        {
            return datClienteJuridico.Instancia.InsertarClienteJuridico(ClienteJ);
        }
        //edita
        public Boolean EditaClienteJuridico(entClienteJuridico ClienteJ)
        {
            return datClienteJuridico.Instancia.EditarClienteJuridico(ClienteJ);
        }
        //inhabilitar
        public void DeshabilitarClienteJuridico(entClienteJuridico ClienteJ)
        {
            datClienteJuridico.Instancia.DeshabilitarClienteJuridico(ClienteJ);
        }
    }
}

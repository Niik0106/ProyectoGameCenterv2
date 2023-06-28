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

        public List<entClienteJuridico> BuscarDniClienteJuridico(entClienteJuridico Cli)
        {
            return datClienteJuridico.Instancia.BuscarDniClienteJuridico(Cli);
        }

        ///listado
        public List<entClienteJuridico> ListaClienteJuridico()
        {
            return datClienteJuridico.Instancia.ListarClienteJuridico();
        }
        ///inserta
        public void InsertaClienteJuridico(entClienteJuridico ClienteJ)
        {
            datClienteJuridico.Instancia.InsertarClienteJuridico(ClienteJ);
        }
        //edita
        public void EditaClienteJuridico(entClienteJuridico ClienteJ)
        {
            datClienteJuridico.Instancia.EditarClienteJuridico(ClienteJ);
        }
        //inhabilitar
        public void DeshabilitarClienteJuridico(entClienteJuridico ClienteJ)
        {
            datClienteJuridico.Instancia.DeshabilitarClienteJuridico(ClienteJ);
        }
    }
}

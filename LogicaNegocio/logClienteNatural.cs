using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logClienteNatural
    {
        private static readonly logClienteNatural _instancia = new logClienteNatural();

        public static logClienteNatural Instancia
        {
            get { return logClienteNatural._instancia; }
        }

        //Buscar DNI Cliente pero que regrese un entClienteNatural
        public List<entClienteNatural> BuscarDniClienteNatural(entClienteNatural Cli)
        {
            return datClienteNatural.Instancia.BuscarDniClienteNatural(Cli);
        }

        ///listado
        public List<entClienteNatural> ListarClienteNatural()
        {
            return datClienteNatural.Instancia.ListarClienteNatural();
        }

        //Insertar
        public void InsertarClienteNatural(entClienteNatural cliente)
        {
            datClienteNatural.Instancia.InsertarClienteNatural(cliente);
        }

        //Editar
        public void EditarClienteNatural(entClienteNatural cliente)
        {
            datClienteNatural.Instancia.EditarClienteNatural(cliente);
        }

        //Inhabilitar
        public void DeshabilitarClienteNatural(entClienteNatural cliente)
        {
            datClienteNatural.Instancia.DeshabilitarClienteNatural(cliente);
        }
    }
}

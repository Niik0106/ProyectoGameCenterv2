using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class logProducto
    {
        private static readonly logProducto _instancia = new logProducto();

        public static logProducto Instancia
        {
            get { return logProducto._instancia; }
        }

        ///listado
        public List<entProducto> ListaProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        ///inserta
        public void InsertaProducto(entProducto Prod)
        {
            datProducto.Instancia.InsertarProducto(Prod);
        }
        //edita
        public void EditaProducto(entProducto Prod)
        {
            datProducto.Instancia.EditarProducto(Prod);
        }
        //inhabilitar
        public void DeshabilitarProducto(entProducto Prod)
        {
            datProducto.Instancia.DeshabilitarProducto(Prod);
        }

        //public entProducto BuscarIDProducto(int idProducto)
        //{
        //    return datProducto.Instancia.BuscarIDProducto(idProducto);
        //}

        public List<entProducto> BuscaDescProducto(entProducto Prod)
        {
            return datProducto.Instancia.BuscarDescProducto(Prod);
        }

    }
}

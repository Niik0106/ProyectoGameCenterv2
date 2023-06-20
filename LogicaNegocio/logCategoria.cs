using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class logCategoria
    {
        private static readonly logCategoria _instancia = new logCategoria();
        
        public static logCategoria Instancia
        {
            get { return logCategoria._instancia; }
        }

        ///listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }
        ///inserta
        public void InsertaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.InsertarCategoria(Cat);
        }
        //edita
        public void EditaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.EditarCategoria(Cat);
        }
        //inhabilitar
        public void DeshabilitarCiudad(entCategoria Cat)
        {
            datCategoria.Instancia.DeshabilitarCategoria(Cat);
        }
    }
}

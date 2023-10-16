using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class logUsuarios
    {

        private static readonly logUsuarios _instancia = new logUsuarios();

        public static logUsuarios Instancia
        {
            get { return logUsuarios._instancia; }
        }

        ///listado
        public List<entUsuarios> ListarUsuario()
        {
            return datUsuarios.Instancia.ListarUsuarios();
        }

        ///AGREGAR
        ///
        public void InsertaUsuario(entUsuarios User)
        {
            datUsuarios.Instancia.InsertarUsuario(User);
        }
        ////editar
        ///
        public void EditaUsuarios(entUsuarios User)
        {
            datUsuarios.Instancia.EditarUsuario(User);
        }
        //inhabilitar

        public void DeshabilitarUsuario(entUsuarios User)
        {
            datUsuarios.Instancia.DeshabilitarUsuario(User);
        }



    }
}

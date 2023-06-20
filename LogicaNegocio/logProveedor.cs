using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;


namespace LogicaNegocio
{
    public class logProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        ///listado
        public List<entProveedor> ListaProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        ///inserta
        public Boolean InsertaProveedor(entProveedor Prov)
        {
            return datProveedor.Instancia.InsertarProveedor(Prov);

        }

        ///Modificar
        public Boolean EditaProveedor(entProveedor Prov)
        {
            return datProveedor.Instancia.EditarProveedor(Prov);

        }

        ////Inhabilitar
        ///
        public void InhabilitaProveedor(entProveedor Prov)
        {
            datProveedor.Instancia.InhabilitarProveedor(Prov);
        }


    }
}

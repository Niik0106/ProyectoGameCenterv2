using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class logMarca
    {
        private static readonly logMarca _instancia = new logMarca();

        public static logMarca Instancia
        {
            get { return logMarca._instancia; }
        }

        ///listado
        public List<entMarca> ListarMarca()
        {
            return datMarca.Instancia.ListarMarca();
        }

        ///AGREGAR
        ///
        public void InsertaMarca(entMarca Marca)
        {
            datMarca.Instancia.InsertarMarca(Marca);
        }
        ////editar
        ///
        public void EditaMarca(entMarca Marca)
        {
            datMarca.Instancia.EditarMarca(Marca);
        }
        //inhabilitar

        public void DeshabilitaMarca(entMarca marca)
        {
            datMarca.Instancia.DeshabilitarMarca(marca);
        }

    }
}

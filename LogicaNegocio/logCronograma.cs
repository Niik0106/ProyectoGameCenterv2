using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class logCronograma
    {
        private static readonly logCronograma _instancia = new logCronograma();
        public static logCronograma Instancia
        {
            get { return logCronograma._instancia; }
        }

        public List<entCronograma> ListaCronograma()
        {
            return datCronograma.Instancia.ListarCronograma();
        }

        public void InsertaCronograma(entCronograma Crono)
        {
            datCronograma.Instancia.InsertarCronograma(Crono);
        }

    }
}

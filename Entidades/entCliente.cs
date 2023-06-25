using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entCliente
    {

        public int ID_CLIENTE { get; set; }
        public string TEL_CLIENTE { get; set; }
        public int COD_UBIGEO { get; set; }
        public string DIR_CLIENTE { get; set; }
        public Boolean ESTADO_CLIENTE { get; set; }

        public string Identificacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entClienteJuridico
    {
        public int ID_CLIENTE { get; set; }
        public string RUC_CLIENTE_J { get; set; }
        public string RAZON_SOCIAL_CLIENTE_J { get; set; }
        public string TEL_CLIENTE_J { get; set; }
        public int COD_UBIGEO { get; set; }
        public string DIR_CLIENTE_J { get; set; }
        public Boolean ESTADO_CLIENTE_J { get; set; }
    }
}

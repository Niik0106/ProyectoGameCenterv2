using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entClienteJuridico : entCliente
    {
        public string RUC_CLIENTE { get; set; }
        public string RAZON_SOCIAL { get; set; }
    }
}

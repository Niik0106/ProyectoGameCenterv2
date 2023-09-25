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
        public string DIRECCION { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string PROVINCIA { get; set; }
        public string DISTRITO { get; set; }
    }
}

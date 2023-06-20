using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entClienteNatural :  entCliente
    {
        public string DNI { get; set; }
        public string NOMBRE_CLI { get; set; }
        public string APELLIDO_CLI { get; set; }
    }
}

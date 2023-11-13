using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entNotaEntrada
    {
        public int idNotaEntrada { get; set; }
        public int numNotaEntrada { get; set; }
        public DateTime fechaEmision { get; set; }
        public int numOrdenCompra { get; set; }
        public Boolean estado { get; set; }

    }
}

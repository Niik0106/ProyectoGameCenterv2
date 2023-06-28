using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entNotaSalida
    {
        public int idNotaSalida { get; set; }
        public int numNotaSalida { get; set; }
        public DateTime fechaEmision { get; set; }
        public int numOrdenVenta { get; set; }
        public Boolean estado { get; set; }

    }
}

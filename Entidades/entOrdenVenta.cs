using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entOrdenVenta
    {
        public int idOrdenVenta { get ; set; }
        public int numOrdenVenta { get; set;}
        public DateTime fechaOrden { get; set; }
        public int idCliente { get; set; }
        public int estOrdenVenta { get; set;}
        public int idUsuario { get; set;}
    }
}

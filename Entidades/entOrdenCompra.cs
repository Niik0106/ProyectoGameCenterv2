using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entOrdenCompra
    {
        public int idOrdenCompra { get; set; }
        public int numeroOrdenCompra { get; set; }
        public DateTime fechaOrdenCompra { get; set; }
        public int idProveedor { get; set; }
        public int idEstadoOrdenCompra { get; set; }
        public DateTime fechaAtendida { get; set; }
    }
}

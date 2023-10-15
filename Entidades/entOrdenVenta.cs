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
        public string numOrdenVenta { get; set;}
        public DateTime fechaOrden { get; set; }
        public int idCliente { get; set; }
        public int estOrdenVenta { get; set;}
        public string num_documento { get; set; }

        public int idTipoComprobante { get; set; }
        public string des_comprobante { get; set; }
    }
}

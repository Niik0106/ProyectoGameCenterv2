using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entDetalleOrdenVenta
    {

        public int NUM_ORDEN_VENTA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal PRECIO { get; set;}
        public decimal TOTAL { get; set; }
    }
}

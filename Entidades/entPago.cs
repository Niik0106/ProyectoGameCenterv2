using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entPago
    {
        public int ID_PAGO {  get; set; } 
        public string NUM_ORDEN_VENTA {  get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal IGV { get; set; }
        public decimal TOTAL { get; set; }
        public int ID_METODO_PAGO { get; set; }
        public int ID_TIPO_PAGO { get; set; }
        public entMetodoPago metodoPago { get; set; }
    }
}

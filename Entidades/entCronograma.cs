using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entCronograma
    {
        public int ID_CRONOGRAMA_PAGO { get; set; }
        public DateTime FECHA_VENTA { get; set; }
        public int NUM_ORDEN_VENTA { get; set; }
        public int ID_CLIENTE { get; set; }
        public decimal TOTAL { get; set; }
        public int NUM_CUOTAS { get; set; }
        public int ID_METODO_PAGO { get; set; }
        public DateTime FEC_PLAZO_PAGO { get; set; }
        public int ID_ESTADO_PAGO { get; set; }
        public string OBSERVACIONES { get; set; }
    }
}

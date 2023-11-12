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
        public string razonSocial { get; set; }
        public int idEstadoOrdenCompra { get; set; }
        public string RUC { get; set; }
        public string nombreEstadoOrdenCompra { get; set; }
       
    }
}

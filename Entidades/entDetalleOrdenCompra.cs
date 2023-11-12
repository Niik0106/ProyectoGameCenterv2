using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entDetalleOrdenCompra
    {
        public int NumOrdenCompra { get; set; }
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entProducto
    {
        public int idProducto { get; set; }
        public string desProducto { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public decimal precioProd { get; set; }
        public int stockProd { get; set; }
        public Boolean estProducto { get; set; }
    }
}

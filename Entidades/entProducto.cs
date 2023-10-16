using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entProducto
    {
        public int ID_PRODUCTO { get; set; }
        public string DES_PRODUCTO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public int ID_MARCA { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public decimal PRECIO_COMPRA { get; set; }
        public int STOCK { get; set; }
        public Boolean ESTADO_PRODUCTO { get; set; }
    }
}

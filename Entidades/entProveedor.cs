using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entProveedor
    {
            public int ID_PROVEEDOR { get; set; }
            public string RUC_PROV { get; set; }
            public string RAZON_SOCIAL_PROV { get; set; }
            public string TEL_PROVEEDOR { get; set; }
            public int COD_UBIGEO { get; set; }
            public string DIR_PROVEEDOR { get; set; }
            public string NUM_CUENTA { get; set; }
            public Boolean ESTADO_PROVEEDOR { get; set; }

    }
}

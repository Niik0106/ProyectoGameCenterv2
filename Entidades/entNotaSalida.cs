﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entNotaSalida
    {
        public int idNotaSalida { get; set; }
        public int numNotaSalida { get; set; }
        public DateTime fechaEmision { get; set; }
        public string numOrdenVenta { get; set; }
        public int estado { get; set; }

    }
}

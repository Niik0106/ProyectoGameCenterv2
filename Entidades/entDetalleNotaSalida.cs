﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entDetalleNotaSalida
    {
        public int Num_NotaSalida { get; set; }
        public int ID_Producto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}

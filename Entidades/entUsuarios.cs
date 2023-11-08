using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entUsuarios
    {

        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Usuario { get; set;}
        public string Clave { get; set; }
        public int IdRol { get; set; }

        public string NombreRol { get; set; }
        public Boolean estado { get; set; }
    }

}

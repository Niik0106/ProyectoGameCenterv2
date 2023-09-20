using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

namespace LogicaNegocio
{
    public class logDniRuc
    {
        private datApiDniRuc apiDniRuc;

        public logDniRuc()
        {
            apiDniRuc = new datApiDniRuc();
        }

        public entDatosDni ObtenerDatosDNI(string dni)
        {
            string url = "https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRvZ2V6X3lvdXR1YmVyMTZAaG90bWFpbC5jb20ifQ.vEML8po9xpReNEqgAssccVyYzGkpXLO6V0fFjBqiI1k";

            dynamic respuesta = apiDniRuc.Get(url);

            entDatosDni datosDNI = new entDatosDni
            {
                Nombres = respuesta.nombres.ToString(),
                ApellidoPaterno = respuesta.apellidoPaterno.ToString(),
                ApellidoMaterno = respuesta.apellidoMaterno.ToString(),
                DNI = respuesta.dni.ToString()
            };

            return datosDNI;
        }

        public entDatosRuc ObtenerDatosRUC(string ruc)
        {
            string url = "https://dniruc.apisperu.com/api/v1/ruc/" + ruc + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRvZ2V6X3lvdXR1YmVyMTZAaG90bWFpbC5jb20ifQ.vEML8po9xpReNEqgAssccVyYzGkpXLO6V0fFjBqiI1k";

            dynamic respuesta = apiDniRuc.Get(url);

            entDatosRuc datosRUC = new entDatosRuc
            {
                Direccion = respuesta.direccion.ToString(),
                RazonSocial = respuesta.razonSocial.ToString(),
                Departamento = respuesta.departamento.ToString(),
                Provincia = respuesta.provincia.ToString(),
                Distrito = respuesta.distrito.ToString(),
                Estado = respuesta.estado.ToString(),
                RUC = respuesta.ruc.ToString()
            };

            return datosRUC;
        }
    }
}

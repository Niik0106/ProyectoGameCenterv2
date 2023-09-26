using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.IO;
using System.Net;
using System.Web;
using RestSharp;
using Newtonsoft.Json;


namespace LogicaNegocio
{
    public class logDniRuc
    {
        private datApi apiDniRuc;

        public logDniRuc()
        {
            apiDniRuc = new datApi();
        }

        public entDatosDni ObtenerDatosDNI(string dni)
        {
            string url = "https://apiperu.dev/api/dni/" + dni + "?token=c914dd400dbf2407371906c2f879857c693a45611b037de5b09f53c23b584013";

            dynamic respuesta = apiDniRuc.Get(url);

            entDatosDni datosDNI = new entDatosDni
            {
                Nombres = respuesta.nombres.ToString(),
                ApellidoPaterno = respuesta.apellido_paterno.ToString(),
                ApellidoMaterno = respuesta.apellido_materno.ToString(),
                DNI = respuesta.numero.ToString()
            };

            return datosDNI;
        }

        public entDatosRuc ObtenerDatosRUC(string ruc)
        {
            string url = "https://apiperu.dev/api/ruc/" + ruc + "?token=c914dd400dbf2407371906c2f879857c693a45611b037de5b09f53c23b584013";

            dynamic respuesta = apiDniRuc.Get(url);

            entDatosRuc datosRUC = new entDatosRuc
            {
                Direccion = respuesta.direccion.ToString(),
                RazonSocial = respuesta.nombre_o_razon_social.ToString(),
                Departamento = respuesta.departamento.ToString(),
                Provincia = respuesta.provincia.ToString(),
                Distrito = respuesta.distrito.ToString(),
                Estado = respuesta.estado.ToString(),
                RUC = respuesta.ruc.ToString()
            };

            return datosRUC;
        }

        public static dynamic Post(string url, string json, string autorizacion = null)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                var client = new RestClient(url);
                client.Timeout = 160000;

                var request = new RestRequest(Method.POST);
                request.Timeout = 160000;
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }

                IRestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return datos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la llamada a la API: " + ex.Message);
                return "";
            }
        }

        public static bool Base64ToFile(string base64, string ruta)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64);
                File.WriteAllBytes(ruta, bytes);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar archivo: " + ex.Message);
                return false;
            }
        }


    }
}

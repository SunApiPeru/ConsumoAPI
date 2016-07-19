using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ConRest_HttpWebRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizamos la peticion
            HttpWebRequest request;
            request = WebRequest.Create("https://sunapiperu.com/api_qa/contribuyente?apikey=sunapi&nombre=bar restaurant") as HttpWebRequest;
            request.Timeout = 10 * 1000;
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";

            //Obtenemos la respuesta del servidor
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string body = reader.ReadToEnd(); // obtenemos cadena json

            dynamic ObjetJs = JsonConvert.DeserializeObject(body); // convertimos la cadena json en objetos json

            foreach (var item in ObjetJs)
            {
                Objeto obj = new Objeto(item);
                Console.WriteLine("Ruc:{0},Estado;{1},Nombre:{2},Departamento:{3},Provincia:{4},Distrito:{5},Calle:{6},Numero{7},Ubicacion Geografica:{2},Mapa:{2},", obj.ruc, obj.estado, obj.nombre, obj.departamento, obj.provincia, obj.distrito, obj.calle, obj.numero, obj.ubigeo, obj.mapa);
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }

    class Objeto
    {
        public Objeto(dynamic json)
        {
            #region Deserializar json

            ruc = (long)json.ruc;
            estado = json.estado;
            nombre = json.nombre;
            departamento = json.departamento;
            provincia = json.provincia;
            distrito = json.distrito;
            calle = json.calle;
            numero = json.numero;
            ubigeo = json.ubigeo;
            mapa = json.mapa;

            #endregion Deserializar json
        }

        public long ruc { set; get; }
        public string estado { set; get; }
        public string nombre { set; get; }
        public string departamento { set; get; }
        public string provincia { set; get; }
        public string distrito { set; get; }
        public string calle { set; get; }
        public string numero { set; get; }
        public int ubigeo { set; get; }
        public string mapa { set; get; }

    }
}

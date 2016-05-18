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
            request = WebRequest.Create("https://sunapiperu.com/api/contribuyente?nombre=Discoteca&apikey=iwqoat87igiazot5by2metoqc9e2npvikag1h1rj") as HttpWebRequest;
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
                Console.WriteLine("Ruc:{0},Estado;{1},Nombre:{2},Calle:{3},Numero{4}", obj.ruc, obj.estado, obj.nombre, obj.calle, obj.numero);
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
            calle = json.calle;
            numero = json.numero;

            #endregion Deserializar json
        }

        public long ruc { set; get; }
        public string estado { set; get; }
        public string nombre { set; get; }
        public string calle { set; get; }
        public string numero { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace ConsRest_WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string body = client.DownloadString("https://sunapiperu.com/api/contribuyente?nombre=bar restaurant&apikey=iwqoat87igiazot5by2metoqc9e2npvikag1h1rj");

            #region Obtener Respuesta REST            

            dynamic ObjetJs = JsonConvert.DeserializeObject(body); // convertimos la cadena json en objetos json

            foreach (var item in ObjetJs)
            {
                Objeto obj = new Objeto(item);
                Console.WriteLine("Ruc:{0},Estado;{1},Nombre:{2},Calle:{3},Numero{4}", obj.ruc, obj.estado, obj.nombre, obj.calle, obj.numero);
                Console.WriteLine("\n");
            }

            Console.ReadLine();

            #endregion Obtener Respuesta REST
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

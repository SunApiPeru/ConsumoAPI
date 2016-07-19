using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using WebForms;
using WebForms.Modelo;
using Newtonsoft.Json;


namespace WebForms
{
    public partial class _Default : Page
    {
        //public List<Persona> personas {get;set;}

       
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
         
        protected void btnHttpWebRequest_Click(object sender, EventArgs e)
        {

            #region Peticion Rest

            // Realizamos la peticion
            HttpWebRequest request;
            request = WebRequest.Create("https://sunapiperu.com/api_qa/contribuyente?apikey=sunapi&nombre=bar restaurant") as HttpWebRequest;
            request.Timeout = 10 * 1000;
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";

            #endregion Peticion Rest

            #region Obtenemos Result

            //Obtenemos la respuesta del servidor
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string body = reader.ReadToEnd(); // obtenemos cadena json 
            dynamic ObjetJs = JsonConvert.DeserializeObject(body); // convertimos la cadena json en objetos json
            List<Objeto> ListaObjetos = new List<Objeto>();

            #endregion Obtenermos Result

            MostrarDatos(ObjetJs, ListaObjetos);
        }       
        

        protected void btnWebClient_Click(object sender, EventArgs e)
        {
            #region Peticion REST
            
            WebClient client = new WebClient();
            string body = client.DownloadString("https://sunapiperu.com/api_qa/contribuyente?apikey=sunapi&nombre=bar restaurant");          

            dynamic ObjectJs = JsonConvert.DeserializeObject(body); // convertimos la cadena json en objetos json
            List<Objeto> ListaObject = new List<Objeto>();

            #endregion Peticion REST

            MostrarDatos(ObjectJs,ListaObject);
        }

        private void MostrarDatos(dynamic ObjetJs, List<Objeto> ListaObjetos)
        {
            foreach (var item in ObjetJs)
            {
                Objeto obj = new Objeto(item);
                ListaObjetos.Add(obj);
            }

            GridView3.DataSource = ListaObjetos;
            GridView3.DataBind();
        }

        private void LimpiarGrid()
        {
            GridView3.DataSource = new List<Objeto>();
            GridView3.DataBind();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarGrid();
        }

    }
} 
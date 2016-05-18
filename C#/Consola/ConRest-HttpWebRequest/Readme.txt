*/////////////////////////////////////////*********************

Agregado de Librerias(DLL)

1.System.Net: En este espacio de nombre se encuentran las clases "HttpWebRequest-HttpWebResponse" que se usan para Petición-Respuesta respectivamente del Recurso Rest expuesto en el servidor de SunApiPeru.

2.Newtonsoft.Json: En este espacio de nombre se encuentra la clase "JsonConvert" que es la encargada de deserializar la cadena Json que devuelve el servicio a Objetos "Json".Esta libreria hay que descagarla


Realizando Petición del Servicio

1.HttpWebRequest
-WebRequest.Create("https://sunapiperu.com/api/contribuyente?nombre=bar restaurant&apikey=iwqoat87igiazot5by2metoqc9e2npvikag1h1rj") as HttpWebRequest


Deserializar Respuesta Json
-JsonConvert.DeserializeObject(body); // convertimos la cadena json en objetos json


Luego de Obtener los resultados de la deserializacion del json a objetos C#, mostramos el resultado en la consola.Esperamos que les sirva el ejemplo

Equipo:SunApiPeru*******************//////////////////////////////
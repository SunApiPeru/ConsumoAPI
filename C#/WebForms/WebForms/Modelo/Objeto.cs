using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Modelo
{
    public class Objeto
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.App_Start
{
    public class Persona
    {
        private int id;
        private string nombre ;
        private string apellidos ;
        private string direccion ;
        private int telefono;

        public Persona(string pNombre, string pApellidos, string pDireccion, int pTelefono)
        {
            
            this.nombre = pNombre;
            this.apellidos = pApellidos;
            this.direccion = pDireccion;
            this.telefono = pTelefono;
        }

       

        public string Nombre {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellidos
        {
            set { apellidos = value; }
            get { return apellidos; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
       
    }
}
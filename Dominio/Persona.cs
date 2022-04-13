using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Persona
    {
        private static int idAuto = 0;
        //Atributos
        private int id;
        private string nombre;
        private string apellido;

        //Propertys
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        //Constructor
        public Persona(string nombre, string apellido)
        {
            this.id = ++idAuto;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //Validaciones
        public bool ValidarPersona()
        {
            return ValidarNombrePersona() && ValidarApellido();
        }

        public bool ValidarNombrePersona()
        {
            return !string.IsNullOrEmpty(this.nombre) && EncontrarNumero(this.Nombre);
        }

        public bool ValidarApellido()
        {
            return !string.IsNullOrEmpty(this.apellido) && EncontrarNumero(this.apellido);
        }

        //Cerciora que un texto no contenga numeros.
        public bool EncontrarNumero(string palabra)
        {
            bool exito = true;
            int i = 0;
            do
            {
                char letra = palabra[i];
                if(letra >= '0' && letra <= '9')
                {
                    exito = false;
                }
                i++;
            } while (exito && i < palabra.Length);

            return exito;
        }


    }
}

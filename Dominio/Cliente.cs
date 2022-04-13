using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
    public class Cliente : Persona
    {
        //Atributos
        private string mail;
        private string password;

        //Propertys
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //Constructor
        public Cliente(string mail, string password, string nombre, string apellido) : base (nombre, apellido)
        {
            this.mail = mail;
            this.password = password;
        }

        //Validaciones
        public bool ValidarCliente()
        {
            return ValidarMail() && ValidarPassword() && ValidarPersona();
        }

        //Valida el mail. "System.ComponentModel.DataAnnotations" provee clases de atributos que se usan para definir metadatos para controles
        // de datos. En este caso EmailAddressAtribute inicializa una nueva instancia de su clase
        // que valida direcciones de correo.
        public bool ValidarMail()
        {
            var testerDeEmail = new EmailAddressAttribute();
            bool exito = testerDeEmail.IsValid(this.mail);
            return exito;
        }

        //LLama a todos los metodos utilizados para validar el password
        //Longitud de password, si contiene una minuscula, una mayuscula y un numero.
        public bool ValidarPassword()
        {
            if (this.password.Length >= 6)
            {
                if (BuscarMinuscula())
                {
                    if (BuscarMayuscula())
                    {
                        if (BuscarNumero())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //Valida que el password contenga al menos una minuscula.
        public bool BuscarMinuscula()
        {
            bool exito = false;
            int i = 0;
            do
            {
                char letra = this.password[i];
                if (letra >= 'a' && letra <= 'z')
                {
                    exito = true;
                }
                i++;
            } while (!exito && i < this.password.Length);
            return exito;
        }

        //Valida que el password contenga al menos una mayuscula.
        public bool BuscarMayuscula()
        {
            bool exito = false;
            int i = 0;
            do
            {
                char letra = this.password[i];
                if (letra >= 'A' && letra <= 'Z')
                {
                    exito = true;
                }
                i++;
            } while (!exito && i < this.password.Length);
            return exito;
        }

        //Valida que el password contenga al menos un numero.
        public bool BuscarNumero()
        {
            bool exito = false;
            int i = 0;
            do
            {
                char letra = this.password[i];
                if (letra >= '0' && letra <= '9')
                {
                    exito = true;
                }
                i++;
            } while (!exito && i < this.password.Length);
            return exito;
        }

        //Equals
        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return obj != null && Id == cliente.Id;
        }

        //Tostring
        public override string ToString()
        {
            return $"CLIENTE: {base.Apellido} {base.Nombre} || ID :{base.Id} || EMAIL : {mail} ";
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Mozo : Persona
    {
        private static int numFuncionarioAuto = 0;
        //Atributos
        private int numFuncionario;

        //Propertys
        public int NumFuncionario
        {
            get { return numFuncionario; }
            set { numFuncionario = value; }
        }

        //Constructor
        public Mozo(string nombre, string apellido) : base( nombre, apellido)
        {
            this.numFuncionario = ++numFuncionarioAuto;
        }

        //Validaciones
        public bool ValidarMozo()
        {
            return ValidarPersona();
        }

        //ToString
        public override string ToString()
        {
            return $" {base.Apellido} {base.Nombre} Funcionario Numero : {numFuncionario}"; 
        }

        //Equals
        public override bool Equals(object obj)
        {
            Mozo mozo = obj as Mozo;
            return obj != null && numFuncionario == mozo.numFuncionario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Repartidor : Persona
    {
        //Atributos
        private string tipoDeVehiculo;

        //Propertys
        public string TipoDeVehiculo
        {
            get { return tipoDeVehiculo; }
            set { tipoDeVehiculo = value; }
        }

        //Constructor
        public Repartidor(string tipoDeVehiculo, string nombre, string apellido) : base(nombre, apellido)
        {
            this.tipoDeVehiculo = tipoDeVehiculo;
        }

        //Validaciones
        public bool ValidarRepartidor()
        {
            return ValidarPersona();
        }

        //Equals
        public override bool Equals(object obj)
        {
            Repartidor repartidor = obj as Repartidor;
            return obj != null && Id == repartidor.Id;
        }

        public override string ToString()
        {
            return $"{base.Apellido} {base.Nombre} TIPO : {tipoDeVehiculo}"; 
        }
    }
}

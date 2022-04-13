using System;

namespace Dominio
{
    public class Plato
    {
        //Atributos
        private static decimal precioMinimo = 200;

        private int id;
        private string nombre;
        private decimal precio;

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

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public decimal PrecioMinimo
        {
            get { return precioMinimo; }
            set { precioMinimo = value; }
        }

        //Constructor
        public Plato(int id, string nombre, decimal precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        //Validaciones
        public bool ValidarPlato()
        {
            return ValidarNombrePlato() && ValidarPrecio();
        }

        public bool ValidarNombrePlato()
        {
            return !string.IsNullOrEmpty(this.nombre);
        }

        public bool ValidarPrecio()
        {
            return this.precio >= precioMinimo;
        }

        //Equals
        public override bool Equals(object obj)
        {
            Plato plato = obj as Plato;
            return obj != null && id == plato.Id;
        }

        //Tostring
        public override string ToString()
        {
            return $"{id} {nombre} -> ${precio}"; 
        }

        //Cambiar precio minimo de plato
        public static decimal ModificarPrecioMinimo(decimal nuevoPrecio)
        {
            precioMinimo = nuevoPrecio;
            return precioMinimo;
        }





    }
}

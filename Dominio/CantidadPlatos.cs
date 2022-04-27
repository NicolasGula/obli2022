using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class CantidadPlatos
    {
        private int cantidad;
        private Plato plato;

        public CantidadPlatos(int cantidad, Plato plato)
        {
            this.cantidad = cantidad;
            this.plato = plato;
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Plato Plato
        {
            get { return plato; }
            set { plato = value; }
        }

        public override string ToString()
        {
            return $"{cantidad} de {plato.Nombre}";
        }


    }
}

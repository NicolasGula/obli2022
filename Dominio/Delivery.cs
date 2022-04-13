using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Delivery
    {
        private string direccion;
        private Repartidor repartidor;
        private decimal distancia;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Repartidor Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }

        public decimal Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }



    }
}

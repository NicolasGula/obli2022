using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Delivery : Servicio
    {
        private string direccion;
        private Repartidor repartidor;
        private decimal distancia;

        public Delivery(int id, Cliente cliente, DateTime fecha, CantidadPlatos cantidadPlatos, string Direccion, Repartidor repartidor, decimal distancia) : base(id, cliente, fecha, cantidadPlatos)
        {
            this.Direccion = direccion;
            this.Repartidor = repartidor;
            this.Distancia = distancia;
        }

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

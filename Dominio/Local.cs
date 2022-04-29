using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Local : Servicio
    {
        private int numeroMesa;
        private Mozo mozo;
        private int cantidadComensales;
        private decimal precioCubierto;

        public Local(int id, Cliente cliente, DateTime fecha, CantidadPlatos cantidadPlatos, int numeroMesa, Mozo mozo, int cantidadComensales, decimal preciocubierto) : base(id, cliente, fecha, cantidadPlatos)
        {

            this.NumeroMesa = numeroMesa;
            this.Mozo = mozo;
            this.CantidadComensales = cantidadComensales;
            this.PrecioCubierto = precioCubierto;
        }

        public int NumeroMesa
        {
            get { return numeroMesa; }
            set { numeroMesa = value; }
        }


        public Mozo Mozo
        {
            get { return mozo; }
            set { mozo = value; }
        }

        public int CantidadComensales
        {
            get { return cantidadComensales; }
            set { cantidadComensales = value; }
        }

        public decimal PrecioCubierto
        {
            get { return precioCubierto; }
            set { precioCubierto = value; }
        }



    }
}

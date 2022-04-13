using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Local
    {
        private int numeroMesa;
        private Mozo mozo;
        private int cantidadComensales;
        private decimal precioCubierto;

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

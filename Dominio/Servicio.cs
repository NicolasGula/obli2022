using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Servicio
    {
        private Cliente cliente;
        private string tipo;
        private DateTime fecha;

        private List<Plato> platos = new List<Plato>();

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }



    }
}

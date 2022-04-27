using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Servicio
    {
        private Cliente cliente;
        private DateTime fecha;
        private List<CantidadPlatos> cantidadPlatos = new List<CantidadPlatos>();

        protected Servicio(Cliente cliente, DateTime fecha, CantidadPlatos cantPlatos)
        {
            this.cliente = cliente;
            this.fecha = fecha;
            AgregarPlato(cantPlatos);
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
       

       //Todo agregar metodo de agregar cantidad platos
       public bool AgregarPlato(CantidadPlatos cantPlato)
        {
            bool exito = false;
            //Todo validar que no exista, si existe sumar cantidad.
            if(cantPlato.Cantidad > 0)
            {
                cantidadPlatos.Add(cantPlato);
                exito = true;
            }

            return exito;
        }



       
    }
}

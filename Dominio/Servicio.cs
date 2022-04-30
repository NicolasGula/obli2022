using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Servicio
    {
        private int id;
        private Cliente cliente;
        private DateTime fecha;
        private List<CantidadPlatos> cantidadPlatos = new List<CantidadPlatos>();

        protected Servicio(int id, Cliente cliente, DateTime fecha, CantidadPlatos cantPlatos)
        {
            this.id = id;
            this.cliente = cliente;
            this.fecha = fecha;
            AgregarPlato(cantPlatos);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
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


        public CantidadPlatos ObtenerCantidad(CantidadPlatos cantidad)
        {
            foreach (CantidadPlatos item in cantidadPlatos)
            {
                if (item.Plato.Id == cantidad.Plato.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool AgregarPlato(CantidadPlatos cantPlato)
        {
            bool exito = true;
            CantidadPlatos aux = ObtenerCantidad(cantPlato);
            if (aux == null)
            {
                cantidadPlatos.Add(cantPlato);
            }
            else
            {
                aux.Cantidad += cantPlato.Cantidad;
            }

            return exito;
        }

        public override bool Equals(object obj)
        {
            Servicio servicio = obj as Servicio;
            return obj != null && Id == servicio.id;
        }

        public override string ToString()
        {
            return $"NOMBRE CLIENTE: {cliente.Nombre}\nPLATO: {cantidadPlatos[0].Plato}\nCANTIDAD: {cantidadPlatos[0].Cantidad}\nTOTAL: {cantidadPlatos[0].Plato.Precio * cantidadPlatos[0].Cantidad}\nFECHA: {fecha}";
        }

    }
}

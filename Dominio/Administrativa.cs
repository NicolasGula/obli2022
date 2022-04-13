using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Administrativa
    {
        private List<Plato> platos = new List<Plato>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Mozo> mozos = new List<Mozo>();
        private List<Repartidor> repartidores = new List<Repartidor>();
        
        public Administrativa()
        {
            PreCargaPlatos();
            PreCargaClientes();
            PreCargaMozos();
            PreCargaRepartidores();
        }

        //PreCarga de los datos de Platos, Clientes y Mozos.
        private void PreCargaPlatos()
        { 
            CargarPlato(1, "Milanesa", 500);
            CargarPlato(2, "Hamburguesa", 250);
            CargarPlato(3, "Fideos con pesto", 200);
            CargarPlato(4, "Pollo al spiedo", 500);
            CargarPlato(5, "Lasagna", 400);
            CargarPlato(6, "Papas al horno", 600);
            CargarPlato(7, "Gramajo", 700);
            CargarPlato(8, "Nuggets", 200);
            CargarPlato(9, "Pizza con Muzzarella", 430);
            CargarPlato(10, "Chop Suey", 230);
        }

        private void PreCargaClientes()
        {
            CargarCliente("cliente1@gmail.com", "Ab.12345", "Alfredo", "Gomez");
            CargarCliente("cliente2@gmail.com", "Ab.12345", "Lorenzo", "Ansuate");
            CargarCliente("cliente3@gmail.com", "Ab.12345", "Beatriz", "Pereyra");
            CargarCliente("cliente4@gmail.com", "Ab.12345", "Fiorella", "Rodriguez");
            CargarCliente("cliente5@gmail.com", "Ab.12345", "Pepe", "Argento");
        }

        private void PreCargaMozos()
        {
            CargarMozo("Raquel", "Suarez");
            CargarMozo("Ramon", "Fagundez");
            CargarMozo("Rosario", "Figueroa");
            CargarMozo("Raul", "Mauro");
            CargarMozo("Roman", "Couste");
        }

        private void PreCargaRepartidores()
        {
            CargarRepartidor("Moto","Federico", "Baston");
            CargarRepartidor("Bicicleta", "Nahuel", "Larrosa");
            CargarRepartidor("Pie", "Paola", "De los santos");
            CargarRepartidor("Bicicleta", "Penelope", "Cruz");
            CargarRepartidor("Moto", "Federico", "Baston");
        }

        //TODO:Precarga de 10 servicios
        //TODO:Carga de los servicios
        //TODO:Agregar servicios

        //Se instancian las clases y se cargan con los datos.
        public bool CargarPlato(int id, string nombre, decimal precio)
        {
            Plato unPlato;
            unPlato = new Plato(id, nombre, precio);
            return AgregarPlato(unPlato);
        }

        public bool CargarCliente(string mail, string password, string nombre, string apellido)
        {
            Cliente unCliente;
            unCliente = new Cliente(mail, password, nombre, apellido);
            return AgregarCliente(unCliente);
        }

        public bool CargarMozo(string nombre, string apellido)
        {
            Mozo unMozo;
            unMozo = new Mozo(nombre, apellido);
            return AgregarMozo(unMozo);
        }

        public bool CargarRepartidor(string tipoVehiculo, string nombre, string apellido)
        {
            Repartidor unRepartidor;
            unRepartidor = new Repartidor(tipoVehiculo,  nombre,  apellido);
            return AgregarRepartidor(unRepartidor);
        }

        //Luego de validar se agrega el objeto a la lista correspondiente.
        public bool AgregarPlato(Plato unPlato)
        {
            bool exito = false;
            if(unPlato != null && unPlato.ValidarPlato() && !platos.Contains(unPlato))
            {
                platos.Add(unPlato);
                exito = true;
            }
            return exito;
        }

        public bool AgregarCliente(Cliente unCliente)
        {
            bool exito = false;
            if (unCliente != null && unCliente.ValidarCliente() && !clientes.Contains(unCliente))
            {
                clientes.Add(unCliente);
                exito = true;
            }
            return exito;
        }

        public bool AgregarMozo(Mozo unMozo)
        {
            bool exito = false;
            if (unMozo != null && unMozo.ValidarMozo() && !mozos.Contains(unMozo))
            {
                mozos.Add(unMozo);
                exito = true;
            }
            return exito;
        }

        public bool AgregarRepartidor(Repartidor unRepartidor)
        {
            bool exito = false;
            if (unRepartidor != null && unRepartidor.ValidarRepartidor() && !repartidores.Contains(unRepartidor))
            {
                repartidores.Add(unRepartidor);
                exito = true;
            }
            return exito;
        }

        //Listas
        public List<Plato> ListarPlatos()
        {
            List<Plato> aux = new List<Plato>();
            foreach (Plato item in platos)
            {
                aux.Add(item);
            }
            return aux;
        }

        public List<Cliente> ListarClientes()
        {
            ListarPorApellido();
            List<Cliente> aux = new List<Cliente>();
            foreach (Cliente item in clientes)
            {
                aux.Add(item);
            }
            return aux;
        }

        //==================================SOLO PARA PRUEBAS====================================
        public List<Mozo> ListarMozo()
        {
            List<Mozo> aux = new List<Mozo>();
            foreach (Mozo item in mozos)
            {
                aux.Add(item);
            }
            return aux;
        }

        public List<Repartidor> ListarRepartidores()
        {
            List<Repartidor> aux = new List<Repartidor>();
            foreach (Repartidor item in repartidores)
            {
                aux.Add(item);
            }
            return aux;
        }
        //=============================================================================================

        //Este metodo llama a la clase "OrdenarClientePorApellido" a
        //la cual se le implementa la interfaz IComparer
        public void ListarPorApellido()
        {
            clientes.Sort(new OrdenarClientePorApellido());
        }

        public decimal ModificarPrecio(decimal nuevoPrecio)
        {
            return Plato.ModificarPrecioMinimo(nuevoPrecio);
        }
    }

    public class OrdenarClientePorApellido : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            return x.Apellido.CompareTo(y.Apellido);
        }
    }
}

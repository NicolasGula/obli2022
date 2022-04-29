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
        private List<Local> locales = new List<Local>();

        private List<CantidadPlatos> cantidadPlatos = new List<CantidadPlatos>();
        public Administrativa()
        {
            PreCargaPlatos();
            PreCargaClientes();
            PreCargaMozos();
            PreCargaRepartidores();
            //PreCargarCantidadPlatos();
            PreCargaServicios();
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
            CargarRepartidor("Moto", "Federico", "Baston");
            CargarRepartidor("Bicicleta", "Nahuel", "Larrosa");
            CargarRepartidor("Pie", "Paola", "De los santos");
            CargarRepartidor("Bicicleta", "Penelope", "Cruz");
            CargarRepartidor("Moto", "Federico", "Baston");
        }

        //private void PreCargarCantidadPlatos()
        //{
        //    //TODO empezar desde aca.
        //    Plato unPlato = BuscarPlato(2);
        //    if(unPlato != null)
        //    {
        //     CargarCantidadPlatos(unPlato, 4);

        //    }

        //    unPlato = BuscarPlato(4);
        //    if (unPlato != null)
        //    {
        //        CargarCantidadPlatos(unPlato, 3);
        //    }

        //    unPlato = BuscarPlato(3);
        //    if (unPlato != null)
        //    {
        //        CargarCantidadPlatos(unPlato, 1);
        //    }

        //}

        public CantidadPlatos CargarCantidadPlatos(Plato unPlato, int cantidad)
        {
            bool exito = false;

            if (cantidad > 0)
            {
                CantidadPlatos unaCantidad;
                unaCantidad = new CantidadPlatos(cantidad, unPlato);

                return unaCantidad;

            }

            return null;

        }

        public List<CantidadPlatos> Cantidad()
        {
            List<CantidadPlatos> aux = new List<CantidadPlatos>();
            foreach (CantidadPlatos item in cantidadPlatos)
            {
                aux.Add(item);
            }

            return aux;
        }

        public Local BuscarLocal(int id)
        {
            foreach (Local item in locales)
            {
                if (id == item.Id)
                {
                    return item;
                }

            }
            return null;
        }

        public Cliente BuscarCliente(int id)
        {
            foreach (Cliente item in clientes)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }
        public Mozo BuscarMozo(int id)
        {
            foreach (Mozo item in mozos)
            {
                if (id == item.NumFuncionario)
                {
                    return item;
                }
            }
            return null;
        }
        public Plato BuscarPlato(int id)
        {
            foreach (Plato item in platos)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }

            return null;
        }

        private void PreCargaServicios()
        {
            CantidadPlatos unaCantidad;
            Plato unPlato = BuscarPlato(2);
            Cliente unCliente = BuscarCliente(2);
            Mozo unMozo = BuscarMozo(1);
            unaCantidad = CargarCantidadPlatos(unPlato, 4);
            CargarLocal(1, unCliente, new DateTime(), unaCantidad, 4, unMozo, 2, 70);

            unPlato = BuscarPlato(5);
            unCliente = BuscarCliente(3);
            unMozo = BuscarMozo(2);
            unaCantidad = CargarCantidadPlatos(unPlato, 2);
            CargarLocal(2, unCliente, new DateTime(), unaCantidad, 4, unMozo, 2, 70);

            unPlato = BuscarPlato(5);
            unCliente = BuscarCliente(3);
            unMozo = BuscarMozo(2);
            unaCantidad = CargarCantidadPlatos(unPlato, 8);
            CargarLocal(2, unCliente, new DateTime(), unaCantidad, 4, unMozo, 2, 70);



            unPlato = BuscarPlato(1);
            unCliente = BuscarCliente(3);
            unMozo = BuscarMozo(2);
            unaCantidad = CargarCantidadPlatos(unPlato, 8);
            CargarLocal(2, unCliente, new DateTime(), unaCantidad, 4, unMozo, 2, 70);











        }

        public bool CargarLocal(int id, Cliente UnCliente, DateTime unaFecha, CantidadPlatos unaCantidad, int nuemroMesa, Mozo unMozo, int cantComensales, decimal precioCubierto)
        {

            Local unLocal;
            unLocal = new Local(id, UnCliente, unaFecha, unaCantidad, nuemroMesa, unMozo, cantComensales, precioCubierto);

            return AgregarLocal(unLocal, unaCantidad);

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
            unRepartidor = new Repartidor(tipoVehiculo, nombre, apellido);
            return AgregarRepartidor(unRepartidor);
        }

        //Luego de validar se agrega el objeto a la lista correspondiente.
        public bool AgregarPlato(Plato unPlato)
        {
            bool exito = false;
            if (unPlato != null && unPlato.ValidarPlato() && !platos.Contains(unPlato))
            {
                platos.Add(unPlato);
                exito = true;
            }
            return exito;
        }

        public bool AgregarLocal(Local unLocal, CantidadPlatos unaCantidad)
        {

            if (!locales.Contains(unLocal))
            {

                locales.Add(unLocal);

                return true;
            }
            else
            {

                BuscarLocal(unLocal.Id).AgregarPlato(unaCantidad);

            }

            return true;
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

        public List<Local> ListarLocales()
        {
            List<Local> aux = new List<Local>();
            foreach (Local item in locales)
            {
                aux.Add(item);
            }
            return aux;
        }
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

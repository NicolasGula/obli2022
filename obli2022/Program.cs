using System;
using Dominio;

namespace obli2022
{
    class Program
    {

        static Administrativa admin = new Administrativa();

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("OBLIGATORIO 2022 - PROGRAMACION 2");
                Console.WriteLine("=================================");
                Console.WriteLine("1-Listar platos\n 2-Listar clientes ordenados por apellido\n3-Alta Mozo\n4-Lista mozos\n5-Lista Repartidores\n6-Modificar precio minimo");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ListarPlatos();
                        break;
                    case 2:
                        ListarClientesOrdenadosPorApellido();
                        break;
                    case 3:
                        AltaMozo();
                        break;
                    case 4:
                        //SOLO PARA PRUEBAS
                        ListarMozos();
                        break;
                    case 5:
                        //SOLO PARA PRUEBAS
                        ListarRepartidores();
                        break;
                    case 6:
                        ModificarPrecioMinimo();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);

        }

        public static void ListarPlatos()
        {
            Console.WriteLine("\nPLATOS");
            foreach (Plato item in admin.ListarPlatos())
            {
                Console.WriteLine(item);
            }
        }

        public static void ListarClientesOrdenadosPorApellido()
        {
            Console.WriteLine("\nCLIENTES");
            foreach (Cliente item in admin.ListarClientes())
            {
                Console.WriteLine(item);
            }
        }

        public static void AltaMozo()
        {
            Console.WriteLine("\nALTA MOZO\nINGRESAR DATOS...");

            Console.WriteLine("Nombre :");
            string nombre = Console.ReadLine();

            Console.WriteLine("Apellido :");
            string apellido = Console.ReadLine();

            if(admin.CargarMozo(nombre, apellido))
            {
                Console.WriteLine("El mozo fue agregado con exito.");
            }
        }

        //==================================SOLO PARA PRUEBAS=============================
        public static void ListarMozos()
        {
            Console.WriteLine("\nMOZOS");
            foreach (Mozo item in admin.ListarMozo())
            {
                Console.WriteLine(item);
            }
        }

        public static void ListarRepartidores()
        {
            Console.WriteLine("\nREPARTIDORES");
            foreach (Repartidor item in admin.ListarRepartidores())
            {
                Console.WriteLine(item);
            }
        }
        //=================================================================================

        public static void ModificarPrecioMinimo()
        {
            Console.WriteLine("\nMODIFICAR PRECIO MINIMO");

            Console.WriteLine("Ingresar nuevo precio minimo :");
            decimal nuevoPrecio = decimal.Parse(Console.ReadLine());

           
            Console.WriteLine($"Precio minimo ahora es {admin.ModificarPrecio(nuevoPrecio)}");
            
        }
    }
}

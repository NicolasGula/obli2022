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
                Console.WriteLine("1-Listar platos\n2-Listar clientes ordenados por apellido / nombre\n3-Lista de los servicios entregados por un repartidor en un rango de fechas dado\n4-Modificar el valor del precio minimo del plato\n5-Alta mozo\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ListarPlatos();
                        break;
                    case 2:
                        ListarClientesOrdenadosPorApellidoNombre();
                        break;
                    case 3:
                        ListaDeLosServiciosEntregadosPorUnRepartidor();
                        break;
                    case 4:
                        ModificarPrecioMinimo();
                        break;
                    case 5:
                        AltaMozo();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);

        }

        //Muestra en consola la lista de los platos precargados.
        public static void ListarPlatos()
        {
            Console.WriteLine("\nPLATOS");
            foreach (Plato item in admin.ListarPlatos())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }


        //Muestra en consola la lista de los clientes ordenados 
        //alfabeticamente por apellido / nombre
        public static void ListarClientesOrdenadosPorApellidoNombre()
        {
            Console.WriteLine("\nCLIENTES");
            foreach (Cliente item in admin.ListarClientes())
            {
                Console.WriteLine(item);
            }
        }

        //Muestra en consola los servicios entregados por un repartidor
        //en un rango de fechas dado por el usuario.
        public static void ListaDeLosServiciosEntregadosPorUnRepartidor()
        {
            Console.WriteLine("\nSERVICIOS ENTREGADOS POR UN REPARTIDOR");
            Console.WriteLine("Ingrese el id del repartidor");
            int id = int.Parse(Console.ReadLine());
            Repartidor repartidor = admin.BuscarRepartidor(id);

            if (repartidor != null)
            {
                Console.WriteLine("Ingrese un rango de fechas (El formato debe ser ANIO/MES/DIA)\nEjemplos: 2022/12/23 o 2022/2/5");
                DateTime primeraFecha = new DateTime();
                DateTime segundaFecha = new DateTime();

                //Si el formato de la fecha ingresada no es el correcto
                //Lanza la exception y finaliza el metodo.
                try
                {
                    Console.WriteLine("Primera fecha");
                    primeraFecha = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Segunda fecha");
                    segundaFecha = DateTime.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("El formato de la fecha no es el correcto.\nIntentelo nuevamente por favor.");
                    Console.WriteLine();
                }

                //Verifica que la primera fecha ingresada sea menor que la segunda.
                //De lo contrario, cambia sus valores para que se ajusten a los nombre de las variables.
                if (primeraFecha.CompareTo(segundaFecha) == 1)
                {
                    DateTime aux = primeraFecha;
                    primeraFecha = segundaFecha;
                    segundaFecha = aux;
                }

                foreach (Delivery item in admin.BuscarServiciosDeRepartidor(repartidor, primeraFecha, segundaFecha))
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("¡¡¡¡¡Ese repartidor no Existe!!!!!");
            }

        }

        //Permite modificar el valor del precio minimo del plato
        public static void ModificarPrecioMinimo()
        {
            Console.WriteLine("\nMODIFICAR PRECIO MINIMO");

            Console.WriteLine("Ingresar nuevo precio minimo :");
            decimal nuevoPrecio = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Precio minimo ahora es {admin.ModificarPrecio(nuevoPrecio)}");
        }

        //Permite cargar un mozo al sistema
        public static void AltaMozo()
        {
            Console.WriteLine("\nALTA MOZO\nINGRESAR DATOS...");

            Console.WriteLine("Nombre :");
            string nombre = Console.ReadLine();

            Console.WriteLine("Apellido :");
            string apellido = Console.ReadLine();

            if (admin.CargarMozo(nombre, apellido))
            {
                Console.WriteLine("El mozo fue agregado con exito.");
            }
            else
            {
                Console.WriteLine("Los datos ingresados no son correctos.\nIntentelo nuevamente por favor.");
                Console.WriteLine();
            }
        }
    }
}

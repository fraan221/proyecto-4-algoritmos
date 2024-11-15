using System;

namespace proyecto_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Club club = new Club("Boca");

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("-----");
                Console.WriteLine("MENÚ");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1. Dar de alta a un Entrenador");
                Console.WriteLine("2. Dar de baja a un Entrenador");
                Console.WriteLine("3. Dar de alta a un Niño/Socio en un Deporte");
                Console.WriteLine("4. Dar de baja a un Niño/Socio en un Deporte");
                Console.WriteLine("5. Simular el pago de una cuota");
                Console.WriteLine("6. Submenu");
                Console.WriteLine("7. Listado de Deudores");
                Console.WriteLine("8. Agregar un Deporte");
                Console.WriteLine("9. Eliminar un Deporte");
                Console.WriteLine("10. Salir");
                Console.WriteLine("-----------------------------------------------");

                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese el nombre del entrenador:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingrese el dni del entrenador:");
                        int dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el deporte:");
                        string d = Console.ReadLine();
                        Entrenador entrenador = new Entrenador(nombre, dni);
                        club.AgregarEntrenador(entrenador);
                        Console.Write("Ah sido agregado con exito");
                        break;
                    case 2:
                        Console.WriteLine("ingrese el dni del entrenaador:");
                        dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el deporte al que esta asignado:");
                        d = Console.ReadLine();
                        club.EliminarEntrenador(d, dni);
                        Console.WriteLine("Ah sigo dado de baja del club con exito");

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Console.WriteLine("ingrese el nombre del deporte:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("ingrese la categoria:");
                        int categoria = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el cupo maximo:");
                        int cupo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la cantidad de inscriptos:");
                        int cantidadInscriptos = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el costo de la cuota:");
                        double CostoCuota = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el dia en el que se realizara la actividad:");
                        string dia = Console.ReadLine();
                        Console.WriteLine("ingrese la hora en la que se dictara:");
                        string hora = Console.ReadLine();

                        Console.WriteLine("ingrese el nombre del entrenador a cargo de la categoria:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("ingrese el dni del entrenador a cargo de la categoria:");
                        dni = int.Parse(Console.ReadLine());

                        entrenador = new Entrenador(nombre, dni);
                        Deporte deporte = new Deporte(nombre, categoria, cupo, cantidadInscriptos, CostoCuota, dia, hora, entrenador);

                        club.agregarDeporte(deporte, dni);
                        Console.WriteLine("Se agrego el deporte al club de manera correcta");

                        break;
                    case 9:
                        club.listadoSociosDeporte();
                        break;
                    case 10:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Por favor, ingrese una opcion valida.");
                        break;
                }
            }
        }
    }
}
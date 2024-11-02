using System;

namespace proyecto_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Club club = new Club("BOCA");
			
			bool salir = false;
			while(!salir)
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
				
				switch(opcion)
				{
					case 1:
						Console.WriteLine("ingrese el nombre del entrenador:");
						string nombre = Console.ReadLine();
						Console.WriteLine("ingrese el dni del entrenador:");
						int dni = int.Parse(Console.ReadLine());
						
						Entrenador entrenador = new Entrenador(nombre, dni);
						club.agregarEntrenador(entrenador, "futbol");
						Console.Write("Ah sido agregado con exito");
						
						break;
					case 2:
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
						break;
					case 9:
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
using System;

namespace proyecto_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Bienvenido!");
			Console.Write("Desea realizar una accion? s/n: ");
			string d = Console.ReadLine();
			Console.Clear();
			if(d == "s" || d == "S")
			{
				Menu(d);
			}
			else if(d == "n" || d == "N")
			{
				Console.Write("Hasta luego :)");
				Console.ReadKey(true);
			}
			else
			{
				Console.WriteLine("Ingreso una opcion incorrecta. Hasta luego :( \n");
				Console.ReadKey(true);
			}
		}
		
		public static void Submenu(){
			Console.WriteLine("-----");
			Console.WriteLine("SUBMENÚ DE INSCRIPCIÓN");
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("1. Listado por Deporte");
			Console.WriteLine("2. Listado por Deporte y Categoria");
			Console.WriteLine("3. Listado Total");
			Console.WriteLine("4. Volver");
			Console.WriteLine("-----------------------------------------------");
			
			Console.Write("Seleccione una opción: ");
			int opcion = int.Parse(Console.ReadLine());
			Console.Clear();
			
			switch(opcion){
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					Console.Write("Seguro que quiere volver al Menu Principal? s/n: ");
					string decisionSub = Console.ReadLine();
					if(decisionSub == "s" || decisionSub == "S"){
						string d = "n";
						Menu(d);
					}
					else{
						Console.WriteLine("Opcion incorrecta");
						Submenu();
					}
					break;
				default:
					Console.WriteLine("Opcion no valida. Por favor, ingrese una opcion valida.");
					break;
			}
		}
		
		public static void Menu(string decision){
			Club club = new Club("Boca");
			while (decision == "s" || decision == "S")
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

				try{
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
							Submenu();
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
							Console.Write("Seguro que desea terminar? s/n: ");
							string decisionDos = Console.ReadLine();
							if(decisionDos == "s" || decisionDos == "S"){
								decision = "n";
								Console.WriteLine("Hasta luego :)");
								Console.ReadKey(true);
							}
							break;
						default:
							Console.WriteLine("Opcion no valida. Por favor, ingrese una opcion valida.");
							break;
					}
				}
				catch(FormatException)
				{
					Console.Clear();
					Console.WriteLine("Opcion incorrecta :( \n");
				}
			}
		}
	}
}
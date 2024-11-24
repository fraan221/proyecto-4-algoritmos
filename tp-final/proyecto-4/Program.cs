using System;

namespace proyecto_4
{
	class Program
	{
//		Main
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
		
//		Submenu
		public static void Submenu(Club club){
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
					Console.Write("Ingrese el Deporte deseado: ");
					string d = Console.ReadLine();
					club.listadoDeporte(d);
					break;
				case 2:
					club.listadoDeporteCategoria();
					break;
				case 3:
					club.listadoTotal();
					break;
				case 4:
					Console.Write("Seguro que quiere volver al Menu Principal? s/n: ");
					string decisionSub = Console.ReadLine();
					if(decisionSub == "s" || decisionSub == "S"){
						decisionSub = "n";
						Menu(decisionSub);
					}
					else{
						Console.WriteLine("Opcion incorrecta");
						Submenu(club);
					}
					break;
				default:
					Console.WriteLine("Opcion no valida. Por favor, ingrese una opcion valida.");
					break;
			}
		}
		
//		Menu Principal
		public static void Menu(string decision)
		{
//			INICIALIZACIONES DE CLASES DE PRUEBA
			Club club = new Club("Boca");
			Socio socioPrueba=new Socio("Braia", 45619054, 20, "Futbol", 18, "Mes", 2000);
			Socio socioPrueba2=new Socio("Matias", 123213, 12, "Baloncesto", 16, "Mes", 25000);
			Socio socioPrueba3=new Socio("Daniel", 555555, 16, "Voley", 16, "Mes", 10000);
			club.agregarSocio(socioPrueba);
			club.agregarSocio(socioPrueba2);
			club.agregarSocio(socioPrueba3);
			
			
			Entrenador e = new Entrenador("Franco", 44966422);
			Entrenador e1 = new Entrenador("Catriel", 44657432);
			Deporte d = new Deporte("Futbol", 18, 20, 1, 5000, "lunes", "19:00", e);
			Deporte d1 = new Deporte("Baloncesto", 21, 15, 0,10000, "6", "21:00", e1);
			
			club.ListadoEntrenadores.Add(e);
			club.ListadoEntrenadores.Add(e1);
			club.ListadoDeportes.Add(d);
			club.ListadoDeportes.Add(d1);
//			FIN DE LAS INICIALIZACIONES
			
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
				
				try
				{
					Console.Write("Seleccione una opción: ");
					int opcion = int.Parse(Console.ReadLine());
					Console.Clear();
					
					switch (opcion)
					{
						case 1:
							agregarEntrenadorMain(club);
							break;
						case 2:
							eliminarEntrenadorMain(club);
							break;
						case 3:
							agregarSocioMain(club);
							break;
						case 4:
							break;
						case 5:
							simulacionDePagoMain(club);
							break;
						case 6:
							Submenu(club);
							break;
						case 7:
							club.listaSocio();
							break;
						case 8:
							agregarDeporteMain(club);
							break;
						case 9:
							eliminarDeporteMain(club);
							break;
						case 10:
							Console.Write("Seguro que desea terminar? s/n: ");
							string decisionDos = Console.ReadLine();
							if(decisionDos == "s" || decisionDos == "S")
							{
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
		
//		Agregar Entrenador (del main)
		public static void agregarEntrenadorMain(Club club)
		{
			Console.Write("Ingrese el nombre del entrenador: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese el dni del entrenador: ");
			int dni = int.Parse(Console.ReadLine());
			
			if(club.buscarEntrenador(dni) == null)
			{
				Entrenador nuevoEntrenador = new Entrenador(nombre, dni);
				club.agregarEntrenador(nuevoEntrenador);
				Console.WriteLine("Se agrego correctamente el Entrenador \n");
			}
			else
				Console.WriteLine("El Entrenador ingresado ya esta registrado");
		}

//		Eliminar Entrenador (del main)
		public static void eliminarEntrenadorMain(Club club)
		{
			Console.Write("Ingrese el DNI del entrenador para eliminarlo: ");
			int dni = int.Parse(Console.ReadLine());
			Entrenador ent = club.buscarEntrenador(dni); //se busca entrenador
			
			if(ent != null)
				Console.WriteLine("Se elimino el entrenador");
			else
				Console.WriteLine("No se encontro el entrenador");
		}
		
//		Agregar Deporte (del main)
		public static void agregarDeporteMain(Club club){
			Console.Write("Ingrese el nombre del deporte: ");
			string nombre = Console.ReadLine();

			int opcion;
			int categoria;
			Deporte deporte; //	inicializa la clase, por defecto es null
			
			do
			{
				Console.WriteLine("Ingresa una de las siguientes categorias: ");
				Console.WriteLine("1. SUB 18");
				Console.WriteLine("2. SUB 16");
				Console.WriteLine("3. SUB 12");
				Console.WriteLine("4. Salir");
				opcion=int.Parse(Console.ReadLine());
				
				if(opcion == 1)
				{
					categoria = 18; //lo guardo así despues se agrega a la clase deporte
					deporte = club.buscarDeporte(nombre, categoria); //guarda en la variable el resultado de la busqueda del deporte
					
					if(deporte == null)
					{//si deporte es null, significa que no hay deporte con el nombre y categoria ingresado por el usuario
						datosDeportes(club, nombre, categoria);
						break;
					}
					else
					{
						Console.WriteLine("El deporte con esa categoria ya existe");
					}
					break;
				}
				if(opcion == 2)
				{
					categoria = 16;
					deporte = club.buscarDeporte(nombre, categoria);
					
					if(deporte == null)
					{
						datosDeportes(club, nombre, categoria);
						break;
					}
					else
					{
						Console.WriteLine("El deporte con esa categoria ya existe");
					}
					break;
				}
				if(opcion == 3)
				{
					categoria = 12;
					deporte = club.buscarDeporte(nombre, categoria);
					
					if(deporte == null)
					{
						datosDeportes(club, nombre, categoria);
						break;
					}
					else
					{
						Console.WriteLine("El deporte con esa categoria ya existe");
					}
					break;
				}
			}
			while(opcion != 0);
		}

//		Se complementa con Deporte, agrega los datos que le falta
		public static void datosDeportes(Club club, string nombre, int categoria)
		{
			Console.Write("Ingrese los dias de entrenamiento: ");
			string dia = Console.ReadLine();
			
			Console.Write("Ingrese la hora a la que empieza el entrenamiento: ");
			string hora = Console.ReadLine();
			
			Console.Write("Ingrese el cupo maximo: ");
			int cupo = int.Parse(Console.ReadLine());
			
			Console.Write("Ingrese el costo de la cuota: ");
			double costoCuota = double.Parse(Console.ReadLine());
			
			Console.Write("Ingresa el DNI del entrenador a asignar: ");
			int dniEntrenador = int.Parse(Console.ReadLine());
			
			Entrenador entrenador = club.buscarEntrenador(dniEntrenador); //guarda en la instancia Entrenador el resultado de la busqueda
			
//			Si no se encuentra un entrenador con el DNI proporcionado, muestra un mensaje de error.
			if(entrenador == null)
			{
				Console.WriteLine("No se encontro ningun entrenador con ese DNI ingresado");
			}
			else
			{
				Deporte dep1 = new Deporte(nombre, categoria, cupo, 0,costoCuota, dia, hora, entrenador);
				club.agregarDeporte(dep1);
				Console.WriteLine("Se agrego correctamente");
			}
		}
		
		
//		Eliminar deporte (del main)
		public static void eliminarDeporteMain(Club club)
		{
			Console.Write("Ingresa el nombre del deporte a Eliminar: ");
			string nombreDeporte = Console.ReadLine();
			
			int categoria;
			int opcion;
			Deporte deporte;
			
			do
			{
				Console.WriteLine("Ingresa una de las siguientes categorias: ");
				Console.WriteLine("1. SUB 18");
				Console.WriteLine("2. SUB 16");
				Console.WriteLine("3. SUB 12");
				Console.WriteLine("4. Salir");
				opcion=int.Parse(Console.ReadLine());
				
				if(opcion == 1)
				{
					categoria = 18;
					deporte = club.buscarDeporte(nombreDeporte, categoria);
					if(deporte == null)
					{
						Console.WriteLine("No existe ese deporte con esa categoria");
						break;
					}
					else
					{
						club.eliminarDeporte(deporte);
						break;
					}
				}
				if(opcion == 2)
				{
					categoria = 16;
					deporte = club.buscarDeporte(nombreDeporte, categoria);
					if(deporte == null)
					{
						Console.WriteLine("No existe ese deporte con esa categoria");
						break;
					}
					else
					{
						club.eliminarDeporte(deporte);
						break;
					}
				}
				if(opcion == 3)
				{
					categoria = 12;
					deporte = club.buscarDeporte(nombreDeporte, categoria);
					if(deporte == null)
					{
						Console.WriteLine("No existe ese deporte con esa categoria");
						break;
					}
					else
					{
						club.eliminarDeporte(deporte);
						break;
					}
				}
				else
					Console.WriteLine("Opcion ingresada no valida");
			}
			while(opcion!=4);
		}
		
//		METODO DAR DE ALTA NIÑO
		public static void agregarSocioMain(Club club){
			
			Deporte deporte;
			
			Console.WriteLine("Ingrese el nombre del socio");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el dni del socio:");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la edad del socio:");
			int edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el deporte al que se quiere inscribir:");
			string nombre_deporte = Console.ReadLine();
			Console.WriteLine("Ingrese la categoria del socio:");
			int categoria = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el ultimo mes pago:");
			string ultimoMesPago = Console.ReadLine();
			Console.WriteLine("Ingrese el descuento que tiene por ser socio:");
			int descuento = int.Parse(Console.ReadLine());
			
			deporte = club.buscarDeporte(nombre_deporte, categoria);
			if(deporte == null){
				Console.WriteLine("No se puede inscribir ya que no existe ese deporte");
			}
			else
			{
				Socio s = new Socio(nombre, dni, edad, nombre_deporte, categoria, ultimoMesPago, descuento);
				club.agregarSocio(s);
				
			}
		}
		// 		METODO SIMULACION DE PAGO
		
		public static void simulacionDePagoMain(Club club){
			
			Console.WriteLine("Ingrese el dni del socio para actualizar la cuota:");
			int dni = int.Parse(Console.ReadLine());
			
			foreach(Socio s in club.ListadoSocios)
			{
				if(s.Dni == dni)
				{
					Console.WriteLine("El valor de la cuota es de 20.000 pesos");
					Console.WriteLine("Ingrese el valor de la cuota");
					double cuota = int.Parse(Console.ReadLine());
					
					double descuento = (20 * cuota)/100; //20% de descuento por ser socio
					Console.WriteLine("Al ser socio tuvo un descuento del:" + descuento);
					
					s.UltimoMesPago = "Noviembre"; //ultimo mes pago actualizado
				}
//				else if (s.Dni != dni)
//				{
//					Console.WriteLine("No existe ese socio en el club");
//					break;
//				}
			}
	
		}
	}
}
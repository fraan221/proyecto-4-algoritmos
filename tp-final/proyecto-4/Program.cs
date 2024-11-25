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
		
//		Menu Principal
		public static void Menu(string decision)
		{
			//INICIALIZACIONES DE CLASES DE PRUEBA
			Club club = new Club("Boca");
<<<<<<< HEAD
			
			Socio socioPrueba=new Socio("Braian", 45619054, 20, "Futbol", 18, 11, 0.20); //nombre, dni, edad, deporte, categoria, mes de pago, porcentaje
			Socio socioPrueba2=new Socio("Matias", 123213, 12, "Baloncesto", 16, 1, 0.20);
			Socio socioPrueba3=new Socio("Daniel", 555555, 16, "Voley", 16, 2, 0.20);
=======
			/*Socio socioPrueba = new Socio("Braian", 45619054, 20, "Futbol", 18, 11, 0.20); //nombre, dni, edad, deporte, categoria, mes de pago, porcentaje
			Socio socioPrueba2 = new Socio("Matias", 123213, 12, "Baloncesto", 16, 1, 0.20);
			Socio socioPrueba3 = new Socio("Daniel", 555555, 16, "Voley", 16, 2, 0.20);
>>>>>>> d43ae7978eb970eee6dc1631a3a1b7811a11cc5b
			club.agregarSocio(socioPrueba);
			club.agregarSocio(socioPrueba2);
			club.agregarSocio(socioPrueba3);
			
			
			Entrenador ePrueba = new Entrenador("Franco", 44966422);
			Entrenador ePrueba1 = new Entrenador("Catriel", 44657432);
			Deporte depoPrueba0 = new Deporte("Voley", 18, 20, 20000, "lunes", "19:00", ePrueba);
			Deporte depoPrueba1 = new Deporte("Futbol", 18, 20, 20000, "lunes", "19:00", ePrueba);
			Deporte depoPrueba2 = new Deporte("Baloncesto", 18, 0, 10000, "6", "21:00", ePrueba1);
			
			club.agregarEntrenador(ePrueba);
			club.agregarEntrenador(ePrueba1);
			club.agregarDeporte(depoPrueba0);
			club.agregarDeporte(depoPrueba1);
			club.agregarDeporte(depoPrueba2);
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
							eliminarSocio(club);
							break;
						case 5:
							simulacionDePagoMain(club);
							break;
						case 6:
							Submenu(club);
							break;
						case 7:
							listaDeudores(club);
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
		
//		Submenu
		public static void Submenu(Club club)
		{
			Console.WriteLine("-----");
			Console.WriteLine("SUBMENÚ DE INSCRIPCIÓN");
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("1. Listado por Deporte");
			Console.WriteLine("2. Listado por Deporte y Categoria");
			Console.WriteLine("3. Listado Total");
			Console.WriteLine("4. Volver");
			Console.WriteLine("-----------------------------------------------");
			
			try
			{
				Console.Write("Seleccione una opción: ");
				int op = int.Parse(Console.ReadLine());
				Console.Clear();
				
				switch(op)
				{
					case 1:
						Console.Write("Ingrese el deporte: ");
						string dep = Console.ReadLine();
						club.listadoDeporte(dep);
						break;
					case 2:
						Console.Write("Ingrese un deporte: ");
						string deporte = Console.ReadLine();
						Console.Write("Ingrese una categoria: ");
						int categoria = int.Parse(Console.ReadLine());
						club.listadoDeporteCategoria(deporte, categoria);
						break;
					case 3:
						club.listadoTotal();
						break;
					case 4:
						Console.Write("Seguro que quiere volver al Menu Principal? s/n: ");
						string decisionSub = Console.ReadLine();
						if(decisionSub == "s" || decisionSub == "S")
						{
							string d = "n";
							Menu(d);
						}
						else if(decisionSub == "n" || decisionSub == "N")
						{
							Submenu(club);
						}
						else
						{
							Console.WriteLine("Opcion incorrecta");
							Submenu(club);
						}
						break;
					default:
						Console.WriteLine("Opcion no valida. Por favor, ingrese una opcion valida.");
						break;
				}
			}
			
			catch(FormatException)
			{
				Console.WriteLine("Algo salio mal. Intentelo de nuevo\n");
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
			
			Console.ReadKey(true);
			Console.Clear();
			
		}

//		Eliminar Entrenador (del main)
		public static void eliminarEntrenadorMain(Club club)
		{
			Console.Write("Ingrese el DNI del entrenador para eliminarlo: ");
			int dni = int.Parse(Console.ReadLine());
			Entrenador ent = club.buscarEntrenador(dni); //se busca entrenador
			
			if(ent != null){
				club.eliminarEntrenador(ent, dni);
				Console.WriteLine("Se elimino el entrenador");
			}
			else{
				Console.WriteLine("No se encontro el entrenador");
			}
			Console.ReadKey(true);
			Console.Clear();
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
				Console.WriteLine("\nIngresa una de las siguientes categorias: ");
				Console.WriteLine("1. SUB 18");
				Console.WriteLine("2. SUB 16");
				Console.WriteLine("3. SUB 12");
				Console.WriteLine("4. Salir");
				
				Console.Write("\nIngrese una opcion: ");
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
				if(opcion == 4)
				{
					Console.Clear();
					Console.WriteLine("Adios!");
				}
				if(opcion > 4)
				{
					Console.WriteLine("Opcion invalida. Intentelo de nuevo");
				}
			}
			while(opcion != 4);
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
				Deporte dep1 = new Deporte(nombre, categoria, cupo,costoCuota, dia, hora, entrenador);
				club.agregarDeporte(dep1);
				Console.WriteLine("Se agrego correctamente");
			}
			Console.ReadKey(true);
			Console.Clear();
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
				Console.Write("Ingrese una opcion: ");
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
				
				Console.ReadKey(true);
				Console.Clear();
			}
			while(opcion!=4);
		}
		
//		METODO DAR DE ALTA NIÑO
		public static void agregarSocioMain(Club club){
			Console.Write("Ingrese el deporte al que se quiere inscribir: ");
			string nombre_deporte = Console.ReadLine();
			Console.WriteLine("\nHAY SOLO TRES CATEGORIAS: SUB 12, SUB 16, SUB 18");
			Console.Write("Ingrese la categoria del socio: ");
			int categoria = int.Parse(Console.ReadLine());
			
			Deporte deporte = club.buscarDeporte(nombre_deporte, categoria);
			if(deporte == null){
				Console.WriteLine("No se puede inscribir ya que no existe ese deporte");
			}
			try{
				if(deporte !=null){
					if(deporte.Cupo == 0)
					{
						throw new SinCupoDisponible();
					}
					else
					{
						Console.Write("Ingrese el nombre del socio: ");
						string nombre = Console.ReadLine();
						Console.Write("Ingrese el dni del socio: ");
						int dni = int.Parse(Console.ReadLine());
						Console.Write("Ingrese la edad del socio: ");
						int edad = int.Parse(Console.ReadLine());
		
						Console.Write("Ingrese el numero de mes del ultimo mes pago: ");
						int ultimoMesPago = int.Parse(Console.ReadLine());
						Console.Write("El descuento que recibira es del 20%");
						double descuento = 0.20; //dejamos fijo el porcentaje que sera del 20%
						Socio s = new Socio(nombre, dni, edad, nombre_deporte, categoria, ultimoMesPago, descuento);
						Console.WriteLine("\nSE A AGREGADO EL SOCIO");
						club.agregarSocio(s);
						deporte.altaInscripto();
						deporte.Cupo -= 1;
					}
				}
			}
			catch(SinCupoDisponible){
				Console.WriteLine("No se puede inscribir ya que no hay cupo disponible");
		}
			
			Console.ReadKey(true);
			Console.Clear();
		}
		// 		METODO DE ELIMINAR SOCIO
		
		public static void eliminarSocio(Club club){
			Console.Write("Ingresa el deporte del Socio: ");
			string nombreDeporte=Console.ReadLine();
			Console.Write("Ingresa la cateogoria: ");
			int categoriaDeporte=int.Parse(Console.ReadLine());
			
			Console.Write("Ingresa el DNI del socio a eliminar: ");
			int dni=int.Parse(Console.ReadLine());
			
			Socio so=club.buscarSocio(dni);
			Deporte depo=club.buscarDeporte(nombreDeporte, categoriaDeporte);
			
			if(depo==null){
				Console.WriteLine("El deporte no existe con esa categoria");
			}
			else{
				if(so==null){
					Console.WriteLine("No se a encontrado el socio");
					
				}
				else{
					club.eliminarSocio(so, dni);
					Console.WriteLine("Se a eliminado el socio");
					depo.bajaInscripto(); //baja la en 1 cada vez que se elimina un socio
				}
			}
			Console.ReadKey(true);
			Console.Clear();
			
		}
		
		// 		METODO SIMULACION DE PAGO
		public static void simulacionDePagoMain(Club club){
			Console.Write("Ingresa el deporte del Socio: ");
			string nombreDeporte=Console.ReadLine();
			Console.Write("Ingresa la cateogoria: ");
			int categoriaDeporte=int.Parse(Console.ReadLine());
			
			Console.Write("Ingrese el dni del socio para actualizar la cuota: ");
			int dni = int.Parse(Console.ReadLine());
			
			Socio so=club.buscarSocio(dni);
			Deporte dep=club.buscarDeporte(nombreDeporte, categoriaDeporte);
			
			foreach(Deporte d in club.ListadoDeportes){
				if(dep==null){
					Console.WriteLine("No existe el deporte con esa categoria");
					break;
				}
				else{
					foreach(Socio s in club.ListadoSocios){
						if(so==null){
							Console.WriteLine("No existe el socio con el DNI ingresado");
						}
						else{
							Console.WriteLine("\nExiste el socio");
							double costoCuota=d.CostoCuota; //guardo el precio del abono del deporte
							double descuentoSocio=s.Descuento; //guardo el porcentaje del descuento (20%)
							double descuento=costoCuota*descuentoSocio; //nos dice el monto del porcentaje
							
							Console.WriteLine("\nEl descuento sera de: " + descuento);
							Console.WriteLine("El abono total con el descuento es: " + (costoCuota - descuento));
							s.UltimoMesPago=11; //ultimo mes pago actualizado
							break;
						}
					}
					break;
				}
			}
			Console.ReadKey(true);
			Console.Clear();
			
		}
		
//		LISTA DE DEUDORES
		public static void listaDeudores(Club club){
			foreach(Socio socio in club.ListadoSocios){
				if(socio.UltimoMesPago<11){
					socio.imprimir();
				}
			}
			Console.ReadKey(true);
			Console.Clear();
		}
	}
}
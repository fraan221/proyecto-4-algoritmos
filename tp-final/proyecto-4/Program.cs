using System;

namespace proyecto_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Club club = new Club("Boca");
			
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
						agregarEntrenador(club);
						break;
					case 2:
						/*
						Console.WriteLine("ingrese el dni del entrenaador:");
						dni = int.Parse(Console.ReadLine());
						Console.WriteLine("ingrese el deporte al que esta asignado:");
						d = Console.ReadLine();
						club.EliminarEntrenador(d, dni);
						Console.WriteLine("Ah sigo dado de baja del club con exito");
						*/
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
						agregarDeporte(club);
						break;
					case 9:
						//club.listadoDeporte();
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
		
		
//AGREGAR ENTRENADOR

		public static void agregarEntrenador(Club club){
			Console.WriteLine("ingrese el nombre del entrenador:");
			string nombre = Console.ReadLine();
			Console.WriteLine("ingrese el dni del entrenador:");
			int dni = int.Parse(Console.ReadLine());
			
			if(club.Buscarentrenador(dni)==null){
				Entrenador nuevoEntrenador=new Entrenador(nombre, dni);
				club.AgregarEntrenador(nuevoEntrenador);
				Console.WriteLine("Se agrego correctamente el Entrenador \n");
			}
			else{Console.WriteLine("El Entrenador ingresado ya esta registrado");}
		}


//ELIMINAR DEPORTE


		public static void eliminarEntrenador(Club club){
			int dni;
			Console.Write("Ingrese el DNI del entrenador para eliminarlo: ");
			dni=int.Parse(Console.ReadLine());
			Entrenador ent=club.Buscarentrenador(dni); //se busca entrenador
			if(ent !=null){
				if(club.EliminarEntrenador(ent)){
					Console.WriteLine("Se elimino el entrenador");
				}
				
				else{Console.WriteLine("El entrenador tiene un deporte asignado no se puede eliminar");}
			}
			
			else{Console.WriteLine("No se encontro el entrenador");}
		}
		
		
		
//AGREGAR DEPORTE

		public static void agregarDeporte(Club club){
			Console.WriteLine("Ingresa el nombre del deporte: ");
			string nombre=Console.ReadLine();

			int opcion;
			int categoria;
			Deporte deporte; //inicializa la clase, por defecto es null
			
			do{
				Console.WriteLine("Ingresa una de las siguientes categorias: ");
				Console.WriteLine("1_SUB 18");
				Console.WriteLine("2_SUB 16");
				Console.WriteLine("3_SUB 12");
				Console.WriteLine("0_SALIR");
				opcion=int.Parse(Console.ReadLine());
				
				if(opcion==1){
					categoria=18; //lo guardo así despues se agrega a la clase deporte
					deporte=club.BuscarDeporte(nombre, categoria); //guarda en la variable el resultado de la busqueda del deporte
					
					if(deporte==null){//si deporte es null, significa que no hay deporte con el nombre y categoria ingresado por el usuario
						datosDeportes(club, nombre, categoria);
						break;
					}
					else{Console.WriteLine("El deporte con esa categoria ya existe");}
					break;
					
					
				}
				if(opcion==2){
					categoria=16;
					deporte=club.BuscarDeporte(nombre, categoria); 
					
					if(deporte==null){
						datosDeportes(club, nombre, categoria);
						break;
					}
					else{Console.WriteLine("El deporte con esa categoria ya existe");}
					break;
				}
				
				if(opcion==3){
					categoria=12;
					deporte=club.BuscarDeporte(nombre, categoria); 
					
					if(deporte==null){
						datosDeportes(club, nombre, categoria);
						break;
					}
					else{Console.WriteLine("El deporte con esa categoria ya existe");}
					break;
				}
			}while(opcion!=0);
			
		}

//SE COMPLEMENTA CON DEPORTE, AGREGA LOS DATOS QUE LE FALTA
		
		public static void datosDeportes(Club club, string nombre, int categoria){
			Console.WriteLine("Ingresa los dias: ");
			string dia=Console.ReadLine();
			
			Console.Write("Ingresa la hora: ");
			string hora=Console.ReadLine();
			
			Console.Write("Ingresa un cupo maximo: ");
			int cupo=int.Parse(Console.ReadLine());
			
			Console.Write("Ingresa el costo de la cuota: ");
			double costoCuota=double.Parse(Console.ReadLine());
			
			Console.Write("Ingresa el DNI del entrenador a asignar: ");
			int dniEntrenador=int.Parse(Console.ReadLine());
			
			Entrenador entrenador=club.Buscarentrenador(dniEntrenador); //guarda en la instancia Entrenador el resultado de la busqueda
			
			if(entrenador==null){ //Si no se encuentra un entrenador con el DNI proporcionado, muestra un mensaje de error.
				Console.WriteLine("No se encontro ningun entrenador con ese DNI ingresado");
			}
			
			else{
				Deporte dep1=new Deporte(nombre, categoria, cupo, costoCuota, dia, hora, entrenador);
				club.agregarDeporte(dep1);
				Console.WriteLine("Se agrego correctamente");
			}
			
		}
		
	}
}
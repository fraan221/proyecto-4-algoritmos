using System;
using System.Collections;

namespace proyecto_4
{
	public class Club
	{
		// 		Atributos
		private string nombre;
		private ArrayList listadoSocios;
		private ArrayList listadoDeportes;
		private ArrayList listadoEntrenadores;

		// 		Constructor
		public Club(string nombre)
		{
			this.nombre = nombre;
			listadoSocios = new ArrayList();
			listadoDeportes = new ArrayList();
			listadoEntrenadores = new ArrayList();
		}

		// 		Propiedades
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public ArrayList ListadoSocios
		{
			get { return listadoSocios; }
		}

		public ArrayList ListadoDeportes
		{
			get { return listadoDeportes; }
		}
		public ArrayList ListadoEntrenadores
		{
			get { return listadoEntrenadores; }
		}
		
//		Metodos

//		Agregar Entrenador
		public void agregarEntrenador(Entrenador entrenador)
		{
			listadoEntrenadores.Add(entrenador);
		}
		
//		Agregar Deporte
		public void agregarDeporte(Deporte deporte)
		{
			listadoDeportes.Add(deporte);
		}
		
//		Agregar Socio
		public void agregarSocio(Socio socio)
		{
			listadoSocios.Add(socio);
		}
		
//		Eliminar Entrenador
		public void eliminarEntrenador(Entrenador entrenador, int dni)
		{
			foreach(Entrenador e in listadoEntrenadores)
			{
				if(e.Dni == dni){
					listadoEntrenadores.Remove(entrenador);
					break;
				}
			}
		}
		
		//		Eliminar Socio
		public void eliminarSocio(Socio socio, int dni){
			foreach (Socio s in listadoSocios){
				if(s.Dni==dni){
					listadoSocios.Remove(socio);
					break;
				}
			}
		}
		
		
		
//		Eliminar Deporte
		public void eliminarDeporte(Deporte deporte)
		{
			
			foreach(Deporte dep in listadoDeportes)
			{
				if(dep.CantidadInscriptos==0)
				{
					listadoDeportes.Remove(deporte);
					Console.WriteLine("El Deporte seleccionado se ha eliminado correctamente.");
					break;
				}
				else if(dep.CantidadInscriptos !=0){
					Console.WriteLine("El Deporte seleccion no puede ser eliminado aun, tiene inscriptos.");
					break;
				}
			}
		}
		
//		Buscar Entrenador
		public Entrenador buscarEntrenador(int dni)
		{
			foreach(Entrenador entrenador in ListadoEntrenadores)
			{
				if(entrenador.Dni == dni)
					return entrenador; //devuelve el objeto entrenador
			}
			return null; //devuelve null si no se encuentra
		}
		
//		Buscar Deporte
		public Deporte buscarDeporte(string nombre, int categoria)
		{
			foreach(Deporte deporte in ListadoDeportes)
			{
				if(deporte.Nombre.ToUpper() == nombre.ToUpper() && deporte.Categoria==categoria)
					return deporte; //devuelve el objeto deporte
			}
			return null; //devuelve null si no se encuentra
		}
		

		
//		Buscar socio
		public Socio buscarSocio(int dni){
			foreach(Socio socio in ListadoSocios){
				if(socio.Dni==dni){
					return socio;
				}
			}
			return null;
		}
		
		
//		Listado por Deporte
		public void listadoDeporte(string deporte)
		{
			foreach(Deporte d in ListadoDeportes) // recorre la lista de deportes
			{
				if(deporte.ToLower() == d.Nombre.ToLower())	// compara el nombre recibido con el nombre del deporte
				{
					foreach(Socio s in ListadoSocios)	// si coindice recorre la lista de socios
					{
						if(s.Deporte.ToLower() == deporte.ToLower())	// checkea los socios con ese deporte asociado
							Console.WriteLine("{0}, {1}\n", s.Nombre, s.Deporte);	// imprime los socios
					}
					break;
				}
				else if(deporte.ToLower() != d.Nombre.ToLower())	// si el nombre recibido posr parametro no coincide con ninguno en la lista devuelve un mensaje
				{
					Console.WriteLine("El deporte ingresado no existe.");
				}
			}
		}
		
//		Listado por Deporte y Categoria
		public void listadoDeporteCategoria(string deporte, int categoria)
		{
			foreach(Deporte d in ListadoDeportes)
			{
				if(deporte.ToLower() == d.Nombre.ToLower())
				{
					if(categoria == d.Categoria)
					{
						foreach(Socio s in ListadoSocios)
						{
							if(deporte.ToLower() == s.Deporte.ToLower())
							{
								if(categoria == s.Categoria)
								{
									Console.WriteLine("{0}, {1}, {2}\n", s.Nombre, s.Deporte, s.Categoria);
								}
							}
						}
						break;
					}
				}
				else if(deporte.ToLower() != d.Nombre.ToLower())
				{
					if(categoria != d.Categoria)
					{
						Console.WriteLine("No existe el deporte ingresado.\n");
					}
				}
			}
		}
		
//		Listado Total
		public void listadoTotal()
		{
			Console.WriteLine("Listado Total\n");
			foreach(Deporte d in ListadoDeportes)
			{
				Console.WriteLine("{0}", d.Nombre);
				Console.WriteLine(" Sub {0}", d.Categoria);
			}
			int cantidadDeportes = ListadoDeportes.Count;
			Console.WriteLine("\nCantidad Total de Deportes en el Club: {0}\n", cantidadDeportes);
		}
		
		public void listaSocio()
		{
			Console.WriteLine("LISTADO DE SOCIOS\n");
			foreach(Socio socio in ListadoSocios)
			{
				socio.imprimir();
			}
		}
		
		public Niño niño(int dni){
			foreach(Niño niño in ListadoSocios)
			{
				if(niño.Dni==dni)
					return niño;
			}
			return null;
		}
	}
}

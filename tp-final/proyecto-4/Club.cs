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
			Console.WriteLine("╔═════════════════════╗");
			Console.WriteLine("║ Listado por Deporte ║");
			Console.WriteLine("╚═════════════════════╝");
			bool existeDeporte = false;
			foreach (Deporte d in ListadoDeportes)
			{
				if (deporte.ToLower() == d.Nombre.ToLower())
				{
					existeDeporte = true;
					foreach (Socio s in ListadoSocios)
					{
						if (deporte.ToLower() == s.Deporte.ToLower())
						{
							Console.WriteLine(" Nombre: {0}, Deporte: {1}", s.Nombre, s.Deporte);
						}
					}
				}
			}
			if (!existeDeporte)
			{
				Console.WriteLine("Algo salio mal. Intentelo de nuevo");
				return;
			}
		}
		
//		Listado por Deporte y Categoria
		public void listadoDeporteCategoria(string deporte, int categoria)
		{
			Console.WriteLine("╔═════════════════════════════════╗");
			Console.WriteLine("║ Listado por Deporte y Categoria ║");
			Console.WriteLine("╚═════════════════════════════════╝");
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
									Console.WriteLine(" Nombre: {0}\n Deporte: {1}\n Categoria: {2}\n", s.Nombre, s.Deporte, s.Categoria);
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
						Console.WriteLine("No existe el deporte ingresado ni tampoco la categoria o ingreso una opcion invalida.\n");
					}
				}
				else
				{
					Console.WriteLine(" Algo salio mal. Intentelo de nuevo");
				}
			}
		}
		
//		Listado Total
		public void listadoTotal()
		{
			Console.WriteLine("╔═══════════════╗");
			Console.WriteLine("║ Listado Total ║");
			Console.WriteLine("╚═══════════════╝");
			foreach(Socio s in ListadoSocios)
			{
				Console.WriteLine(" Nombre: {0}", s.Nombre);
				Console.WriteLine(" Deporte: {0} Categoria: Sub {1}\n", s.Deporte, s.Categoria);
			}
			int cantidadDeportes = ListadoSocios.Count;
			Console.WriteLine("\n  Cantidad Total de socios en el Club: {0}\n", cantidadDeportes);
		}
	}
}

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
		public void eliminarEntrenador(int dni)
		{
			foreach(Entrenador e in listadoEntrenadores)
			{
				if(e.Dni == dni)
					listadoEntrenadores.Remove(e);
			}
		}
		
//		Eliminar Deporte
		public void eliminarDeporte(Deporte deporte)
		{
			foreach(Deporte dep in listadoDeportes)
			{
				if(dep.CantidadInscriptos == 0)
				{
					listadoDeportes.Remove(deporte);
					Console.WriteLine("El Deporte seleccionado se ha eliminado correctamente.");
					break;
				}
				else
				{
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
		
//		Listado por Deporte
		public void listadoDeporte()
		{
			Console.WriteLine("Deportes del Club\n");
			foreach(Deporte d in ListadoDeportes)
			{
				Console.WriteLine("{0}", d.Nombre);
			}
			Console.WriteLine("\n");
		}
		
//		Listado por Deporte y Categoria
		public void listadoDeporteCategoria()
		{
			Console.WriteLine("Deportes y Categorias del Club\n");
			foreach(Deporte d in ListadoDeportes)
			{
				Console.WriteLine("Deporte: {0}", d.Nombre);
				Console.WriteLine("Categoria: Sub{0}\n", d.Categoria);
			}
		}
		
//		Listado Total
		public void listadoTotal()
		{
			Console.WriteLine("Listado Total\n");
			foreach(Deporte d in ListadoDeportes)
			{
				Console.WriteLine("{0}", d.Nombre);
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

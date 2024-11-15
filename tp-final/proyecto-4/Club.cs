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

		
		
		
		//			Metodos

		public void EliminarEntrenador(string nombreDeporte, int dni)
		{
			//eliminar entrenador de lista de entrenadores
			foreach( Entrenador e in listadoEntrenadores){
				if(e.Dni == dni){
					listadoEntrenadores.Remove(e);
				}
			}
		}
		
		public void AgregarEntrenador(Entrenador entrenador){
			listadoEntrenadores.Add(entrenador);
		}
		
		public void agregarDeporte(Deporte deporte)
		{
			listadoDeportes.Add(deporte);
		}

		public void listadoSociosDeporte()
		{
			foreach(Deporte d in listadoDeportes){
				Console.WriteLine("Nombre del deporte:" + d.Nombre);
			}
		}
		
		public Niño niño(int dni){
			foreach(Niño niño in ListadoSocios){
				if(niño.Dni==dni){
					return niño;
				}
			}
			
			return null;
		}
		
		
		public Entrenador Buscarentrenador(int dni){ 
			foreach(Entrenador entrenador in ListadoEntrenadores){
				if(entrenador.Dni==dni){
					return entrenador; //devuelve el objeto entrenador
				}
			}
			return null; //devuelve null si no se encuentra
		}
		
		public Deporte BuscarDeporte(string nombre, int categoria){ 
			foreach(Deporte deporte in ListadoDeportes){
				if(deporte.Nombre.ToUpper()==nombre.ToUpper() && deporte.Categoria==categoria){
					return deporte; //devuelve el objeto deporte
				}
			}
			return null;
		}
		
		public bool EliminarEntrenador(Entrenador entrenador){
			foreach(Deporte deporte in ListadoDeportes){
				if(entrenador.Dni==deporte.Entrenador.Dni){ //busca en la lista de deporte si existe el Dni de ese entrenador
					listadoEntrenadores.Remove(entrenador); 
					return true;
				}
				else{return false;}
			}
			return true;
		}
	}
}

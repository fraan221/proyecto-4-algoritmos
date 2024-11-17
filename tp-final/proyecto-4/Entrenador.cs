using System;

namespace proyecto_4
{
	public class Entrenador
	{
//		Atributos
		private string nombre;
		private int dni;

//		Constructor
		public Entrenador(string nombre, int dni)
		{
			this.nombre = nombre;
			this.dni = dni;
		}

//		Propiedades
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public int Dni
		{
			get { return dni;}
			set { dni = value;}
		}

//		Metodos

//		Metodo para imprimir los datos del entrenador
		public void Imprimir()
		{
			Console.WriteLine("El entrenador se llama: " + nombre + " y su DNI es: " + dni);
		}
	}
}
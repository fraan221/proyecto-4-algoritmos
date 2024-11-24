using System;

namespace proyecto_4
{
	public class Socio: Niño
	{
//		Atributos
		private double descuento;

//		Constructor
		public Socio(string nombre, int dni, int edad, string deporte, int categoria, int ultimoMesPago, double descuento): base(nombre, dni, edad, deporte, categoria, ultimoMesPago)
		{
			this.descuento=descuento;
		}

//		Propiedades
		public double Descuento{
			get{ return descuento; }
			set{ descuento=value; }
		}

//		Metodos
		public override void imprimir()
		{
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Dni: " + dni);
			Console.WriteLine("Descuento: " + descuento);
		}
	}
}
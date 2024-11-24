using System;

namespace proyecto_4
{
	public class Niño
	{
//		Atributos
		protected string nombre;
		protected int dni;
		protected int edad;
		protected string deporte;
		protected int categoria;
		protected int ultimoMesPago;

//		Constructor
		public Niño(string nombre, int dni, int edad, string deporte, int categoria, int ultimoMesPago)
		{
			this.nombre=nombre;
			this.dni=dni;
			this.edad=edad;
			this.deporte=deporte;
			this.categoria=categoria;
			this.ultimoMesPago=ultimoMesPago;
		}

//		Propiedades
		public string Nombre
		{
			get{ return nombre; }
			set{ nombre = value; }
		}

		public int Dni
		{
			get{ return dni; }
			set{ dni = value; }
		}

		public int Edad
		{
			get{ return edad; }
			set{ edad = value; }
		}

		public string Deporte
		{
			get{ return deporte; }
			set{ deporte = value; }
		}

		public int Categoria
		{
			get{ return categoria; }
			set{ categoria = value; }
		}

		public int UltimoMesPago
		{
			get{ return ultimoMesPago; }
			set{ ultimoMesPago = value; }
		}

//		Metodos
		public virtual void imprimir()
		{
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Dni: " + dni);
			Console.WriteLine("Edad: " + edad);
			Console.WriteLine("Deporte: " + deporte);
			Console.WriteLine("Categoria: " + categoria);
			Console.WriteLine("Ultimo mes pago: " + ultimoMesPago);
		}
	}
}
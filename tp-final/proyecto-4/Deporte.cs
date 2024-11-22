using System;

namespace proyecto_4
{
	public class Deporte
	{
//		Atributos
		private string nombre;
		private int categoria;
		private int cupo;
		private int cantidadInscriptos;
		private double costoCuota;
		private string dia;
		private string hora;
		private Entrenador entrenador;

//		Constructor
		public Deporte(string nombre, int categoria, int cupo, int cantidadInscriptos,double costoCuota, string dia, string hora, Entrenador entrenador)
		{
			this.nombre = nombre;
			this.categoria = categoria;
			this.cupo = cupo;
			this.costoCuota = costoCuota;
			this.dia = dia;
			this.hora = hora;
			this.entrenador = entrenador;
			this.cantidadInscriptos=cantidadInscriptos;
		}

//		Propiedades
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public int Categoria
		{
			get { return categoria; }
			set { categoria = value; }
		}

		public int Cupo
		{
			get { return cupo; }
			set { cupo = value; }
		}

		public int CantidadInscriptos
		{
			get { return cantidadInscriptos; }
			set { cantidadInscriptos = value; }
		}

		public double CostoCuota
		{
			get { return costoCuota; }
			set { costoCuota = value; }
		}

		public string Dia
		{
			get { return dia; }
			set { dia = value; }
		}

		public string Hora
		{
			get { return hora; }
			set { hora = value; }
		}

		public Entrenador Entrenador
		{
			get { return entrenador; }
			set { entrenador = value; }
		}
		
//		Metodos
		public void bajaInscripto(){
			cantidadInscriptos--;
		}
		
		public void altaInscripto(){
			cantidadInscriptos++;
		}
		
		public bool cuposDisponibles(){
			if(cupo>0){
				return true;
			}
			return false;
		}
		
		public void imprimir()
		{
//			TO-DO
		}
	}
}


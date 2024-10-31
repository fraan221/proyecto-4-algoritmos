using System;

namespace proyecto_4
{
	public class Categoria
	{
//			Atributos
		private int cupo;
		private int cantidadInscriptos;
		private int costoCuota;
		private string dia;
		private string hora;
		
//			Constructor
		public Categoria(int cupo, int cantidadInscriptos, int costoCuota, string dia, string hora)
		{
			this.cupo = cupo;
			this.cantidadInscriptos = cantidadInscriptos;
			this.costoCuota = costoCuota;
			this.dia = dia;
			this.hora = hora;
		}
		
//			Propiedades
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
		
		public int CostoCuota
		{
			get { return costoCuota; }
			set { cantidadInscriptos = value; }
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
		
//			Metodos
		public void imprimir()
		{
//				TO-DO
		}
	}
}

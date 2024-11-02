using System;
using System.Collections;

namespace proyecto_4
{
<<<<<<< HEAD
    public class Deporte
    {
        //	Atributos
        private string nombre;
        private ArrayList listaCategorias;
        private ArrayList listadoEntrenadores;

        //	Constructor
        public Deporte(string nombre)
        {
            this.nombre = nombre;
        }

        //	Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public ArrayList ListaCategorias
        {
            get { return listaCategorias; }
        }

        public ArrayList ListadoEntrenadores
        {
            get { return listadoEntrenadores; }
        }

        //	Metodos
        public void listadoDeporte()
        {
            
        }

        public void listadoDeporteCategoria()
        {
            //  TO-DO
        }

        public void listadoTotal()
        {
            //	TO-DO
        }
    }
=======
	public class Deporte
	{
//			Atributos
		private string nombre;
		private ArrayList listaCategorias;
		private ArrayList listadoEntrenadores;
		
//			Constructor
		public Deporte(string nombre)
		{
			this.nombre = nombre;
			listaCategorias = new ArrayList();
			listadoEntrenadores = new ArrayList();
		}
		
//			Propiedades
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		
		public ArrayList ListaCategorias
		{
			get { return listaCategorias; }
		}
		
		public ArrayList ListadoEntrenadores
		{
			get { return listadoEntrenadores; }
		}
		
//			Metodos
		public void listadoDeporte()
		{
//				TO-DO
		}
		
		public void listadoDeporteCategoria()
		{
//				TO-DO
		}
		
		public void listadoTotal()
		{
//				TO-DO
		}
		
		
		public void agregarentrenador(Entrenador entrenador){
			ListadoEntrenadores.Add(entrenador);
		}
	}
>>>>>>> b68464e775e4598839c78e3f588e1bf90c83ef58
}

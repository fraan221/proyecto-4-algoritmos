﻿using System;
using System.Collections;

namespace proyecto_4
{
    public class Club
    {
        // 	Atributos
        private string nombre;
        private ArrayList listadoSocios;
        private ArrayList listadoDeportes;

        // 	Constructor
        public Club(string nombre)
        {
            this.nombre = nombre;
            listadoSocios = new ArrayList();
            listadoDeportes = new ArrayList();
        }

        // 	Propiedades
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

<<<<<<< HEAD
        //	Metodos
        public void agregarEntrenador()
        {
            // Código para agregar un entrenador
        }

        public void eliminarEntrenador()
        {
            // Código para eliminar un entrenador
        }
=======
//		Metodos
		public void agregarEntrenador(Entrenador entrenador, string nombreDeporte)
		{
			foreach (Deporte d in listadoDeportes){
				if(d.Nombre == nombreDeporte)
				{
					d.agregarentrenador(entrenador);
				}
			}
			
			
			
			// Código para agregar un entrenador
		}

		public void eliminarEntrenador(Deporte deporte, Entrenador entrenador)
		{
			deporte.ListadoEntrenadores.Remove(entrenador);
		}
>>>>>>> b68464e775e4598839c78e3f588e1bf90c83ef58

        public void agregarSocio()
        {
            // Código para agregar un socio
        }

        public void eliminarSocio()
        {
            // Código para eliminar un socio
        }

        public void agregarDeporte()
        {
            // Código para agregar un deporte
        }

        public void eliminarDeporte()
        {
            // Código para eliminar un deporte
        }

        public void mostrarSocio()
        {
            // Código para mostrar un socio
        }

        public void mostrarEntrenador()
        {
            // Código para mostrar un entrenador
        }
    }
}
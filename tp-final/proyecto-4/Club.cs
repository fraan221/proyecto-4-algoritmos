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

        //		Metodo agregar entrenador
        public void AgregarEntrenador(Entrenador e)
        {
            // Agregar entrenador a lista de entrenadores del club
            listadoEntrenadores.Add(e);
        }

        public void EliminarEntrenador(string nombreDeporte, int dni)
        {
            //eliminar entrenador de lista de entrenadores
            foreach (Entrenador e in listadoEntrenadores)
            {
                if (e.Dni == dni)
                {
                    listadoEntrenadores.Remove(e);
                }
            }
        }

        public void agregarSocio()
        {
            // Código para agregar un socio
        }

        public void eliminarSocio()
        {
            // Código para eliminar un socio
        }

        public void agregarDeporte(Deporte deporte, int dni)
        {
            foreach (Entrenador e in listadoEntrenadores)
            {
                if (e.Dni == dni)
                {
                    listadoDeportes.Add(deporte);
                }
                else
                {
                    Console.WriteLine("No existe ese entrenador en el club");
                }
            }

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
        //			Metodos
        public void listadoSociosDeporte()
        {
            foreach (Deporte d in listadoDeportes)
            {
                Console.WriteLine("Nombre del deporte:" + d.Nombre);
            }
        }

        public void listadoSociosCategoria()
        {
            //				TO-DO
        }

        public void listadoSociosTotal()
        {
            //				TO-DO
        }
    }
}
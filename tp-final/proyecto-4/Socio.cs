using System;

namespace proyecto_4
{
    public class Socio : Niño
    {
        //		Atributos
        private int descuento;

        //		Constructor
        public Socio(string nombre, int dni, int edad, string deporte, int categoria, string ultimoMesPago, int descuento) : base(nombre, dni, edad, deporte, categoria, ultimoMesPago)
        {
            this.descuento = descuento;
        }

        //		Propiedades
        public int Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        //		Metodos
        public void MostrarDescuento()
        {
            Console.WriteLine("Descuento: " + descuento);
        }
    }
}
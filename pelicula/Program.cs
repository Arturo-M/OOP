using System;

namespace pelicula
{
        class Peli
    {
        //Atributos publicos
        public String Titulo;
        public Int16 Año;
        public string Pais;
        public string Direct;  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Peli P1 = new Peli();
            P1.Titulo = "El gigante de hierro";
            P1.Año = 1999;
            P1.Pais = "Estados Unidos";
            P1.Direct = "Brad Bird";
            Console.WriteLine("Titulo: {0} \nAño: {1} \nPais: {2} \nDirector: {3}", P1.Titulo,P1.Año,P1.Pais,P1.Direct);
          
            Peli P2 = new Peli();
            P2.Titulo = "El extraño mundo de Jack";
            P2.Año = 1993;
            P2.Pais = "Estados unidos";
            P2.Direct = "Henry Selick";
            Console.WriteLine("\nTitulo: {0} \nAno :{1} \nPais: {2} \nDirectores: {3}", P2.Titulo, P2.Año,P2.Pais,P2.Direct);
        }
    }
}

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
            Peli Pe1 = new Peli();
            Pe1.Titulo = "El gigante de hierro";
            Pe1.Año = 1999;
            Pe1.Pais = "Estados Unidos";
            Pe1.Direct = "Brad Bird";
            Console.WriteLine("Titulo: {0} \nAño: {1} \nPais: {2} \nDirector: {3}", Pe1.Titulo,Pe1.Año,Pe1.Pais,Pe1.Direct);
          
            Peli Pe2 = new Peli();
            Pe2.Titulo = "El extraño mundo de Jack";
            Pe2.Año = 1993;
            Pe2.Pais = "Estados unidos";
            Pe2.Direct = "Henry Selick";
            Console.WriteLine("\nTitulo: {0} \nAno :{1} \nPais: {2} \nDirectores: {3}", Pe2.Titulo, Pe2.Año,Pe2.Pais,Pe2.Direct);
        }
    }
}

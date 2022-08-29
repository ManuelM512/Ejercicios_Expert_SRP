using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        /*
        No estaría bien que una clase Libro contenga su posición en la biblioteca, sino delegar la responsabilidad de las posiciones a otras clases
        public string LibrarySector { get ; set; } 
        public string LibraryShelve { get ; set; }
        Sería más coherente que se formulase una clase de sectores y otra de estanterías para poder guardar cada uno a la otra de manera ordenada, y a los libros
        */
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}

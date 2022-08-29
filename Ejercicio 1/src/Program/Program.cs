using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //Como ahora Shelve y Sector son clases, se pueden instanciar sus objetos
            Shelve est1 = new Shelve("1");
            
            /*
            Se quitó el método de guardar libros de la clase Libro, ahora 
            book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");
            */
        }
    }
}
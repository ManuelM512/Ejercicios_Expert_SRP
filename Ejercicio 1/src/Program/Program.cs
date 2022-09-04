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
            Shelve shl1 = new Shelve("A");
            Sector sec1 = new Sector("7");
            Shelve shl2 = new Shelve("B");
            Sector sec2 = new Sector("3");
            /*
            Se quitó el método de guardar libros de la clase Libro 
            book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");
            */
            //Se guarda un libro en una estanteria y se asigna esta estanteria a un sector
            shl1.AddBook(book1);
            sec1.AddShelve(shl1);
            shl2.AddBook(book2);
            sec2.AddShelve(shl2);

            //Impresión de los contenidos
            Console.WriteLine(book1.ToString());
            shl1.ListBooks();
            sec1.ListShelves();
            Console.WriteLine(book2.ToString());
            shl2.ListBooks();
            sec2.ListShelves();
        }
    }
}
using System;
using System.Collections;

namespace SRP
{
    public class Shelve{
        public string CodigoEstanteria {get; set;}

        public Shelve(string codigo){
            this.CodigoEstanteria=codigo;
        }

        public ArrayList books = new ArrayList();
        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            this.books.Remove(book);
        }
    }

}
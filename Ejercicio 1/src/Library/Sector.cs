using System;
using System.Collections;

namespace SRP
{
    public class Sector{
        public string NombreSector{get; set;}

        public Sector(string nombre){
            this.NombreSector=nombre;
        }
        public ArrayList shelves = new ArrayList();
        public void AddShelve(Shelve shelve)
        {
            this.shelves.Add(shelve);
        }

        public void RemoveShelve(Shelve shelve)
        {
            this.shelves.Remove(shelve);
        }
    }

}
using System;
using System.Collections.Generic;

namespace IteratorPattern.Classes
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Hotels> listEmployees = new List<Hotels>();
        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddHotels(Hotels hotels)
        {
            listEmployees.Add(hotels);
        }
        //Get item from collection
        public Hotels GetHotels(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}

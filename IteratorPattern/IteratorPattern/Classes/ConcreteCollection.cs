using System;
using System.Collections.Generic;

namespace IteratorPattern.Classes
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Hotels> listEmployees = new List<Hotels>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listEmployees.Count; }
        }

        public void AddHotels(Hotels hotels)
        {
            listEmployees.Add(hotels);
        }

        public Hotels GetHotels(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}

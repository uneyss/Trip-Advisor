using System;
namespace IteratorPattern.Classes
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first item
        public Hotels First()
        {
            current = 0;
            return collection.GetHotels(current);
        }
        // Gets next item
        public Hotels Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetHotels(current);
            }
            else
            {
                return null;
            }
        }
        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}

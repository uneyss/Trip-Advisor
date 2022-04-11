using System;
namespace IteratorPattern.Classes
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public Hotels First()
        {
            current = 0;
            return collection.GetHotels(current);
        }

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

        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}

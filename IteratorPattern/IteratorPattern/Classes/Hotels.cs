using System;

namespace IteratorPattern.Classes
{
    class Hotels
    {
        public int ID { get; set; }
        public int Star { get; set; }
        public string Name { get; set; }

        public Hotels(string name, int id, int star)
        {
            Name = name;
            ID = id;
            Star = star;
        }
    }
}

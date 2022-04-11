using IteratorPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Program
    {
        static void Main()
        {

            ConcreteCollection collection = new ConcreteCollection();
            collection.AddHotels(new Hotels("Hotel Warszawa", 100, 5));
            collection.AddHotels(new Hotels("Centrum Hotel", 101,5));
            collection.AddHotels(new Hotels("Example Hotel", 102,5));
            collection.AddHotels(new Hotels("Example Hotel 2", 103,4));
            collection.AddHotels(new Hotels("Example Hotel 3", 104,2));
            collection.AddHotels(new Hotels("Example Hotel 4", 105,5));


            Iterator iterator = collection.CreateIterator();
   
            Console.WriteLine("Iterating over collection:");

            for (Hotels hotel = iterator.First(); !iterator.IsCompleted; hotel = iterator.Next())
            {
                Console.WriteLine($"HOTEL ID : {hotel.ID} & Hotel Name : {hotel.Name} & Hotel Stars : {hotel.Star}");
            }
            Console.Read();
        }
    }
}

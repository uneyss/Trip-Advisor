using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Classes
{
    internal class otelRoomNormal : Interface
    {
        public void description(int price, int number_people, string jacuzzi, string kitchen)
        {
            Console.WriteLine("Normal Room" + number_people + "-people. \n Will be kitchen? " + kitchen + " \n Will be jacuzzi ?" + jacuzzi + " \nPrice: " + price);

        }
}
}
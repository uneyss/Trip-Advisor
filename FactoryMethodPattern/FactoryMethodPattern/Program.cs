using FactoryMethodPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory otel = new Choice();

            Interface otelRoomNormal = otel.GetRoom("otelRoomNormal");
            otelRoomNormal.description(100,10,"no","yes");

            Interface otelRoomVip = otel.GetRoom("otelRoomVip");
            otelRoomVip.description(100, 10, "yes", "yes");

            Console.ReadKey();

        }
    }
}

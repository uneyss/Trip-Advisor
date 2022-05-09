﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TemplateProjekt.Klasy
{
    internal class OtelLodz : MainClass
    {
        String text;
        public override void Assignment(String room)
        {
            if (room == "Single")
            {
                Console.WriteLine("Reservation day");
                String price = Console.ReadLine();
                text = "Hotel Lodz, Room Type: Single , Reservation Price " + price + "zl";
                Console.WriteLine(text);

            }
            else if (room == "Family")
            {
                Console.WriteLine("Reservation day");
                String price = Console.ReadLine();
                text = "Hotel Lodz, Room Type: Family , Reservation Price " + price + "zl";
                Console.WriteLine(text);

            }
            else if (room == "VIP")
            {
                Console.WriteLine("Reservation day");
                String price = Console.ReadLine();
                text = "Hotel Lodz, Room Type: VIP , Reservation Price " + price + "zl";
                Console.WriteLine(text);

            }
        }
        public override void Save()
        {
            File.AppendAllText("plik.txt", text);
        }
    }
}

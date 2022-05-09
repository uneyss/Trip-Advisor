using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateProjekt.Klasy;
using System.Threading.Tasks;

namespace TemplateProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the city you want to book -> " +
                              "Warsaw - Lodz - Krakow - Poznan");
            String choose = Convert.ToString(Console.ReadLine());

            if (choose == "Warsaw")
            {
                Console.WriteLine("Available rooms -> Single - VIP");
                MainClass warsaw = new OtelWarsaw();
                String model = Convert.ToString(Console.ReadLine());
                warsaw.Implementation(model);
            }
            else if (choose == "Lodz")
            {
                Console.WriteLine("Available rooms -> Family - VIP");
                MainClass lodz = new OtelLodz();
                String model = Convert.ToString(Console.ReadLine());
                lodz.Implementation(model);
            }
            else if (choose == "Krakow")
            {
                Console.WriteLine("Available rooms -> Family - VIP");
                MainClass krakow = new OtelKrakow();
                String model = Convert.ToString(Console.ReadLine());
                krakow.Implementation(model);
            }
            else if (choose == "Poznan")
            {
                Console.WriteLine("Available rooms -> Family - VIP");
                MainClass poznan = new OtelPoznan();
                String model = Convert.ToString(Console.ReadLine());
                poznan.Implementation(model);
            }
            else 
            {
                Console.WriteLine("Something Went Wrong."); 
            }
            Console.ReadKey();
        }
    }
}

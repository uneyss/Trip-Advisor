using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class main
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.Instancja;
            singleton.Okres = 60;
            singleton.Room_type = "Premium";
            singleton.Name_Surname = "Uneys Ahmet Alkis";
            Console.WriteLine("Room \n" + singleton.Room_type + " Reservation Owner = " + singleton.Name_Surname + " period " + singleton.Okres);
            Console.ReadKey();


        }


    }
}


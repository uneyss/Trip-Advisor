using FacadePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ReservationFacade facade_v2 = new ReservationFacade();

            facade_v2.CreateFinalReservation();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
     class ReservationGender
    {
        public void SetReservationGender(string gender)
        {
            Console.WriteLine("The gender of the reservation person :" + gender);
        }
    }
}

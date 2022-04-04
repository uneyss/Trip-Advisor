using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
    class ReservationPhoneNo
    {
        public void SetReservationPhoneNo(int number)
        {
            Console.WriteLine("The phone number of the reservation person :" + number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
     class ReservationFacade
    {
        ReservationName name;
        ReservationSurname surname;
        ReservationGender gender;
        ReservationPhoneNo number;
        ReservationAdres adres;

        public ReservationFacade()
        {
            name = new ReservationName();
            surname = new ReservationSurname();
            gender = new ReservationGender();
            number = new ReservationPhoneNo();
            adres = new ReservationAdres();
        }

        public void CreateFinalReservation()
        {
            Console.WriteLine("Reservation\n");

            Console.WriteLine("Name ?");
            string name_ = Convert.ToString(Console.ReadLine());
            name.SetReservationName(name_);

            Console.WriteLine("Surname ?");
            string surname_ = Convert.ToString(Console.ReadLine());
            surname.SetReservationSurname(surname_);

            Console.WriteLine("Gender ?");
            string gender_ = Convert.ToString(Console.ReadLine());
            gender.SetReservationGender(gender_);

            Console.WriteLine("Phone Number ?");
            int number_ = Convert.ToInt32(Console.ReadLine());
            number.SetReservationPhoneNo(number_);


            Console.WriteLine("Adress ?");
            string adres_ = Convert.ToString(Console.ReadLine());
            adres.SetReservationAdres(adres_);

            Console.WriteLine("Reservation done");
        }
    }
}

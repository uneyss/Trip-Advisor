using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Singleton
    {

        private static Singleton instancja = new Singleton();


        private int okres;
        private string room_type, name_Surname;

        private Singleton() { }


        internal static Singleton Instancja
        {
            get => instancja;
            set => instancja = value;
        }

        public int Okres { get => okres; set => okres = value; }
        public string Room_type { get => room_type; set => room_type = value; }
        public string Name_Surname { get => name_Surname; set => name_Surname = value; }


    }



}




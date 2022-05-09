using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProjekt.Klasy
{
    abstract class MainClass
    {
        public abstract void Save();
        public abstract void Assignment(String worth);

        public void Implementation(String value)
        {
            Assignment(value);
            Save();
        }
    }
}

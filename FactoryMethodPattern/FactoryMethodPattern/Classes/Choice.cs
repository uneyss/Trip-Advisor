using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Classes
{
    internal class Choice : Factory
    {
        public override Interface GetRoom(String Room)
        {
            switch (Room)
            {
                case "otelRoomNormal":
                    return new otelRoomNormal();
                case "otelRoomVip":
                    return new otelRoomVip();
                default:
                    throw new ApplicationException(String.Format("Wrong choice", Room));
            }
        }
    }
}
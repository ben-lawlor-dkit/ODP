using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class StandardRoom : IRoom
    {
        public string GetInfo()
        {
            return "Standard room";
        }

        public double GetPrice()
        {
            return 129.99;
        }
    }
}

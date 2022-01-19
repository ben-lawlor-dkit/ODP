using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class AddBreakfast : RoomDecorator
    {
        public AddBreakfast(IRoom room) : base(room)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 15.99;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ", breakfast";
        }
    }
}

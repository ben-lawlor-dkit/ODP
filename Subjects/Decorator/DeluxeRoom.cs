using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class DeluxeRoom : RoomDecorator
    {
        public DeluxeRoom(IRoom room) : base(room)
        {
        }

        public override string GetInfo()
        {
            return "Deluxe room, breakfast & dinner included";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 170;
        }

    }
}

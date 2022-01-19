using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class StandardRoomOnSale : RoomDecorator
    {
        public StandardRoomOnSale(IRoom room) : base(room)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() - 15.99;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + ", On Sale";
        }


    }
}

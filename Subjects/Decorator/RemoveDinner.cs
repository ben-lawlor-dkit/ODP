using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class RemoveDinner : RoomDecorator
    {
        public RemoveDinner(IRoom room) : base(room)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() - 29.99;
        }

        public override string GetInfo()
        {
            string removeBreakfast = base.GetInfo().Replace(", dinner", "");
            return removeBreakfast;
        }
    }
}
